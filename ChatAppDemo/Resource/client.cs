using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;
using System.Drawing;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using Client.Design;

namespace Client.Resource
{
    [Serializable]
    public class client
    {
        public string _name;
        public string _password;
        public Channel _currentchannel;
        public Channels _clientschannels;
        public Private _currentprivate;
        public Privates _clientprivates;
        IPAddress ip;

        public client(string name, string psw)
        {
            _clientschannels = new Channels();
            _clientprivates = new Privates();
            _currentprivate = new Private("Start");
            this._name = name;
            this._password = psw;
            foreach (Channel c in _clientschannels._channels)
            {
                Console.WriteLine(c._name);
                //if (c._name == "sảnh chính") this._currentchannel = c;
            }

            this.ip = IPAddress.Parse("127.0.0.1");
        }

        public IPAddress GetIP()
        {
            return this.ip;
        }
    }
}
