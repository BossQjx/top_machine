using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SuperSocket.SocketBase;
using SuperSocket.SocketBase.Protocol;

namespace Fengji
{
    class MyAppServer : AppServer<MyAppSession, BinaryRequestInfo>
    {
        public MyAppServer()
            : base(new DefaultReceiveFilterFactory<MyReceiveFilter, BinaryRequestInfo>())
        {
        }
       

    }
}
