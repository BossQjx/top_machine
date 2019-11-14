using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SuperSocket.Facility.Protocol;
using SuperSocket.SocketBase.Protocol;
using System.Windows.Forms;
using SuperSocket.Common;

namespace Fengji
{
    class MyReceiveFilter : FixedHeaderReceiveFilter<BinaryRequestInfo>
    {
        public MyReceiveFilter()
            : base(17)
        {

        }

        protected override int GetBodyLengthFromHeader(byte[] header, int offset, int length)
        {
            //ushort len = 0;
            //len |= (ushort)((header[offset + 4] << 8) & 0xff00);
            //len |= header[offset + 5];
            return 1400;
        }

        protected override BinaryRequestInfo ResolveRequestInfo(ArraySegment<byte> header, byte[] bodyBuffer, int offset, int length)
        {
          
            return new BinaryRequestInfo(Encoding.Unicode.GetString(header.Array, header.Offset, 17), BinaryUtil.CloneRange(bodyBuffer, offset, length));
        }
    }
}
