using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fengji
{
    public partial class first : Form
    {
        public first()
        {
            InitializeComponent();
        }

        private class UserInfo
        {
            public string UserCode { get; set; }
            public string Password { get; set; }
        }

        private List<UserInfo> GetUserList()//获取所有的合法用户信息
        {
            List<UserInfo> userList = new List<UserInfo>
                {
                     new UserInfo{ UserCode = "hit", Password = "12345"},
                     new UserInfo{ UserCode = "root",Password = "qw1234"},
                     new UserInfo{UserCode = "passwd",Password = "passwd"}
                 };//初始化包含3个用户信息的集合对象
            return userList;//返回集合对象   
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void esc_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;

        }


        private void login_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(usename.Text.Trim()))//用户编码不许为空
            {
                MessageBox.Show("用户编码不许为空！", "信息提示");
                return;
            }

            List<UserInfo> userList = GetUserList();//获取包含所有登录用户信息的集合

            var sequence = from user in userList

                           where (user.UserCode == usename.Text.Trim() && user.Password == password.Text)

                           select user; //使用查询表达式筛选符合输入信息的登录用户

            if (sequence.Count() == 0)//若查询结果中无数据
            {

                MessageBox.Show("用户编码或用户密码错误！");

            }

            else//若查询结果中有数据
            {

                //MessageBox.Show("登录成功！", "信息提示");
                this.DialogResult = DialogResult.OK;
            }

        }
    }
}
