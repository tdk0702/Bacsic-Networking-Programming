using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using System.Net.Sockets;
using System.Net;

namespace Lab3.Theater
{
    public partial class Home : Form
    {
        public static List<Class.Movie> MovieList = new List<Class.Movie>();
        public static IPAddress IP = IPAddress.Loopback;
        public static int PORT = 8080;
        public static TcpClient Client;
        private string clientname = string.Empty;
        public Home()
        {
            InitializeComponent();
        }
        public void ServerConnect()
        {
            EditHost eh = new EditHost();
            eh.ShowDialog();
            Console.WriteLine(IP.ToString());
            Client = new TcpClient();
            new Thread(() =>
            {
                while (!Client.Connected)
                {
                    try
                    {
                        //Client.Connect(IPAddress.Parse("127.0.0.1"), 8080);
                        Client.Connect(IP, PORT);
                    }
                    catch (SocketException) { }
                }
                Console.WriteLine("Connected to Server");
                while (clientname == string.Empty)
                {
                    NetworkStream ns = Client.GetStream();
                    string text = receivedPacket(clientname, ns);
                    clientname = text;
                    sendPacket(clientname, ns, "./accept");
                }
                Thread.CurrentThread.Abort();
            }).Start();

            while (clientname == string.Empty) { Console.WriteLine("Connecting..."); }
        }
        public static void sendPacket(string clname, NetworkStream ns, string text)
        {
            byte[] sentdata = Encoding.UTF8.GetBytes(text + "<>");
            Console.WriteLine("Client <" + clname + "> sent: [" + text + "]");
            ns.Write(sentdata, 0, sentdata.Length);
            ns.Flush();
        }
        public static string receivedPacket(string clname, NetworkStream ns)
        {
            byte[] receivedata = new byte[4096];
            try { ns.Read(receivedata, 0, receivedata.Length); }
            catch (IOException) { }
            ns.Flush();
            string text = Encoding.UTF8.GetString(receivedata);
            try { text = text.Substring(0, text.IndexOf("<>")); }
            catch (ArgumentOutOfRangeException) { text = string.Empty; }
            if (text != string.Empty) Console.WriteLine("client <" + clname + "> received: [" + text + "]");
            return text;
        }

        public static string GetData(string clname, string query)
        {
            NetworkStream ns = Client.GetStream();
            sendPacket(clname,ns, query);
            string data = receivedPacket(clname,ns);
            if (data.Contains("[ACK]")) { Console.WriteLine("client <" + clname + "> received ack message from Server");}
            return data;
        }
        public static string Connectpath =
            @"Data Source=(LocalDB)\MSSQLLocalDB;
            AttachDbFilename=D:\Projects\CS\Lab3\Lab3\obj\Debug\db\Data.mdf;
            Integrated Security=True;
            Connect Timeout=30";
        private void readData()
        {
            string query = "SELECT Id,Mname,Origin,Price FROM INFO;";
            string[] rows = GetData(clientname, query).Split(';');
            MovieList = new List<Class.Movie>();
            pgbMovie.Maximum = rows.Length;
            pgbMovie.Value = 0;
            Class.Movie movie;
            string name, origin, id;
            long price = 0;
            List<int> arr;
            for (int i = 0; i < rows.Length; i++)
            {
                string[] data = rows[i].Split(' ');
                id = data[0];
                name = data[1].Replace('_',' ');
                origin = data[2].Replace('_', ' ');
                price = long.Parse(data[3]);
                string queryArr = "SELECT Idtheater FROM THEATERS WHERE Id=" + id + ";";
                string[] irow = GetData(clientname, queryArr).Split(';');
                arr = new List<int>();
                foreach(string dt in irow) 
                {
                    arr.Add(int.Parse(dt));
                }
                movie = new Class.Movie(id,name, origin, price, arr);
                MovieList.Add(movie);
                pgbMovie.Value++;
            }
        }
        

        private void clearMovie()
        {
            gbxMovie1.Text = string.Empty;
            lbMovie1.Text = string.Empty;
            gbxMovie2.Text = string.Empty;
            lbMovie2.Text = string.Empty;
            gbxMovie3.Text = string.Empty;
            lbMovie3.Text = string.Empty;
            gbxMovie4.Text = string.Empty;
            lbMovie4.Text = string.Empty;
            btnGo1.Visible = false;
            btnGo2.Visible = false;
            btnGo3.Visible = false;
            btnGo4.Visible = false;
        }

        private void Home_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            ServerConnect();
            clearMovie();
            readData();
            if (int.Parse(lbTitle.Tag.ToString()) >= (MovieList.Count / 4) - 1) btnNext.Enabled = false;
            showMovie(int.Parse(lbTitle.Tag.ToString()));
        }
        private void showMovie(int pos)
        {
            gbxMovie1.Text = MovieList[pos * 4].name;
            lbMovie1.Text = MovieList[pos * 4].setInfo(); 
            btnGo1.Visible = true;
            if (pos * 4 + 1 >= MovieList.Count) return;
            gbxMovie2.Text = MovieList[pos * 4 + 1].name;
            lbMovie2.Text = MovieList[pos * 4 + 1].setInfo();
            btnGo2.Visible = true;
            if (pos * 4 + 2 >= MovieList.Count) return;
            gbxMovie3.Text = MovieList[pos * 4 + 2].name;
            lbMovie3.Text = MovieList[pos * 4 + 2].setInfo();
            btnGo3.Visible = true;
            if (pos * 4 + 3 >= MovieList.Count) return;
            gbxMovie4.Text = MovieList[pos * 4 + 3].name;
            lbMovie4.Text = MovieList[pos * 4 + 3].setInfo();
            btnGo4.Visible = true;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            int pos = int.Parse(lbTitle.Tag.ToString());
            lbTitle.Tag = pos - 1;
            if (pos <= 0) btnBack.Enabled = false;
            if (pos < (MovieList.Count / 4)-1) btnNext.Enabled = true;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            int pos = int.Parse(lbTitle.Tag.ToString());
            lbTitle.Tag = pos + 1;
            if (pos > 0) btnBack.Enabled = true;

            if (pos >= (MovieList.Count / 4)-1) btnNext.Enabled = false;
        }

        private void btnGo1_Click(object sender, EventArgs e)
        {
            openSeatForm(int.Parse(lbTitle.Tag.ToString())*4);
        }

        private void btnGo2_Click(object sender, EventArgs e)
        {
            openSeatForm(int.Parse(lbTitle.Tag.ToString())*4 + 1);
        }

        private void btnGo3_Click(object sender, EventArgs e)
        {
            openSeatForm(int.Parse(lbTitle.Tag.ToString())*4 + 2);
        }

        private void btnGo4_Click(object sender, EventArgs e)
        {
            openSeatForm(int.Parse(lbTitle.Tag.ToString())*4 + 3);
        }
        private void openSeatForm(int pos)
        {
            Seat.MovieChosen = MovieList[pos];
            Seat ct = new Seat(clientname);
            ct.ShowDialog();
            //new Thread(() => { Application.Run(new Seat()); }).Start();

        }
        /*private void readData()
        {
            string query = "SELECT Id, Mname, Origin, Price FROM INFO;";
            DataTable dt = getData(query);
            MovieList = new List<Class.Movie>();
            pgbMovie.Maximum = dt.Rows.Count;
            pgbMovie.Value = 0;
            Class.Movie movie;
            string name, origin, id;
            long price = 0;
            List<int> arr;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                id = dt.Rows[i]["Id"].ToString();
                name = dt.Rows[i]["Mname"].ToString();
                origin = dt.Rows[i]["Origin"].ToString();
                price = long.Parse(dt.Rows[i]["Price"].ToString());
                string queryArr = "SELECT Idtheater FROM THEATERS WHERE Id=" + id;
                DataTable dta = getData(queryArr);
                arr = new List<int>();
                for (int j = 0; j < dta.Rows.Count; j++)
                {
                    arr.Add(int.Parse(dta.Rows[j]["Idtheater"].ToString()));
                }
                movie = new Class.Movie(id, name, origin, price, arr);
                MovieList.Add(movie);
                pgbMovie.Value++;
            }
        }*/
    }
}
