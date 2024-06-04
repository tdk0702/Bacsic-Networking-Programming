using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Theater.Client
{
    public partial class EditHost : Form
    {
        public EditHost()
        {
            InitializeComponent();
        }

        private void EditHost_Load(object sender, EventArgs e)
        {
            tbxIP.Text = Home.IP.ToString();
            tbxPort.Text = Home.PORT.ToString();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            IPAddress ip;
            int port;
            if (!IPAddress.TryParse(tbxIP.Text.Trim(), out ip))
            {
                MessageBox.Show("Định dạng địa chỉ IP sai");
                return;
            };
            if (!int.TryParse(tbxPort.Text.Trim(), out port))
            {
                MessageBox.Show("Định dạng Port sai");
                return;
            };
            Console.WriteLine("Edited: " + tbxIP.Text.Trim() + ":" + tbxPort.Text.Trim());
            Home.IP = ip;
            Home.PORT = port;
            this.Close();
        }

        private void EditHost_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) {
                btnAccept_Click(this, new EventArgs());
            }
        }
    }
}
