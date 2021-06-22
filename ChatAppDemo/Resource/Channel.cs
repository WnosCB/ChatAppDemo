using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Resource
{
    [Serializable]
    public class Channel
    {
        public string _name;
        public bool _locked;

        public Channel(string name)
        {
            this._name = name;
        }
    }
}
