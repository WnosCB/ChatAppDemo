using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Resource
{
    [Serializable]
    public class Channels
    {
        public List<Channel> _channels;
        public Channels()
        {
            _channels = new List<Channel>();
            //tạo kênh chung khi đăng nhập vào
            _channels.Add(new Channel("Sảnh chung"));
        }
    }
}
