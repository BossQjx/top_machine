using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fengji
{
    class NodeData
    {
        private string _id;
        private string _ip;
        private string _port;
        private List<double>[] _data = new List<double>[42];
        public NodeData()
        {
            for (int i = 0; i < 42; i++)
            {
                _data[i] = new List<double>();
            }
        }

        public string IP
        {
            get
            {
                return _ip;
            }

            set
            {
                _ip = value;
            }
        }

        public string PORT
        {
            get
            {
                return _port;
            }

            set
            {
                _port = value;
            }
        }


        public string ID
        {
            get
            {
                return _id;
            }

            set
            {
                _id = value;
            }
        }

        public List<double>[] Data
        {
            get
            {
                return _data;
            }

            set
            {
                _data = value;
            }
        }

    }
}
