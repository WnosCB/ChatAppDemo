using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Client.Resource;

namespace Client
{
    public partial class MainScreen : Form
    {
        NetworkStream ns;
        TcpClient client;
        Thread thread;
        client current;

        public MainScreen()
        {
            InitializeComponent();
        }

        public MainScreen(client current)
        {
            InitializeComponent();
            DisplayChatBox.Enabled = true;
            DisplayChatBox.ForeColor = Color.Black;

            
        }

    }
}
