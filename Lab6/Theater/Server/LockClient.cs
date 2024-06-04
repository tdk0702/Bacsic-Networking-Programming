using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Theater.Server
{
    public partial class LockClient : Form
    {
        public class Client
        {
            public Socket socket;
            public bool islock;
            public string id;
            public Client(Socket soc, string id, bool islock)
            {
                this.socket = soc;
                this.islock = islock;
                this.id = id;
            }
            public Client()
            {
                islock = false;
                id = "";
            }
            public string getString()
            {
                string hostname = ((IPEndPoint)socket.RemoteEndPoint).Address.ToString();
                if (islock) return string.Format("client{0} ({1}) - Lock",id.ToString(),hostname);
                return string.Format("client{0} ({1}) - Unlock", id.ToString(), hostname);
            }
        }

        public static List<Client> Clients = new List<Client>();
        public LockClient()
        {
            InitializeComponent();
        }
        private void LockClient_Load(object sender, EventArgs e)
        {
            loadClient();
        }
        private void loadClient()
        {
            lbxClient.Items.Clear();
            foreach (Client c in Clients)
                lbxClient.Items.Add(c.getString());
        }
        private void btnLock_Click(object sender, EventArgs e)
        {
            if (lbxClient.SelectedItem == null) return;
            foreach (Client c in Clients)
            {
                if (lbxClient.SelectedItem.ToString().Split('(')[0].Contains(c.id))
                {
                    c.islock = !c.islock;
                    loadClient();
                    string ilock = c.islock ? "1" : "0";
                    string query = string.Format("UPDATE CLIENTS SET IsLock = {0} WHERE Id = {1};",ilock, c.id);
                    Admin.queryData(query);
                    if (c.islock) sendUDP(c.socket, "[LOCK]");
                    else
                    {
                        sendUDP(c.socket, "[UNLOCK]");
                        foreach(Client sc in Clients)
                            if (c.id != sc.id) sendUDP(sc.socket, "./ul " + c.id);
                    }

                    break;
                }                
            }
        }
        private void sendUDP(Socket socket, string message)
        {
            UdpClient udpClient = new UdpClient();
            Byte[] data = Encoding.UTF8.GetBytes(message);
            udpClient.Send(data, data.Length, ((IPEndPoint)socket.RemoteEndPoint).Address.ToString(), 9000);
        }
    }
}
