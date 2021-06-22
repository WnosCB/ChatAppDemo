using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Design
{
    [Serializable]
    public class Private
    {
        public string _name;
        public Private(string name)
        {
            this._name = name;
        }
    }
}
