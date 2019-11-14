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
     
    public partial class Chart1 : Form
    {
       // private Form2 form2 = new Form2();
        public Chart1(MainForm f2)
        {
            
            InitializeComponent();
            //this.form2 = f2;
            List<int> xData = new List<int>() { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19 };
            List<string> yData = new List<string>() { "9.9792", "9.9800", "9.9800", "9.9800", "9.9808", "9.9792", "9.9892", "9.9825", "9.9817", "9.9817", "9.9867", "9.9808", "9.9875", "9.9800", "9.9867", "9.9800", "9.9875", "9.9800", "9.9867", "9.9792" };

 
            通道隔离.Series[0].IsValueShownAsLabel = true;
            通道隔离.Series[0].Points.DataBindXY(xData, yData);
            
        }

        private void 进口温度_Click(object sender, EventArgs e)
        {

        }


    }
}
