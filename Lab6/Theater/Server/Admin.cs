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
using System.Net;
using System.Net.Sockets;
using System.Data.SqlClient;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Theater.Server
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }
        class Commands
        {
            string cmd;
            public Commands() { cmd = string.Empty; }
            public Commands(string cmd) { this.cmd = cmd; }
            public string Insert()
            {
                SqlConnection SQLConnect = new SqlConnection(Connectpath);
                SQLConnect.Open();
                SqlCommand sqlcmd = new SqlCommand(cmd, SQLConnect);
                sqlcmd.CommandType = CommandType.Text;
                try { sqlcmd.ExecuteNonQuery(); }
                catch (SqlException ex) { return ex.ToString(); }
                SQLConnect.Close();
                return "[ACK]";
            }
            public string Select()
            {
                DataTable dt = getData(cmd);
                if (dt.Rows.Count == 0) return "No data";
                string[] items = cmd.Substring(cmd.IndexOf(' ') + 1, cmd.IndexOf(" FROM") - cmd.IndexOf(' ') - 1).Split(',');
                string temp = string.Empty;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    foreach (string item in items)
                    {
                        if (item.Contains(".")) temp += dt.Rows[i][item.Split('.')[1]].ToString() + " ";
                        else temp += dt.Rows[i][item].ToString() + " ";
                    }
                    temp = temp.Trim() + ";";
                }
                return temp.Trim().Substring(0, temp.Length - 1);
            }
        }
        /*public static string Connectpath =
            @"Data Source=(LocalDB)\MSSQLLocalDB;
            AttachDbFilename=D:\Projects\CS\Lab3\Lab3\obj\Debug\db\Data.mdf;
            Integrated Security=True;
            Connect Timeout=30";*/

        public static string Connectpath =
            @"Data Source=tcp:koih-app.database.windows.net,1433;
            Initial Catalog=TheaterApp;User Id=dokyuhi@koih-app;
            Password=Duykhoi@270204";

        
        public static List<Class.Movie> MovieList = new List<Class.Movie>();
        public static List<Class.Theater> Theaters = new List<Class.Theater>();
        private static IPAddress IP;
        private static int PORT = 8080;

        private bool getHost()
        {
            string hostname = tbxHost.Text.Trim();
            if (hostname.IndexOf(':') == -1) { MessageBox.Show("Định dạng sai Hostname (thiếu ':')"); return false; }
            string ip = hostname.Substring(0, hostname.IndexOf(':'));
            if (!IPAddress.TryParse(ip, out IP)) { MessageBox.Show("Định dạng sai IP"); return false; }
            if (!int.TryParse(hostname.Substring(hostname.IndexOf(':') + 1), out PORT)) { MessageBox.Show("Định dạng sai Port"); return false; }
            return true;
        }

        public static DataTable getData(string query)
        {
            SqlConnection SQLConnect = new SqlConnection(Connectpath);
            while (true)
            {
                try
                {
                    SQLConnect.Open();
                    if (SQLConnect.State == ConnectionState.Open) break;
                }
                catch (Exception ex) { Console.WriteLine("SQL chưa kết nối"); }
            }
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand(query, SQLConnect);
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            try { da.Fill(dt); }
            catch (SqlException expt) { MessageBox.Show("Query sai định dạng. Err" + expt.ToString()); return dt; }
            SQLConnect.Close();
            return dt;
        }
        public static void queryData(string query)
        {
            SqlConnection SQLConnect = new SqlConnection(Connectpath);
            while (true)
            {
                try
                {
                    SQLConnect.Open();
                    if (SQLConnect.State == ConnectionState.Open) break;
                }
                catch (Exception ex) { Console.WriteLine("SQL chưa kết nối"); }
            }
            SqlCommand cmd = new SqlCommand(query, SQLConnect);
            cmd.CommandType = CommandType.Text;
            try { cmd.ExecuteNonQuery(); }
            catch (SqlException expt) { MessageBox.Show("Query sai định dạng. Err" + expt.ToString()); return; }
            SQLConnect.Close();
        }
        private void Admin_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            tbxHistory.Text = string.Empty;
            lbxTheaRank.Items.Clear();
            lbxMovies.Items.Clear();
            lbxTheaters.Items.Clear();
            cbxType.SelectedIndex = 0;
            connectSQL();
            loadMovie();
            loadTheater();
            autoloadRank();
        }
        private void connectSQL()
        {
            tbxHistory.Text += "Starting connect to Azure SQL Database..." + "\r\n";
            new Thread(() =>
            {
                while (true)
                {
                    try
                    {
                        string query = "SELECT * FROM USERS;";
                        DataTable dt = getData(query);
                        if (dt.Rows.Count > 0)
                        {
                            tbxHistory.Text += "Connected to Azure SQL Database!" + "\r\n";
                            Console.WriteLine("Kết nối SQL thành công");
                            break;
                        }
                    }
                    catch (Exception ex) { Console.WriteLine("SQL Lỗi kết nối"); }
                }
            }).Start();
        }
        private void getMovie(DataTable dt)
        {
            MovieList = new List<Class.Movie>();
            Class.Movie movie;
            string queryArr, name, origin, id, img;
            long price = 0;
            List<int> arr;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                id = dt.Rows[i]["Id"].ToString();
                name = dt.Rows[i]["Mname"].ToString().Replace('_', ' ');
                origin = dt.Rows[i]["Origin"].ToString().Replace('_', ' ');
                //img = dt.Rows[i]["Img"].ToString();
                price = long.Parse(dt.Rows[i]["Price"].ToString());
                queryArr = "SELECT Idtheater FROM THEATERS WHERE Id = " + id + ";";
                DataTable dta = getData(queryArr);
                arr = new List<int>();
                for (int j = 0; j < dta.Rows.Count; j++)
                {
                    arr.Add(int.Parse(dta.Rows[j]["Idtheater"].ToString()));
                }
                movie = new Class.Movie(id, name, origin, "", "", price, arr);
                MovieList.Add(movie);
            }
        }
        public void getTheater(DataTable dt)
        {
            Theaters = new List<Class.Theater>();
            Class.Theater theater;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                theater = new Class.Theater();
                theater.id = dt.Rows[i]["Id"].ToString();
                theater.name = dt.Rows[i]["TName"].ToString().Replace('_', ' ');
                theater.normal = int.Parse(dt.Rows[i]["Normal"].ToString());
                theater.vip = int.Parse(dt.Rows[i]["Vip"].ToString());
                theater.sweet = int.Parse(dt.Rows[i]["Sweet"].ToString());
                theater.col = 8;
                Theaters.Add(theater);
            }
        }
        private void loadMovie()
        {
            new Thread(() =>
            {
                string query = "SELECT Id, Mname, Origin, Price FROM INFO";
                getMovie(getData(query));
                foreach (Class.Movie mv in MovieList)
                {
                    string text = mv.name + " : ";
                    foreach (int id in mv.arrRoom)
                    {
                        query = "Select TName FROM SEAT WHERE Id = " + id.ToString() + ";";
                        DataTable dt = getData(query);
                        text += dt.Rows[0]["Tname"].ToString().Replace('_', ' ') + ", ";
                    }
                    lbxMovies.Items.Add(text.Substring(0, text.Length - 2));
                }
            }).Start();
        }
        private void loadTheater()
        {
            new Thread(() =>
            {
                string query = "Select * from SEAT";
                getTheater(getData(query));
                foreach (Class.Theater tt in Theaters)
                {
                    string text = string.Format("{0} - Thường: {1}, VIP: {2}, SweetBox: {3}", tt.name.Replace('_', ' '), tt.normal, tt.vip, tt.sweet);
                    lbxTheaters.Items.Add(text);
                }
            }).Start();
        }
        private void autoloadRank()
        {
            new Thread(() =>
            {
                while (true)
                {
                    loadRank();
                    Thread.Sleep(10000);
                }
            }).Start();
        }
        private void loadRank()
        {
            string[] dmy = { "yyyy-MM-dd", "yyyy-MM", "yyyy" };
            DateTime date = dtpDate.Value;
            string type = dmy[cbxType.SelectedIndex];
            lbxTheaRank.Items.Clear();
            List<KeyValuePair<string, long>> ranks = new List<KeyValuePair<string, long>>();
            ranks.Clear();
            foreach (Class.Theater tht in Theaters)
            {
                string query = string.Format("SELECT Price FROM TICKER WHERE Idtheater = {0} AND FORMAT(Datet, '{1}') = '{2}'; ", tht.id, type, date.ToString(type));
                DataTable dt = getData(query);
                long sum = 0;
                for (int i = 0; i < dt.Rows.Count; i++) sum += long.Parse(dt.Rows[i]["Price"].ToString());
                KeyValuePair<string, long> pair = new KeyValuePair<string, long>(tht.id, sum);
                ranks.Add(pair);
                //lbxTheaRank.Items.Add(text);
            }
            ranks.Sort((x, y) => x.Value.CompareTo(y.Value));
            foreach (var ttr in ranks) lbxTheaRank.Items.Add("Rạp " + ttr.Key + " : " + ttr.Value + ".000 VNĐ");
            lbxMovRank.Items.Clear();
            ranks.Clear();
            foreach (Class.Movie mov in MovieList)
            {
                string query = string.Format("SELECT Price FROM TICKER WHERE Idmovie = {0} AND FORMAT(Datet, '{1}') = '{2}'; ", mov.id, type, date.ToString(type));
                DataTable dt = getData(query);
                long sum = 0;
                for (int i = 0; i < dt.Rows.Count; i++) sum += long.Parse(dt.Rows[i]["Price"].ToString());
                string text = mov.name + ": " + sum.ToString();
                KeyValuePair<string, long> pair = new KeyValuePair<string, long>(mov.name, sum);
                ranks.Add(pair);
            }
            ranks.Sort((x, y) => x.Value.CompareTo(y.Value));
            foreach (var mvr in ranks) lbxMovRank.Items.Add(mvr.Key + " : " + mvr.Value + ".000 VNĐ");
        }

        private void btnListen_Click(object sender, EventArgs e)
        {
            if (!getHost()) return;
            CheckForIllegalCrossThreadCalls = false;
            tbxHistory.Text += DateTime.Now.ToString() + ">> Server started on " + IP.ToString() + ":" + PORT.ToString() + " \r\n";
            queryData("DELETE FROM CLIENTS;");
            openTCP();
            //new Thread(() => openTCP(ip)).Start();
        }
        private void writeHistory(string text)
        {

            tbxHistory.Text += DateTime.Now.ToString() + ">> " + text + "\r\n";
        }
        private void openTCP()
        {
            TcpListener server = new TcpListener(IP, PORT);
            try { server.Start(); }
            catch (SocketException) { }
            for (int i = 0; i < (int)nudClients.Value; i++)
                new Thread((obj) =>
                {
                    while (true)
                    {
                        using (Socket socket = server.AcceptSocket())
                        {
                            int num = (int)obj;
                            string text = string.Empty;
                            do
                            {
                                sendPacket(socket, "client" + num.ToString());
                                text = receivePacket(socket);
                            } while (!text.Contains("./accept"));
                            //string clientname = text.Substring(0, text.IndexOf("./accept"));
                            Console.WriteLine("Client " + num + " connected.");
                            writeHistory("Connected to client" + num);
                            LockClient.Clients.Add(new LockClient.Client(socket, num.ToString(), false));
                            queryData("INSERT INTO CLIENTS VALUES(" + num.ToString() + ", 0);");
                            bool clientlock = false;
                            while (true)
                            {
                                text = receivePacket(socket);
                                if (text == string.Empty) continue;
                                if (isLock(num) != clientlock) clientlock = !clientlock;
                                writeHistory("From client" + num + " : " + text);
                                string data = string.Empty;
                                if (text.ToUpper().Contains("INSERT") || text.ToUpper().Contains("SELECT"))
                                    data = doCommand(text);
                                else data = "[ACK]";
                                if (clientlock) data = "[LOCK]";
                                writeHistory("Server sent : " + data);
                                sendPacket(socket, data);
                                if (text.Contains("./close")) { MessageBox.Show("Đóng TCP"); break; }
                            }
                            break;
                        }
                    }
                    server.Stop();
                    Thread.CurrentThread.Abort();
                }).Start(i);
            //if (!server.Pending()) Thread.CurrentThread.Abort();
        }
        private void sendPacket(Socket socket, string text)
        {
            Console.WriteLine("Server sent: [" + text + "]");
            byte[] bStream = Encoding.UTF8.GetBytes(text + "<>");
            socket.Send(bStream);
        }
        private string receivePacket(Socket socket)
        {
            byte[] data = new byte[4096];
            try { socket.Receive(data); }
            catch (SocketException) { };
            string text = Encoding.UTF8.GetString(data);
            try
            {
                text = text.Substring(0, text.IndexOf("<>"));
            }
            catch (ArgumentOutOfRangeException) { text = string.Empty; }
            if (text != string.Empty) Console.WriteLine("Server received: [" + text + "]");
            return text;
        }

        private string doCommand(string cmd)
        {
            //cmd = ./<lệnh> <bảng> <dk1> <dk2> <...>

            string c = cmd.Substring(0, cmd.IndexOf(' '));
            Commands commands = new Commands(cmd);
            if (c.ToLower() == "insert") return commands.Insert();
            return commands.Select();
        }
        private bool isLock(int num)
        {
            string query = "SELECT IsLock FROM CLIENTS WHERE Id = " + num.ToString() + ";";
            DataTable dt = getData(query);
            if (dt.Rows[0]["IsLock"].ToString() == "False") return false;
            return true;
        }
        private void btnAddMovie_Click(object sender, EventArgs e)
        {
            AddMovie am = new AddMovie();
            am.ShowDialog();
            lbxMovies.Items.Clear();
            loadMovie();
        }

        private void Admin_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.Shift && e.KeyCode == Keys.M) btnAddMovie_Click(this, new EventArgs());
        }

        private void cbxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadRank();
        }

        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            loadRank();
        }

        private void tbnAddTheater_Click(object sender, EventArgs e)
        {
            AddTheater at = new AddTheater();
            at.ShowDialog();
            lbxTheaters.Items.Clear();
            loadTheater();
        }

        private void btn_manage_Click(object sender, EventArgs e)
        {
            LockClient lc = new LockClient();
            lc.Show();
        }
    }
}
