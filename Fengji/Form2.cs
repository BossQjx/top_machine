using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using MySql.Data.MySqlClient;
using MySql.Data.Common;
namespace Fengji
{
    public partial class Form2 : Form
    {
        public static string T1, T2;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“zhendong_dbDataSet1.zd”中。您可以根据需要移动或删除它。
            this.zdTableAdapter.Fill(this.zhendong_dbDataSet1.zd);
            // TODO: 这行代码将数据加载到表“zhendong_dbDataSet.zd”中。您可以根据需要移动或删除它。

            // TODO: 这行代码将数据加载到表“dataSet1.ZHENDONG1”中。您可以根据需要移动或删除它。
            T1 = this.Get_start_timechar();
            T2 = this.Get_end_timechar();
            //this.zdTableAdapter.Fill(this.zhendongDataSet.zd);
        }
        public string Get_start_timechar()
        {
            return textBox1.Text + '/' + textBox2.Text + '/' + textBox3.Text + ' ' + textBox4.Text + ':' + textBox5.Text + ':' + textBox6.Text; 
        }
        public string Get_end_timechar()
        {
            return textBox7.Text + '/' + textBox8.Text + '/' + textBox9.Text + ' ' + textBox10.Text + ':' + textBox11.Text + ':' + textBox12.Text;
        }

        private void zhendongDataSetBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private string Combox2ip ()
        {
            int j = 0;
            string rtnstr="0";
            for (j=0;j<10;j++)
            {
                if (comboBox1.SelectedItem.ToString() == ("节点" + (j + 1)))
                {
                   
                    //rtnstr= MainForm.Ip_string[j];
                    break;
                }
                else
                    rtnstr = "0";
            }
            return rtnstr;
            
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void e618ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.zdTableAdapter.e618(this.zhendong_dbDataSet1.zd);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.zdTableAdapter.FillBy1(this.zhendong_dbDataSet1.zd);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.chart1.Series.Clear();
            // 更新dataset
            T1 = this.Get_start_timechar();
            T2 = this.Get_end_timechar();
            //this.zdTableAdapter.InitCommandCollection();
            //this.zdTableAdapter.Fill(this.zhendongDataSet.zd);
            //更新chart
            
            string sql = "SELECT * FROM zd where date >= '"+ T1+"' and date <= '"+T2+"' and NAC = '"+Combox2ip()+"';";
            this.select_table(sql);
            Console.WriteLine(sql);
            //this.sqlDataSource2.Fill();

            //MessageBox.Show(comboBox1.SelectedItem.ToString().Length.ToString());
            //MessageBox.Show(comboBox1.SelectedItem.ToString());
            //MessageBox.Show(checkBox1.Checked.ToString());


            //if (this.chart1.ChartAreas.Count > 0)//如果已经有绘图
            //{
            //    reflash_chart();
            //}

            

        }

    }
}
