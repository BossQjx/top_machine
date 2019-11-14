using SuperSocket.SocketBase.Protocol;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Fengji
{
    class NodeMap
    {
        private Dictionary<string, NodeData> _allNode = new Dictionary<string, NodeData>();

        public Dictionary<string, NodeData> AllNode
        {
            get
            {
                return _allNode;
            }

            set
            {
                _allNode = value;
            }
        }

        public NodeData insertNode(MyAppSession session, BinaryRequestInfo package)
        {
            string id = package.Key;
            string ip = session.SocketSession.RemoteEndPoint.Address.ToString();
            string port = session.SocketSession.RemoteEndPoint.Port.ToString();
            //Console.WriteLine(id);
            if (!_allNode.ContainsKey(ip))
            {
                NodeData nd = new NodeData();
                nd.ID = id;
                nd.IP = ip;
                nd.PORT = port;
                _allNode.Add(ip, nd);
            }
            SensorData sd = new SensorData();
            sd.parsePackage(package, _allNode[ip]);
            for (int i = 0; i < 42; i++)
            {
               //if(i < 40)
               //{
               //     //_allNode[ip].Data[i].Add(sd.Data[i]);
               //     if(_allNode[ip].Data[i].Count == 0)
               //         _allNode[ip].Data[i].Add(sd.Data[i]);
               //     else
               //         _allNode[ip].Data[i][0] = sd.Data[i];
               // }


                //_allNode[ip].Data[i].Add(sd.Data[i]);
                if (_allNode[ip].Data[i].Count == 0)
                    _allNode[ip].Data[i].Add(sd.Data[i]);
                else
                {
                    if(i<40)
                    {
                        _allNode[ip].Data[i][0] = sd.Data[i];
                    }
                    else
                    {
                        _allNode[ip].Data[i][0] = sd.Data[(i-40)*350+40];
                    }
                    

                }
                    

                // else
                //{
                //    for (int j = 0; j < 250; j++)
                //    {
                //        _allNode[ip].Data[i].Add(sd.Data[((i-40)*250+40+j)]);
                //    }

                //}
            }
            return _allNode[ip];

        }

        public NodeData getNode(string ip)
        {
            if (_allNode.ContainsKey(ip))
            {
                return _allNode[ip];
            }
            else
            {
                return null;
            }
        }
    }
}
