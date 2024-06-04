using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3.UDP
{
    public partial class Menu_UDP : Form
    {
        public Menu_UDP()
        {
            InitializeComponent();
        }

        private void btn_server_Click(object sender, EventArgs e)
        {
            var sever = new UDP_Sever();
            sever.Show();
        }

        private void btn_client_Click(object sender, EventArgs e)
        {
            var client = new UDP_Client();
            client.Show();
        }
    }
}
