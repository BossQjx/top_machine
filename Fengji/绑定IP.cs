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
    public partial class 绑定IP : Form
    {
     
        public 绑定IP()
        {
            InitializeComponent();
        }

        private void 确定_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                if (("节点" + (i + 1)) == this.comboBox1.Text.ToString())
                {
                    MainForm.Node_MAC[i] = textBox1.Text.ToString();
                    MessageBox.Show("绑定成功");
                   
                   // return;
                }
            }
            for (int i = 0; i < 10; i++)
            {
                    Console.WriteLine(i + ":"+MainForm.Node_MAC[i]);
            }
        }

        private void 取消_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }
    }
}
