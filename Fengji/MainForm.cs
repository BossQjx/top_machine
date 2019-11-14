using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;
using System.Threading;
using SuperSocket.SocketBase;
using SuperSocket.SocketBase.Config;
using SuperSocket.SocketBase.Protocol;
using DevExpress.XtraCharts;
using System.Text.RegularExpressions;
using System.Text;
using System.Drawing;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using System.Collections.Generic;
/*
 * 目前考虑在timer_tick里开启线程  通过互斥量的操作保护完整的数据包
 * 还没有编写数据处理的代码
 * 尽量使 数据解析、数据显示、数据存储三个过程分散在三个线程里   进行并行互斥的操作
 *       目前的想法: 数据转换完成后  打包的处理数据通过中间数转存给另一个数组 用于显示和存储  以不影响数据采集  
 *       
 *       但有个问题:转换马上完成时，若另两个进程想取数  则会让另两个线程延迟一个timer周期
 *       
 *       现在需要解决的首要问题:mac地址解析有问题  不能保证所有的mac的最后一位都能解析出来（fffd）
 *                              mac地址匹配问题  暂时的想法:在数据解析后  再弄个string存储mac  和数据打包传给显示模块
 * 
 * 
 * 第二日想法:将存储单独放入一个线程 并且当程序刚开始时就开始线程 用转换完成标志量控制进程发生与否
 *             显示放在ticker里  与曹晟学长之前的配置差不多
 * 
 * 第三日问题：速度问题差不多解决了  但是存储线程会报错  怀疑线程未完成
 * 
 *    解决方法设想：在线程池传递函数内传递参数（MAC+时间） 就可以不管数据何时存储了
 * 
 * 9.25代码执行效率还不错  理论上调低存储循环数 并增加显示判断方案应该能更稳定一些
 * 11.6有了一个新的想法：用动态队列去做消息处理 用一个结构体作为数据的队列单元  定时清空数据队列并存储到数据库 数据库需要常开
 *                      详情见txt_test这个工程文件       需要解决的问题：时间冲突问题
 * 11.7的想法：为了实现chart切换显示的时候的数据存留问题，是不是可以用四个chart  每次切换的时候用两个chart，设置好显示的属性，这样就可以实现存留上次切换的数据了
 *              问题：不能用太多节点  不然感觉有点多
 * 11.9：今天先做一些结构体的迁移  显示线程其实用不上这个  所以目前先用txt试一试    
 * 
 */

namespace Fengji
{
    struct datastream
    {
        public string macaddr;                  //数据来源的MAC地址
        public double hor;                      //水平方向的震动数据 （处理后的）
        public double ver;                      //垂直方向的震动数据 （处理后的）
        public DateTime rtime;                  //数据时间戳 实际上这个是处理完数据的时间  和采集时间有出入
    }
    public partial class MainForm : Form
    {
        datastream current_ds;                  //声明一个数据结构体 用来存放数据  详细内容见上面的结构体声明
        Queue<datastream> que = new Queue<datastream>();    //声明一个动态先入先出队列  用来存储到来的数据   供后面数据存储用
        AutoResizeForm asc = new AutoResizeForm();          //自动窗口缩放功能的实现   具体在后面实现递归操作
        private MyAppServer appServer = new MyAppServer();  //用来声明一个socke服务器，这是个必须的声明且必须先声明
        private bool start = false;             //在开始采集和停止采集按钮内定义的标志量   目前隐藏了这两个按钮
        Thread process1,thread2;                //用到的线程声明   暂时用到两个 分别用来显示chart和存储数据
        TimeSpan timeSpan_30_s = new TimeSpan(0, 0, 3, 30); //这个是chart左右窗口的时间窗
        SeriesPoint p1;
        SeriesPoint p2;                         //声明chart坐标上的点
        float data1 = 1;
        float data2 = 1;                        //用来显示在chart上的中转数据
        string MAC_to_show = "";                //用来分辨要显示的MAC地址  和当前MAC地址比较 相同就显示 不同就不显示
        string MAC = "0";                       //当前包的MAC   和MAC_to_show比较 相同就显示 不同就不显示
        int package_cnt = 0;                    //接收数据包的计数变量
        int save_count = 0;                     //存储线程里的计数变量
        Int16 button_isDownflag = 0;            //指示哪个节点显示按钮按下的标志量
        double data1_show_a4 = 0;
        double data2_show_a4 = 0;
        double data1_show_b4 = 0;
        double data2_show_b4 = 0;               //用来显示的中转变量
        Boolean start_database = false;         //暂时没用  在数据库连接按钮中用到一次 但暂时不用它的功能
        double[] trans_data = new double[1000]; //用来存储转换后的数值 其实700个就够  为了数组不越界  暂时取1000个
                                                
        //Series hori_vib1 { get { return chartControl1.Series["水平振动"]; } }
        // Series vert_vib2 { get { return chartControl2.Series["垂直振动"]; } }            //暂时没用到
        Series vert_vib1 { get { return chartControl1.Series["垂直振动"]; } }               //设计器上的垂直震动曲线声明
        Series hori_vib2 { get { return chartControl2.Series["水平振动"]; } }               //设计器上的水平震动曲线声明
        Series vert_vib3 { get { return chartControl3.Series["垂直振动"]; } }               //设计器上的垂直震动曲线声明
        Series hori_vib4 { get { return chartControl4.Series["水平振动"]; } }               //设计器上的水平震动曲线声明
        XYDiagram diagram1 { get { return (XYDiagram)chartControl1.Diagram; } }             //两个chart的图形区域声明
        XYDiagram diagram2 { get { return (XYDiagram)chartControl2.Diagram; } }
        XYDiagram diagram3 { get { return (XYDiagram)chartControl3.Diagram; } }             //两个chart的图形区域声明
        XYDiagram diagram4 { get { return (XYDiagram)chartControl4.Diagram; } }
        public static string[] Node_MAC { get; set; } =new string[10] { "f2c7", "e618", "0x5C"," 0", "0", "0","0", "0", "0","0" };//节点的MAC地址
        /// <summary>
        /// MainForm入口函数    调用初始化函数和开启两个线程
        /// </summary>
        public MainForm()
        {
            InitializeComponent();                                   //初始化界面和事件
            TextBox.CheckForIllegalCrossThreadCalls = false;         //这个用来保证线程不会冲突
            process1 = new Thread(new ThreadStart(threadmethod1));   //显示线程
            thread2 = new Thread(save__thread);                      //存储线程
            process1.Start();                                        //显示线程开启
            thread2.Start();                                         //存储线程开启
        }
        private void Form_Load(object sender, EventArgs e)           //界面加载函数  在设计文件里通过加载事件调用
        {
            var serverConfig = new ServerConfig                      //appserver初始化用到的结构体
            {
                Port = 1400,                                         //开启端口1400
                Ip = "Any",                                          //IP根据实际连接的IP显示
                ReceiveBufferSize = 160 * 1417,                      //接收buffer  这里每个数据包是1417个字节    设置160个缓冲区
                MaxRequestLength = 6000,                             //最大请求长度   默认设置
            };
            try
            {
                asc.controllInitializeSize(this);                    //初始化自动缩放窗口功能
                Rectangle rect = new Rectangle();
                rect = Screen.GetWorkingArea(this);
                this.Width = (int)(rect.Width ); // 设置窗体宽度
                this.Height = (int)(rect.Height  ); // 设置窗体高度   //得到当前窗口尺寸信息
                series_init();                                        //初始化chart上曲线      
                appServer.Setup(serverConfig);                        //按照设置开启appserver
                appServer.NewRequestReceived += new RequestHandler<MyAppSession, BinaryRequestInfo>(appServer_NewRequestReceived);  //收到请求时的事件
                appServer.NewSessionConnected += new SessionHandler<MyAppSession>(appServer_NewSessionConnected);                   //有新连接时的事件
                appServer.SessionClosed += new SessionHandler<MyAppSession, SuperSocket.SocketBase.CloseReason>(appServer_SessionClosed);   //有连接关闭时的事件
                appServer.Start();                                    //启动appserver
                Console.WriteLine("server is:" + appServer.State.ToString()); //调试用 可以删掉
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
            }
        }
       
        
        /// <summary>
        /// 窗体变化时对窗体内控件进行调整的函数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form2_SizeChanged(object sender, EventArgs e)
        {
            asc.controlAutoSize(this);          //递归调整窗体内部件大小的函数        尽量保留
            this.label1.Font =new System.Drawing.Font("楷体",this.Width/90, FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));         //以下为自动调整字体的语句  稍微繁琐一点  分别调整了不同部件
            this.label2.Font = new System.Drawing.Font("楷体", this.Width / 45, FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Font = new System.Drawing.Font("楷体", this.Width / 45, FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Font = new System.Drawing.Font("楷体", this.Width / 95, FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Font = new System.Drawing.Font("楷体", this.Width / 95, FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.Font = new System.Drawing.Font("楷体", this.Width / 95, FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.停止采集.Font = new System.Drawing.Font("楷体", this.Width / 90, FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.开始采集.Font = new System.Drawing.Font("楷体", this.Width / 90, FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Font = new System.Drawing.Font("楷体", this.Width / 90, FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.Font = new System.Drawing.Font("楷体", this.Width / 90, FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button3.Font = new System.Drawing.Font("楷体", this.Width / 90, FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button4.Font = new System.Drawing.Font("楷体", this.Width / 90, FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button5.Font = new System.Drawing.Font("楷体", this.Width / 90, FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.simpleButton1.Font = new System.Drawing.Font("楷体", this.Width / 105, FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.simpleButton2.Font = new System.Drawing.Font("楷体", this.Width / 105, FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.simpleButton3.Font = new System.Drawing.Font("楷体", this.Width / 105, FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.simpleButton4.Font = new System.Drawing.Font("楷体", this.Width / 105, FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.simpleButton5.Font = new System.Drawing.Font("楷体", this.Width / 105, FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.simpleButton6.Font = new System.Drawing.Font("楷体", this.Width / 105, FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.simpleButton7.Font = new System.Drawing.Font("楷体", this.Width / 105, FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.simpleButton8.Font = new System.Drawing.Font("楷体", this.Width / 105, FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.simpleButton9.Font = new System.Drawing.Font("楷体", this.Width / 105, FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.simpleButton10.Font = new System.Drawing.Font("楷体", this.Width / 105, FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.本机IP.Font = new System.Drawing.Font("楷体", this.Width / 90, FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.本机端口号.Font = new System.Drawing.Font("楷体", this.Width / 90, FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox1.Font = new System.Drawing.Font("楷体", this.Width / 90, FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox2.Font = new System.Drawing.Font("楷体", this.Width / 90, FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox3.Font = new System.Drawing.Font("楷体", this.Width / 45, FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox4.Font = new System.Drawing.Font("楷体", this.Width / 45, FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox7.Font = new System.Drawing.Font("楷体", this.Width / 90, FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox8.Font = new System.Drawing.Font("楷体", this.Width / 90, FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox9.Font = new System.Drawing.Font("楷体", this.Width / 90, FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelControl1.Font = new System.Drawing.Font("楷体", this.Width / 40, FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            
        }
        /// <summary>
        /// 有新连接时的事件处理函数
        /// </summary>
        /// <param name="session"></param>
        private void appServer_NewSessionConnected(MyAppSession session)                        //这个里面和断开连接里面的逻辑还有点问题  有待优化
        {
            this.textBox1.Text = session.SocketSession.LocalEndPoint.Address.ToString();        //显示当前终端的地址和端口
            this.textBox2.Text = session.SocketSession.LocalEndPoint.Port.ToString();
            string ip = session.SocketSession.RemoteEndPoint.Address.ToString();                //得到远程节点的地址和端口
            string port = session.SocketSession.RemoteEndPoint.Port.ToString();
            if (!listView1.Items.ContainsKey(ip))
            {
                try
                {
                    this.listView1.Items.Add(ip, ip, null);
                    this.listView1.Items[ip].SubItems.AddRange(new string[] { port, "已连接", "根节点" });
                }
                catch
                {
                    if (listView1 == null)
                        this.listView1.Items.Clear();
                    return;
                }
            }
            else
            {
                try
                {
                    this.listView1.Items[ip].SubItems[1].Text = port;
                    this.listView1.Items[ip].SubItems[2].Text = "已连接";
                    this.listView1.Items[ip].SubItems[3].Text = "根节点";
                }
                catch
                {
                    if (listView1 == null)
                        this.listView1.Items.Clear();
                    return;
                }
            }
            if (listView1 != null)
                this.listView1.Items[ip].Selected = true;
        }
        
        private void appServer_SessionClosed(MyAppSession session, SuperSocket.SocketBase.CloseReason reason)
        {
            string ip = session.SocketSession.RemoteEndPoint.Address.ToString();
            Console.WriteLine(reason.ToString());
            Console.WriteLine("断开连接：" + reason);
            listView1.Items[ip].Remove();
        }
        /// <summary>
        /// 新请求处理函数     主要的数据处理做在这里
        /// </summary>
        /// <param name="session"></param>
        /// <param name="requestInfo"></param>
        private void appServer_NewRequestReceived(MyAppSession session, BinaryRequestInfo requestInfo)
        {
            //session.Send("OK");
            try
            {
                if (true)
                {
                    MAC = Convert.ToString(requestInfo.Key[4], 16);                         //获取当前接收到的节点的MAC地址
                    int i = 0;
                    if (MAC.Equals("e618"))                                                 //不同节点精度不同  针对相应节点的数据精度优化
                    {
                        for (i = 0; i < 700 / 2; i++)
                        {
                            int temp1 = 0;
                            int temp2 = 0;
                            temp1 = requestInfo.Body[2 * i + 0];
                            temp2 = requestInfo.Body[2 * i + 1];
                            int temp = 0;
                            temp = (ushort)(temp2);
                            temp |= (ushort)((temp1 << 8) & 0xff00);
                            trans_data[i] = (temp * 1.0 / 65535.0 * 4.096 - 2.562f) * 37.69f;
                        }

                        for (i = 350; i < 1400 / 2; i++)
                        {
                            int temp1 = 0;
                            int temp2 = 0;
                            temp1 = requestInfo.Body[2 * i + 0];
                            temp2 = requestInfo.Body[2 * i + 1];
                            int temp = 0;
                            temp = (ushort)(temp2);
                            temp |= (ushort)((temp1 << 8) & 0xff00);
                            trans_data[i] = (temp * 1.0 / 65535.0 * 4.096 - 2.519f) * 39.54f;
                        }
                    }
                    else if (MAC.Equals("f2c7"))                                            //不同节点精度不同  针对相应节点的数据精度优化
                    {
                        for (i = 0; i < 700 / 2; i++)
                        {
                            int temp1 = 0;
                            int temp2 = 0;
                            temp1 = requestInfo.Body[2 * i + 0];
                            temp2 = requestInfo.Body[2 * i + 1];
                            int temp = 0;
                            temp = (ushort)(temp2);
                            temp |= (ushort)((temp1 << 8) & 0xff00);
                            trans_data[i] = (temp * 1.0 / 65535.0 * 4.096 - 2.566f) * 38.66f;
                           
                        }
                        for (i = 350; i < 1400 / 2; i++)
                        {
                            int temp1 = 0;
                            int temp2 = 0;
                            temp1 = requestInfo.Body[2 * i + 0];
                            temp2 = requestInfo.Body[2 * i + 1];
                            int temp = 0;
                            temp = (ushort)(temp2);
                            temp |= (ushort)((temp1 << 8) & 0xff00);
                            trans_data[i] = (temp * 1.0 / 65535.0 * 4.096 - 2.542f) * 38.12f;
                           
                        }
                    }
                    data1_show_b4 = (trans_data[100] + trans_data[103] + trans_data[105] + trans_data[107] + trans_data[109]) / 5.0f;       //采用平均值的形式取一组数据
                    data2_show_b4 = (trans_data[500] + trans_data[503] + trans_data[505] + trans_data[507] + trans_data[509]) / 5.0f;
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.ToString());
            }
            finally
            {
                DateTime Time = DateTime.Now.AddMilliseconds(DateTime.Now.Millisecond);
                current_ds.rtime = Time;
                current_ds.hor = data1_show_b4;
                current_ds.ver = data2_show_b4;
                current_ds.macaddr = MAC.ToString();
                que.Enqueue(current_ds);                 //向队列中加入最新的数据  由于存储速度的限制  显示功能不能用这个队列
                package_cnt++;
            }
        }
        public static bool IsFloat(string str)
        {
            string regextext = @"^(-?\d+)(\.\d+)?$";
            Regex regex = new Regex(regextext, RegexOptions.None);
            return regex.IsMatch(str.Trim());
        }
        private void text_show()
        {
                DateTime time = DateTime.Now;
                try
                {
                    if (MAC.Equals("e618"))
                    {
                        data1 = (float)Convert.ToDouble(data1_show_b4.ToString("F3"));                      //转换成三位有效数字的浮点型进行显示
                        data2 = (float)Convert.ToDouble(data2_show_b4.ToString("F3"));
                    //this.arcScaleComponent1.Value = data1;    //仪表盘的  暂时不删掉
                    //this.arcScaleComponent3.Value = data2;
                         if (MAC_to_show == MAC)
                         {
                             textBox3.Text = data1.ToString();                                                    //显示在相应文本框内
                             textBox4.Text = data2.ToString();
                         }
                        try
                        {
                            if (data1 >= -110 && data1 <= 70 && data2 >= -110 && data2 <= 70)               //显示数据设限    但是一般都不会出现这样的值
                            {
                                p1 = new SeriesPoint(time.AddMilliseconds(time.Millisecond/10), data1);     //给点赋值
                                p2 = new SeriesPoint(time.AddMilliseconds(time.Millisecond/10), data2);
                                hori_vib2.Points.Add(p1);                                                   //向曲线上添加点
                                vert_vib1.Points.Add(p2);
                                diagram1.AxisX.VisualRange.MaxValue = time;                                 //向左移动窗口
                                diagram1.AxisX.VisualRange.MinValue = time - timeSpan_30_s;
                                diagram2.AxisX.VisualRange.MaxValue = time;
                                diagram2.AxisX.VisualRange.MinValue = time - timeSpan_30_s;
                            }
                        }
                        catch
                        {
                            this.Refresh();
                        }
                    }
                else if (MAC.Equals("f2c7"))
                {
                    data1 = (float)Convert.ToDouble(data1_show_b4.ToString("F3"));                      //转换成三位有效数字的浮点型进行显示
                    data2 = (float)Convert.ToDouble(data2_show_b4.ToString("F3"));
                    //this.arcScaleComponent1.Value = data1;    //仪表盘的  暂时不删掉
                    //this.arcScaleComponent3.Value = data2;
                    if (MAC_to_show == MAC)
                    {
                        textBox3.Text = data1.ToString();                                                    //显示在相应文本框内
                        textBox4.Text = data2.ToString();
                    }
                    try
                    {
                        if (data1 >= -110 && data1 <= 70 && data2 >= -110 && data2 <= 70)               //显示数据设限    但是一般都不会出现这样的值
                        {
                            p1 = new SeriesPoint(time.AddMilliseconds(time.Millisecond / 10), data1);     //给点赋值
                            p2 = new SeriesPoint(time.AddMilliseconds(time.Millisecond / 10), data2);
                            hori_vib4.Points.Add(p1);                                                   //向曲线上添加点
                            vert_vib3.Points.Add(p2);
                            diagram3.AxisX.VisualRange.MaxValue = time;                                 //向左移动窗口
                            diagram3.AxisX.VisualRange.MinValue = time - timeSpan_30_s;
                            diagram4.AxisX.VisualRange.MaxValue = time;
                            diagram4.AxisX.VisualRange.MinValue = time - timeSpan_30_s;
                        }
                    }
                    catch
                    {
                        this.Refresh();
                    }
                }
            }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
        }
        private void 开始采集_Click(object sender, EventArgs e)
        {
            (sender as Button).Enabled = false;
            停止采集.Enabled = true;
            start = true;

        }
        private void 停止采集_Click(object sender, EventArgs e)
        {
            start = false;
            (sender as Button).Enabled = false;
            开始采集.Enabled = true;
        }
        /// <summary>
        /// 连接数据库按钮  目前用不到，用来创建数据库和表界面  后续可能会修改
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection();
            string SQL_String = "server=localhost;User Id=qjx;password=qiao291633139;Database=zhendong";
            conn.ConnectionString = SQL_String;
            string sql = null;
            try
            {
                conn.Open();
                sql = "CREATE DATABASE IF NOT EXISTS `zhendong`;use zhendong;";
                MySqlCommand mycmd1 = new MySqlCommand(sql, conn);
                mycmd1.ExecuteNonQuery();
                sql = "CREATE TABLE IF NOT EXISTS `zd_test` (`id` int(11) NOT NULL AUTO_INCREMENT,`IP` tinytext NOT NULL,`horizontal_vibration` double NOT NULL,`vertical_vibration` double NOT NULL,`date` datetime NOT NULL,`cnt_in_1s` int(5),`TIM` tinytext NOT NULL,PRIMARY KEY(`id`) ) ENGINE = MyISAM AUTO_INCREMENT = 1 DEFAULT CHARSET = latin1;";
                mycmd1 = new MySqlCommand(sql, conn);
                mycmd1.ExecuteNonQuery();
                MessageBox.Show("连接数据库成功");
                //save_data_ready = 1;
                start_database = true;
            }
            catch (Exception er)
            {
                MessageBox.Show("连接数据库失败");
                MessageBox.Show(er.ToString());
            }
            finally
            {
                conn.Close();
            }
        }

        /// <summary>
        /// 打开历史数据查询窗口按键
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
        }
        /// <summary>
        /// 退出按键，由于无边框最大化，设置为关闭窗口功能
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            {
                //this.Close();   //只是关闭当前窗口，若不是主窗体的话，是无法退出程序的，另外若有托管线程（非主线程），也无法干净地退出；
               // Application.Exit();  //强制所有消息中止，退出所有的窗体，但是若有托管线程（非主线程），也无法干净地退出；
                //Application.ExitThread(); //强制中止调用线程上的所有消息，同样面临其它线程无法正确退出的问题；
                System.Environment.Exit(0);   //这是最彻底的退出方式，不管什么线程都被强制退出，把程序结束的很干净。
            }
        }
        /// <summary>
        /// 绑定IP的按键功能
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click(object sender, EventArgs e)
        {
            绑定IP BindingIP = new 绑定IP();
            BindingIP.Show();
        }
        /// <summary>
        /// 对按键按下变颜色的功能设置，较繁琐，可能需要简化
        /// </summary>
        private void chg_btn_color()
        {
            switch (button_isDownflag)
            {
                case 0x01:
                    {
                        simpleButton2.Appearance.BackColor = simpleButton1.AppearanceDisabled.BackColor;
                        simpleButton3.Appearance.BackColor = simpleButton1.AppearanceDisabled.BackColor;
                        simpleButton4.Appearance.BackColor = simpleButton1.AppearanceDisabled.BackColor;
                        simpleButton5.Appearance.BackColor = simpleButton1.AppearanceDisabled.BackColor;
                        simpleButton6.Appearance.BackColor = simpleButton1.AppearanceDisabled.BackColor;
                        simpleButton7.Appearance.BackColor = simpleButton1.AppearanceDisabled.BackColor;
                        simpleButton8.Appearance.BackColor = simpleButton1.AppearanceDisabled.BackColor;
                        simpleButton9.Appearance.BackColor = simpleButton1.AppearanceDisabled.BackColor;
                        simpleButton10.Appearance.BackColor = simpleButton1.AppearanceDisabled.BackColor;
                        simpleButton1.Appearance.BackColor = simpleButton1.AppearancePressed.BackColor;
                        break;
                    }
                case 0x10:
                    {

                        simpleButton1.Appearance.BackColor = simpleButton1.AppearanceDisabled.BackColor;
                        simpleButton3.Appearance.BackColor = simpleButton1.AppearanceDisabled.BackColor;
                        simpleButton4.Appearance.BackColor = simpleButton1.AppearanceDisabled.BackColor;
                        simpleButton5.Appearance.BackColor = simpleButton1.AppearanceDisabled.BackColor;
                        simpleButton6.Appearance.BackColor = simpleButton1.AppearanceDisabled.BackColor;
                        simpleButton7.Appearance.BackColor = simpleButton1.AppearanceDisabled.BackColor;
                        simpleButton8.Appearance.BackColor = simpleButton1.AppearanceDisabled.BackColor;
                        simpleButton9.Appearance.BackColor = simpleButton1.AppearanceDisabled.BackColor;
                        simpleButton10.Appearance.BackColor = simpleButton1.AppearanceDisabled.BackColor;
                        simpleButton2.Appearance.BackColor = simpleButton1.AppearancePressed.BackColor;
                        break;
                    }
                case 0x11:
                    {

                        simpleButton2.Appearance.BackColor = simpleButton1.AppearanceDisabled.BackColor;
                        simpleButton1.Appearance.BackColor = simpleButton1.AppearanceDisabled.BackColor;
                        simpleButton4.Appearance.BackColor = simpleButton1.AppearanceDisabled.BackColor;
                        simpleButton5.Appearance.BackColor = simpleButton1.AppearanceDisabled.BackColor;
                        simpleButton6.Appearance.BackColor = simpleButton1.AppearanceDisabled.BackColor;
                        simpleButton7.Appearance.BackColor = simpleButton1.AppearanceDisabled.BackColor;
                        simpleButton8.Appearance.BackColor = simpleButton1.AppearanceDisabled.BackColor;
                        simpleButton9.Appearance.BackColor = simpleButton1.AppearanceDisabled.BackColor;
                        simpleButton10.Appearance.BackColor = simpleButton1.AppearanceDisabled.BackColor;
                        simpleButton3.Appearance.BackColor = simpleButton1.AppearancePressed.BackColor;
                        break;
                    }
                case 0x100:
                    {

                        simpleButton2.Appearance.BackColor = simpleButton1.AppearanceDisabled.BackColor;
                        simpleButton3.Appearance.BackColor = simpleButton1.AppearanceDisabled.BackColor;
                        simpleButton1.Appearance.BackColor = simpleButton1.AppearanceDisabled.BackColor;
                        simpleButton5.Appearance.BackColor = simpleButton1.AppearanceDisabled.BackColor;
                        simpleButton6.Appearance.BackColor = simpleButton1.AppearanceDisabled.BackColor;
                        simpleButton7.Appearance.BackColor = simpleButton1.AppearanceDisabled.BackColor;
                        simpleButton8.Appearance.BackColor = simpleButton1.AppearanceDisabled.BackColor;
                        simpleButton9.Appearance.BackColor = simpleButton1.AppearanceDisabled.BackColor;
                        simpleButton10.Appearance.BackColor = simpleButton1.AppearanceDisabled.BackColor;
                        simpleButton4.Appearance.BackColor = simpleButton1.AppearancePressed.BackColor;
                        break;
                    }
                case 0x101:
                    {

                        simpleButton2.Appearance.BackColor = simpleButton1.AppearanceDisabled.BackColor;
                        simpleButton3.Appearance.BackColor = simpleButton1.AppearanceDisabled.BackColor;
                        simpleButton4.Appearance.BackColor = simpleButton1.AppearanceDisabled.BackColor;
                        simpleButton1.Appearance.BackColor = simpleButton1.AppearanceDisabled.BackColor;
                        simpleButton6.Appearance.BackColor = simpleButton1.AppearanceDisabled.BackColor;
                        simpleButton7.Appearance.BackColor = simpleButton1.AppearanceDisabled.BackColor;
                        simpleButton8.Appearance.BackColor = simpleButton1.AppearanceDisabled.BackColor;
                        simpleButton9.Appearance.BackColor = simpleButton1.AppearanceDisabled.BackColor;
                        simpleButton10.Appearance.BackColor = simpleButton1.AppearanceDisabled.BackColor;
                        simpleButton5.Appearance.BackColor = simpleButton1.AppearancePressed.BackColor;
                        break;
                    }
                case 0x110:
                    {

                        simpleButton2.Appearance.BackColor = simpleButton1.AppearanceDisabled.BackColor;
                        simpleButton3.Appearance.BackColor = simpleButton1.AppearanceDisabled.BackColor;
                        simpleButton4.Appearance.BackColor = simpleButton1.AppearanceDisabled.BackColor;
                        simpleButton5.Appearance.BackColor = simpleButton1.AppearanceDisabled.BackColor;
                        simpleButton1.Appearance.BackColor = simpleButton1.AppearanceDisabled.BackColor;
                        simpleButton7.Appearance.BackColor = simpleButton1.AppearanceDisabled.BackColor;
                        simpleButton8.Appearance.BackColor = simpleButton1.AppearanceDisabled.BackColor;
                        simpleButton9.Appearance.BackColor = simpleButton1.AppearanceDisabled.BackColor;
                        simpleButton10.Appearance.BackColor = simpleButton1.AppearanceDisabled.BackColor;
                        simpleButton6.Appearance.BackColor = simpleButton1.AppearancePressed.BackColor;
                        break;
                    }
                case 0x0111:
                    {

                        simpleButton2.Appearance.BackColor = simpleButton1.AppearanceDisabled.BackColor;
                        simpleButton3.Appearance.BackColor = simpleButton1.AppearanceDisabled.BackColor;
                        simpleButton4.Appearance.BackColor = simpleButton1.AppearanceDisabled.BackColor;
                        simpleButton5.Appearance.BackColor = simpleButton1.AppearanceDisabled.BackColor;
                        simpleButton6.Appearance.BackColor = simpleButton1.AppearanceDisabled.BackColor;
                        simpleButton1.Appearance.BackColor = simpleButton1.AppearanceDisabled.BackColor;
                        simpleButton8.Appearance.BackColor = simpleButton1.AppearanceDisabled.BackColor;
                        simpleButton9.Appearance.BackColor = simpleButton1.AppearanceDisabled.BackColor;
                        simpleButton10.Appearance.BackColor = simpleButton1.AppearanceDisabled.BackColor;
                        simpleButton7.Appearance.BackColor = simpleButton1.AppearancePressed.BackColor;
                        break;
                    }
                case 0x01000:
                    {

                        simpleButton2.Appearance.BackColor = simpleButton1.AppearanceDisabled.BackColor;
                        simpleButton3.Appearance.BackColor = simpleButton1.AppearanceDisabled.BackColor;
                        simpleButton4.Appearance.BackColor = simpleButton1.AppearanceDisabled.BackColor;
                        simpleButton5.Appearance.BackColor = simpleButton1.AppearanceDisabled.BackColor;
                        simpleButton6.Appearance.BackColor = simpleButton1.AppearanceDisabled.BackColor;
                        simpleButton7.Appearance.BackColor = simpleButton1.AppearanceDisabled.BackColor;
                        simpleButton1.Appearance.BackColor = simpleButton1.AppearanceDisabled.BackColor;
                        simpleButton9.Appearance.BackColor = simpleButton1.AppearanceDisabled.BackColor;
                        simpleButton10.Appearance.BackColor = simpleButton1.AppearanceDisabled.BackColor;
                        simpleButton8.Appearance.BackColor = simpleButton1.AppearancePressed.BackColor;
                        break;
                    }
                case 0x01001:
                    {

                        simpleButton2.Appearance.BackColor = simpleButton1.AppearanceDisabled.BackColor;
                        simpleButton3.Appearance.BackColor = simpleButton1.AppearanceDisabled.BackColor;
                        simpleButton4.Appearance.BackColor = simpleButton1.AppearanceDisabled.BackColor;
                        simpleButton5.Appearance.BackColor = simpleButton1.AppearanceDisabled.BackColor;
                        simpleButton6.Appearance.BackColor = simpleButton1.AppearanceDisabled.BackColor;
                        simpleButton7.Appearance.BackColor = simpleButton1.AppearanceDisabled.BackColor;
                        simpleButton8.Appearance.BackColor = simpleButton1.AppearanceDisabled.BackColor;
                        simpleButton1.Appearance.BackColor = simpleButton1.AppearanceDisabled.BackColor;
                        simpleButton10.Appearance.BackColor = simpleButton1.AppearanceDisabled.BackColor;
                        simpleButton9.Appearance.BackColor = simpleButton1.AppearancePressed.BackColor;
                        break;
                    }
                case 0x01010:
                    {

                        simpleButton2.Appearance.BackColor = simpleButton1.AppearanceDisabled.BackColor;
                        simpleButton3.Appearance.BackColor = simpleButton1.AppearanceDisabled.BackColor;
                        simpleButton4.Appearance.BackColor = simpleButton1.AppearanceDisabled.BackColor;
                        simpleButton5.Appearance.BackColor = simpleButton1.AppearanceDisabled.BackColor;
                        simpleButton6.Appearance.BackColor = simpleButton1.AppearanceDisabled.BackColor;
                        simpleButton7.Appearance.BackColor = simpleButton1.AppearanceDisabled.BackColor;
                        simpleButton8.Appearance.BackColor = simpleButton1.AppearanceDisabled.BackColor;
                        simpleButton9.Appearance.BackColor = simpleButton1.AppearanceDisabled.BackColor;
                        simpleButton1.Appearance.BackColor = simpleButton1.AppearanceDisabled.BackColor;
                        simpleButton10.Appearance.BackColor = simpleButton1.AppearancePressed.BackColor;
                        break;
                    }
                /* 您可以有任意数量的 case 语句 */
                default: /* 可选的 */
                    {
                        simpleButton1.Appearance.BackColor = simpleButton1.AppearanceDisabled.BackColor;
                        simpleButton2.Appearance.BackColor = simpleButton1.AppearanceDisabled.BackColor;
                        simpleButton3.Appearance.BackColor = simpleButton1.AppearanceDisabled.BackColor;
                        simpleButton4.Appearance.BackColor = simpleButton1.AppearanceDisabled.BackColor;
                        simpleButton5.Appearance.BackColor = simpleButton1.AppearanceDisabled.BackColor;
                        simpleButton6.Appearance.BackColor = simpleButton1.AppearanceDisabled.BackColor;
                        simpleButton7.Appearance.BackColor = simpleButton1.AppearanceDisabled.BackColor;
                        simpleButton8.Appearance.BackColor = simpleButton1.AppearanceDisabled.BackColor;
                        simpleButton9.Appearance.BackColor = simpleButton1.AppearanceDisabled.BackColor;
                        simpleButton10.Appearance.BackColor = simpleButton1.AppearanceDisabled.BackColor;
                        break;
                    }
            }
        }
        /// <summary>
        ///// 用来清除显示的曲线
        /// </summary>
        private void clear_series()
        {
            hori_vib2.Points.Clear();
            vert_vib1.Points.Clear();
            series_init();
        }
        /// <summary>
        /// 以下为对10个按钮的操作设置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void simpleButton1_Click_1(object sender, EventArgs e)
        {
           // clear_series();
            MAC_to_show = Node_MAC[0];
            button_isDownflag = 0x01;
            chg_btn_color();
            label1.Text = "当前显示节点：节点1";
            chartControl1.Visible = false;
            chartControl2.Visible = false;
            chartControl3.Visible = true;
            chartControl4.Visible = true;

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
           // clear_series();
            MAC_to_show = Node_MAC[1];
            button_isDownflag = 0x010;
            chg_btn_color();
            label1.Text = "当前显示节点：节点2";
            chartControl1.Visible = true;
            chartControl2.Visible = true;
            chartControl3.Visible = false;
            chartControl4.Visible = false;
        }
        private void simpleButton3_Click(object sender, EventArgs e)
        {
            clear_series();
            MAC_to_show = Node_MAC[2];
            button_isDownflag = 0x011;
            chg_btn_color();
            label1.Text = "当前显示节点：节点3";
        }
        private void simpleButton4_Click(object sender, EventArgs e)
        {
            clear_series();
            MAC_to_show = Node_MAC[3];
            button_isDownflag = 0x0100;
            chg_btn_color();
            label1.Text = "当前显示节点：节点4";
        }
        private void simpleButton5_Click(object sender, EventArgs e)
        {
            clear_series();
            MAC_to_show = Node_MAC[4];
            button_isDownflag = 0x0101;
            chg_btn_color();
            label1.Text = "当前显示节点：节点5";
        }
        private void simpleButton6_Click(object sender, EventArgs e)
        {
            clear_series();
            MAC_to_show = Node_MAC[5];
            button_isDownflag = 0x0110;
            chg_btn_color();
            label1.Text = "当前显示节点：节点6";
        }
        private void simpleButton7_Click(object sender, EventArgs e)
        {
            clear_series();
            MAC_to_show = Node_MAC[6];
            button_isDownflag = 0x0111;
            chg_btn_color();
            label1.Text = "当前显示节点：节点7";
        }

        private void simpleButton8_Click(object sender, EventArgs e)
        {
            clear_series();
            MAC_to_show = Node_MAC[7];
            button_isDownflag = 0x01000;
            chg_btn_color();
            label1.Text = "当前显示节点：节点8";
        }
        private void simpleButton9_Click(object sender, EventArgs e)
        {
            clear_series();
            MAC_to_show = Node_MAC[8];
            button_isDownflag = 0x01001;
            chg_btn_color();
            label1.Text = "当前显示节点：节点9";
        }

        private void simpleButton10_Click(object sender, EventArgs e)
        {
            clear_series();
            MAC_to_show = Node_MAC[9];
            button_isDownflag = 0x01010;
            chg_btn_color();
            label1.Text = "当前显示节点：节点10";
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
                if (process1.ThreadState.Equals(ThreadState.Suspended))
                {
                    process1.Resume();
                }
                textBox7.Text = Convert.ToString(package_cnt);
                textBox9.Text = Convert.ToString(package_cnt * 1.4) + 'K';
                textBox8.Text = Convert.ToString(save_count);
        }
        /// <summary>
        /// 进程1 主要进行数据循环显示 显示一次后就挂起 等待timer1的唤醒
        /// </summary>
        private void threadmethod1()
        {
            while (true)
            {
                text_show();
                process1.Suspend();
            }
        }
        private void series_init()
        {

            DateTime time = DateTime.Now;

            
           
                    data1 = 0;
                    data2 = 0;
                    //this.arcScaleComponent1.Value = data1;    //仪表盘的  暂时不删掉
                    //this.arcScaleComponent3.Value = data2;
                    textBox3.Text = data1.ToString();
                    textBox4.Text = data2.ToString();
            
                            p1 = new SeriesPoint(time.AddMilliseconds(time.Millisecond / 10) - timeSpan_30_s, data1);
                            p2 = new SeriesPoint(time.AddMilliseconds(time.Millisecond / 10) - timeSpan_30_s, data2);
                            hori_vib2.Points.Add(p1);
                            vert_vib1.Points.Add(p2);
                            p1 = new SeriesPoint(time.AddMilliseconds(time.Millisecond / 10), data1);
                            p2 = new SeriesPoint(time.AddMilliseconds(time.Millisecond / 10), data2);
                            hori_vib2.Points.Add(p1);
                            vert_vib1.Points.Add(p2);
                            diagram1.AxisX.VisualRange.MaxValue = time;
                            diagram1.AxisX.VisualRange.MinValue = time - timeSpan_30_s;
                            diagram2.AxisX.VisualRange.MaxValue = time;
                            diagram2.AxisX.VisualRange.MinValue = time - timeSpan_30_s;

            p1 = new SeriesPoint(time.AddMilliseconds(time.Millisecond / 10) - timeSpan_30_s, data1);
            p2 = new SeriesPoint(time.AddMilliseconds(time.Millisecond / 10) - timeSpan_30_s, data2);
            hori_vib4.Points.Add(p1);
            vert_vib3.Points.Add(p2);
            p1 = new SeriesPoint(time.AddMilliseconds(time.Millisecond / 10), data1);
            p2 = new SeriesPoint(time.AddMilliseconds(time.Millisecond / 10), data2);
            hori_vib4.Points.Add(p1);
            vert_vib3.Points.Add(p2);
            diagram3.AxisX.VisualRange.MaxValue = time;
            diagram3.AxisX.VisualRange.MinValue = time - timeSpan_30_s;
            diagram4.AxisX.VisualRange.MaxValue = time;
            diagram4.AxisX.VisualRange.MinValue = time - timeSpan_30_s;


        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            if (thread2.ThreadState == ThreadState.Suspended)
                thread2.Resume();
            if (que.Count != 0)
                label4.Text = que.Count.ToString();
        }
        /// <summary>
        /// 进程2 主要进行存数操作  初始化时开启该线程  一直while循环  用timer2和数据处理完毕后唤醒
        /// </summary>
        private void save__thread()
        {
            MySqlConnection conn = new MySqlConnection();
            string SQL_String = "server=localhost;User Id=root;password=qiao291633139;Database=zhendong_db;";
            conn.ConnectionString = SQL_String;
            string sql = "";
            try
            {
                conn.Open();
                sql = "CREATE DATABASE IF NOT EXISTS `zhendong_db`;use zhendong_db;";
                MySqlCommand mycmd1 = new MySqlCommand(sql, conn);
                mycmd1.ExecuteNonQuery();
                sql = "CREATE TABLE IF NOT EXISTS `zd` (`id` int(11) NOT NULL AUTO_INCREMENT,`MAC` tinytext NOT NULL,`horizontal_vibration` double NOT NULL,`vertical_vibration` double NOT NULL,`date` datetime(3) NOT NULL,PRIMARY KEY(`id`) ) ENGINE = MyISAM AUTO_INCREMENT = 1 DEFAULT CHARSET = latin1;";
                mycmd1 = new MySqlCommand(sql, conn);
                mycmd1.ExecuteNonQuery();
                //MessageBox.Show("连接数据库成功");
                while (true)
                {
                    if (que.Count >= 1)
                    {
                        for (int k = 0; k < que.Count; k++)
                        {
                            current_ds = que.Dequeue();
                            save_count++;
                            sql = "INSERT INTO `zd` (`MAC`,`horizontal_vibration`, `vertical_vibration`, `date`) VALUES( '" + current_ds.macaddr.ToString() + "','" + current_ds.hor.ToString("F3") + "','" + current_ds.ver.ToString("F3") + "','" + current_ds.rtime.ToString("yyyy-MM-dd HH:mm:ss.fff") + "'); ";
                            // Console.WriteLine(sql);
                            Console.WriteLine(sql);
                            mycmd1.CommandText = sql;
                            mycmd1.ExecuteNonQuery();
                        }
                    }
                    thread2.Suspend();
                }
            }
            catch (Exception er)
            {
                MessageBox.Show("连接数据库失败");
                MessageBox.Show(er.ToString());
            }
            finally
            {
                conn.Close();
            }
        }
    }
}



