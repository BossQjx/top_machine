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
    public partial class 更改IP : Form
    {
        public 更改IP()
        {
            InitializeComponent();
        }

        private void 确定_Click(object sender, EventArgs e)
        {
            if( this.textBox1.Text == "" )
                MessageBox.Show("请输入更改后的IP！");
            else
                this.DialogResult = DialogResult.OK;
        }

        private void 取消_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

    }
}
