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

namespace Client.Resource
{
    [Serializable]
    public class Clients
    {
        public List<client> _clients;

        public Clients()
        {

        }

        public void serialize(Clients cLients)
        {
            IFormatter formatter = new BinaryFormatter();
            //create new file "Clients.bin"
            FileStream stream = new FileStream("Clients.bin", FileMode.Create, FileAccess.Write);
            formatter.Serialize(stream, cLients);
            stream.Close();
        }

        public Clients deserialize()
        {
            IFormatter formatter = new BinaryFormatter();
            //call the .bin file 
            FileStream stream = new FileStream("Clients.bin", FileMode.Open, FileAccess.Read);
            Clients cl = new Clients();
            cl = (Clients)formatter.Deserialize(stream);
            stream.Close();
            return cl;
        }

        public client checkclients(string username, string pass, Label print)
        {
            client current = null;
            int find = 0;
            foreach(client clients in _clients)
            {
                if (clients._name == username)
                {
                    if (clients._password == pass)
                    {
                        find = 1;
                        current = clients;
                        break;
                    }
                    else
                    {
                        find = 2;
                    }
                }
                else find = 3;
            }    
            if (find == 1)
            {
                print.ForeColor = Color.White;
                print.Text = "Connect successful!";
            }
            else if (find == 2)
            {
                print.ForeColor = Color.Red;
                print.Text = "Your password is wrong!";
            }
            else if (find == 3)
            {
                print.ForeColor = Color.Red;
                print.Text = "Can find your username, sign up for one!";
            }
            return current;
        }
    }
}
