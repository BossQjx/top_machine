using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SuperSocket.SocketBase;
using SuperSocket.SocketBase.Protocol;

namespace Fengji
{
    class MyAppSession : AppSession<MyAppSession, BinaryRequestInfo>
    {

        public string IP
        { 
            get;
            internal set;
        }
        protected override void OnSessionStarted()
        {
            base.OnSessionStarted();
            
        }

        protected override void OnSessionClosed(CloseReason reason)
        {
            base.OnSessionClosed(reason);
            
        }
    }
}
