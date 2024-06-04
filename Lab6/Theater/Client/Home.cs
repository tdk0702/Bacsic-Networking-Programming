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
using System.Runtime.InteropServices;
using System.Xml;
using static System.Net.Mime.MediaTypeNames;

namespace Theater.Client
{
    public partial class Home : Form
    {
        public static List<Class.Movie> MovieList = new List<Class.Movie>();
        public static IPAddress IP = IPAddress.Loopback;
        public static int PORT = 8080;
        public static TcpClient Client;
        private Seat SeatForm;
        private Class.User ClientUser;
        private int CurrentThID;
        private string clientname = string.Empty;
        public Home()
        {
            InitializeComponent();
        }
        public Home(Class.User user)
        {
            ClientUser = user;
            InitializeComponent();
        }
        public void ServerConnect()
        {
            pgbMovie.Value = 0;
            pgbMovie.Maximum = 500;
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
                new Thread(() =>
                {
                    UdpClient udpClient = new UdpClient(9000);
                    while (true)
                    {
                        IPEndPoint ip = new IPEndPoint(IPAddress.Any, 0);
                        Byte[] data = udpClient.Receive(ref ip);
                        string text = Encoding.UTF8.GetString(data);
                        showBox(text);
                    }
                    udpClient.Close();
                }).Start();
                //Thread.CurrentThread.Abort();
            }).Start();
            new Thread(() => {
                while (clientname == string.Empty) {
                    if (pgbMovie.Value >= pgbMovie.Maximum) pgbMovie.Value = 0;
                    pgbMovie.Value++;
                    Console.WriteLine("Connecting..."); }
            }).Start();
        }

        private void showBox(string text)
        {
            if (text.Contains("[UNLOCK]"))
            {
                MessageBox.Show("Quầy đã mở !", "Thông báo", MessageBoxButtons.OK);
                this.Enabled = true;
                return;
            }
            if (text.Contains("[LOCK]"))
            {
                MessageBox.Show("Quầy đã đóng !", "Thông báo", MessageBoxButtons.OK);
                this.Enabled = false;
                if (SeatForm != null) SeatForm.Close();
                return;
            }
            if (text.Contains("./ul"))
            {
                MessageBox.Show("Quầy " + text.Replace("./ul ", "") + " đã mở");
            }
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
            sendPacket(clname, ns, query);
            string data = receivedPacket(clname, ns);
            //if (data.Contains("LOCK")) { }
            if (data.Contains("[ACK]")) { Console.WriteLine("client <" + clname + "> received ack message from Server"); }
            return data;
        }
        public static string Connectpath =
            @"Data Source=(LocalDB)\MSSQLLocalDB;
            AttachDbFilename=D:\Projects\CS\Lab3\Lab3\obj\Debug\db\Data.mdf;
            Integrated Security=True;
            Connect Timeout=30";
        private void readData()
        {
            string query = "SELECT Id,Mname,Img,Price FROM INFO;";
            string[] rows = GetData(clientname, query).Split(';');
            MovieList = new List<Class.Movie>();
            pgbMovie.Maximum = rows.Length;
            pgbMovie.Value = 0;
            Class.Movie movie;
            string name, id, img;
            long price = 0;
            List<int> arr;
            for (int i = 0; i < rows.Length; i++)
            {
                string[] data = rows[i].Split(' ');
                id = data[0];
                name = data[1].Replace('_', ' ');
                //origin = data[2].Replace('_', ' ');
                img = data[2];
                price = long.Parse(data[3]);
                string queryArr = "SELECT Idtheater FROM THEATERS WHERE Id=" + id + ";";
                string[] irow = GetData(clientname, queryArr).Split(';');
                arr = new List<int>();
                foreach (string dt in irow)
                {
                    arr.Add(int.Parse(dt));
                }
                movie = new Class.Movie(id, name, "", img, "", price, arr);
                MovieList.Add(movie);
                pgbMovie.Value++;
            }
        }


        private void clearMovie()
        {
            gbxMovie1.Text = string.Empty;
            lbMovie1.Text = string.Empty;
            pbxMovie1.Image = null;
            gbxMovie2.Text = string.Empty;
            lbMovie2.Text = string.Empty;
            pbxMovie2.Image = null;
            gbxMovie3.Text = string.Empty;
            lbMovie3.Text = string.Empty;
            pbxMovie3.Image = null;
            gbxMovie4.Text = string.Empty;
            lbMovie4.Text = string.Empty;
            pbxMovie4.Image = null;
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
            loadData();
        }
        private void loadData()
        {
            new Thread(() =>
            {
                while (true) { if (clientname != string.Empty) break; }
                readData();
                lbTitle.Tag = 0;
                if (int.Parse(lbTitle.Tag.ToString()) >= (MovieList.Count / 4) - 1) btnNext.Enabled = false;
                lbPage.Text = "Trang 1/" + (MovieList.Count / 4 + 1).ToString();
                showMovie(int.Parse(lbTitle.Tag.ToString()));
            }).Start();
        }
        private System.Drawing.Image GetImage(string img)
        {
            var request = WebRequest.Create(img);
            using (var response = request.GetResponse())
            using (var stream = response.GetResponseStream())
            {
                return Bitmap.FromStream(stream);
            }
        }
        private void showMovie(int pos)
        {
            clearMovie();
            lbPage.Text = "Trang " + (pos + 1).ToString() + "/" + (MovieList.Count / 4 + 1).ToString();
            gbxMovie1.Text = MovieList[pos * 4].name;
            lbMovie1.Text = MovieList[pos * 4].setInfo();
            pbxMovie1.Image = GetImage(MovieList[pos * 4].img);
            btnGo1.Visible = true;
            if (pos * 4 + 1 >= MovieList.Count) return;
            gbxMovie2.Text = MovieList[pos * 4 + 1].name;
            lbMovie2.Text = MovieList[pos * 4 + 1].setInfo();
            pbxMovie2.Image = GetImage(MovieList[pos * 4 + 1].img);
            btnGo2.Visible = true;
            if (pos * 4 + 2 >= MovieList.Count) return;
            gbxMovie3.Text = MovieList[pos * 4 + 2].name;
            lbMovie3.Text = MovieList[pos * 4 + 2].setInfo();
            pbxMovie3.Image = GetImage(MovieList[pos * 4 + 2].img);
            btnGo3.Visible = true;
            if (pos * 4 + 3 >= MovieList.Count) return;
            gbxMovie4.Text = MovieList[pos * 4 + 3].name;
            lbMovie4.Text = MovieList[pos * 4 + 3].setInfo();
            pbxMovie4.Image = GetImage(MovieList[pos * 4 + 3].img);
            btnGo4.Visible = true;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            int pos = int.Parse(lbTitle.Tag.ToString());
            pos--;
            lbTitle.Tag = pos;
            if (pos == 0) btnBack.Enabled = false;
            if (pos > 0) btnNext.Enabled = true;
            showMovie(pos);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            int pos = int.Parse(lbTitle.Tag.ToString());
            pos++;
            lbTitle.Tag = pos;
            if (pos < MovieList.Count / 4) btnBack.Enabled = true;
            if (pos == MovieList.Count / 4) btnNext.Enabled = false;
            showMovie(pos);
        }

        private void btnGo1_Click(object sender, EventArgs e)
        {
            openSeatForm(int.Parse(lbTitle.Tag.ToString()) * 4);
        }

        private void btnGo2_Click(object sender, EventArgs e)
        {
            openSeatForm(int.Parse(lbTitle.Tag.ToString()) * 4 + 1);
        }

        private void btnGo3_Click(object sender, EventArgs e)
        {
            openSeatForm(int.Parse(lbTitle.Tag.ToString()) * 4 + 2);
        }

        private void btnGo4_Click(object sender, EventArgs e)
        {
            openSeatForm(int.Parse(lbTitle.Tag.ToString()) * 4 + 3);
        }
        private void openSeatForm(int pos)
        {
            Seat.MovieChosen = MovieList[pos];
            SeatForm = new Seat(ClientUser, clientname);
            SeatForm.ShowDialog();
            //new Thread(() => { Application.Run(new Seat()); }).Start();

        }
        
        private void Home_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Shift && e.Control && e.KeyCode == Keys.P) {
                EditHost eh = new EditHost();
                eh.ShowDialog();
                IntPtr ptrThread = OpenThread(1, false, (uint)CurrentThID);
                TerminateThread(ptrThread, 1);
            }
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

        [DllImport("kernel32.dll", SetLastError = true)]
        static extern int SuspendThread(IntPtr hThread);

        [DllImport("kernel32.dll")]
        static extern IntPtr OpenThread(uint dwDesiredAccess, bool bInheritHandle,
           uint dwThreadId);

        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool CloseHandle(IntPtr hObject);

        [DllImport("kernel32.dll")]
        static extern bool TerminateThread(IntPtr hThread, uint dwExitCode);

        
    }
}
