using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Design
{
    [Serializable]
    public class Privates
    {
        public List<Private> _privateList;

        public Privates()
        {
            this._privateList = new List<Private>();
        }
    }
}
