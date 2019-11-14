using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fengji
{
    class SysPublic
    {
        private static SysPublic _instance = new SysPublic();
        public NodeMap AllNode = new NodeMap();

        private SysPublic()
        {

        }

        public static SysPublic getInstance()
        {
            return _instance;
        }

    }
}
