using Client.Resource;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.Design
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
            txtPassword.PasswordChar = '\u25CF';
            txtPasswordCf.PasswordChar = '\u25CF';
        }

        private void bttSignup_Click(object sender, EventArgs e)
        {
            string name = txtUsername.Text;
            string pass = txtPassword.Text;
            string pswconfirm = txtPasswordCf.Text;

            if (pass == pswconfirm)
            {
                client client = new client(name, pass);

                Clients clients = new Clients();
                Clients toser = clients.deserialize();
                toser._clients.Add(client);

                toser.serialize(toser);
                this.Dispose();
            }
        }
    }
}
