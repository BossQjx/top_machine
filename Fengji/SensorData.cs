using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SuperSocket.SocketBase.Protocol;
using System.Windows.Forms;

namespace Fengji
{
    class SensorData
    {
        private double[] data = new double[540];

        public double[] Data
        {
            get { return data; }
            set { data = value; }
        }

        internal void parsePackage(BinaryRequestInfo package, NodeData nodeData)
        {
           
            ushort temp = 0;
            //for (int i = 0; i < 21; i++)
            for (int i = 0; i < 519; i++)
            {
                temp = (ushort)(package.Body[(2 * i) + 1]);
                temp |= (ushort)((package.Body[(2 * i) + 0] << 8) & 0xff00);
                if(i < 8)
                    data[i] = temp * 1.0 / 50000 * 5 / 120.0 / 2.0 * 1000;
                else if(i < 16)
                    data[i] = temp * 1.0 / 50000 * 5 / 120.0 / 2.0 * 1000;
                else if(i < 19)
                {
                    ushort index = 0x01;
                    for (int m = 0; m < 8; m++)
                    {
                        data[(i - 16) * 8 + 16 + m] = ((temp & index) == 0 ? 0 : 1);
                        index <<= 1;
                    }
                }
                else if(i >= 19)
                {
                    //data[i + 21] = temp * 1.0 / 4096 * 3.3 / 120.0 * 1000;
                    if(temp != 0x00)
                    data[i + 21] = ((temp * 1.0 / 4096.0 * 3.3 * 5.0 / 3.0)) / 0.025 - 92f;
                }

            }
        }
    }
}
