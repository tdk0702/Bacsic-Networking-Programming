using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3.Task6
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnServer_Click(object sender, EventArgs e)
        {
            Server.Server server = new Server.Server();
            server.Show();
        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            Client.Login login = new Client.Login();
            login.Show();
        }
    }
}
