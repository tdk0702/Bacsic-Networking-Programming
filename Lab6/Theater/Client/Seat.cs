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
using System.Data.SqlClient;
using System.Reflection;
using System.Net.Sockets;
using System.Net;
using System.IO;

namespace Theater.Client
{
    public partial class Seat : Form
    {
        private string clientname;
        private Class.User ClientUser;
        Color[] colors = { Color.Coral, Color.LightGray, Color.Gray, Color.SkyBlue };
        public Seat()
        {
            InitializeComponent();
        }
        public Seat(Class.User user, string clname)
        {
            InitializeComponent();
            clientname = clname;
            ClientUser = user;
        }

        static List<Class.Theater> Theaters = new List<Class.Theater>();
        public static Class.Movie MovieChosen = new Class.Movie();
        public static Class.SeatCount seatCount = new Class.SeatCount();
        private static Class.BuyedSeat Buyeds = new Class.BuyedSeat();
        static int Tabpos = 0;
        private void ChooseTicket_Load(object sender, EventArgs e)
        {
            string query = "SELECT Id,TName,Normal,Vip,Sweet FROM SEAT";
            loadData(Home.GetData(clientname, query));
        }
        public void loadData(string data)
        {
            //Load Theater
            Theaters = new List<Class.Theater>();
            Theaters.Add(new Class.Theater());
            Class.Theater theater;
            string[] rows = data.Split(';');
            for (int i = 0; i < rows.Length; i++)
            {
                string[] col = rows[i].Split(' ');
                theater = new Class.Theater();
                theater.id = col[0];
                theater.name = col[1].Replace('_', ' ');
                theater.normal = int.Parse(col[2]);
                theater.vip = int.Parse(col[3]);
                theater.sweet = int.Parse(col[4]);
                theater.col = 8;
                Theaters.Add(theater);
            }

            //Show Theater to Tabpage
            TabPage tp = tctrlMain.TabPages[0];
            tctrlMain.TabPages.Clear();
            tctrlMain.TabPages.Add(tp);

            for (int i = 0; i < MovieChosen.arrRoom.Count; i++)
            {
                tp = new TabPage();
                tp.Name = "theater" + i.ToString();
                tp.Text = Theaters[MovieChosen.arrRoom[i]].name;
                tp.Tag = MovieChosen.arrRoom[i];
                tctrlMain.TabPages.Add(tp);
            }
            lbMName.Text = MovieChosen.name;
            tbxMInfo.Text = MovieChosen.getOrigin(clientname) + "\r\n" + MovieChosen.setInfo() + "\r\n";
            pbxMImage.Image = GetImage(MovieChosen.img);
        }

        private Image GetImage(string img)
        {
            var request = WebRequest.Create(img);
            using (var response = request.GetResponse())
            using (var stream = response.GetResponseStream())
            {
                return Bitmap.FromStream(stream);
            }
        }

        private void loadBuyedSeat(string id)
        {
            Buyeds.idseats.Clear();
            string query =
                string.Format("SELECT Idseat FROM TICKER, BUYED WHERE " +
                "TICKER.Id = BUYED.Id AND IdTheater={0} AND Idmovie={1} AND FORMAT(Datet, 'yyyy-MM-dd') = '{2}';",
                id, MovieChosen.id, /*"2024-04-17"*/DateTime.Now.ToString("yyyy-MM-dd"));
            string[] datarow = Home.GetData(clientname, query).Split(';');
            if (datarow.Length == 0) { Console.WriteLine("data empty!"); return; }
            for (int i = 0; i < datarow.Length; i++)
            {
                string[] datacol = datarow[i].Split(' ');
                foreach (string data in datacol)
                    Buyeds.idseats.Add(data);
            }

        }

        private void tctrlMain_SelectedIndexChanged(object sender, TabControlEventArgs e)
        {
            if (tctrlMain.SelectedIndex > 0)
            {
                loadSeat(int.Parse(tctrlMain.TabPages[tctrlMain.SelectedIndex].Tag.ToString()));
            }
        }
        public void loadSeat(int pos)
        {
            seatCount = new Class.SeatCount();
            if (Tabpos > 0) tctrlMain.TabPages[Tabpos].Controls.Clear();
            Tabpos = tctrlMain.SelectedIndex;
            seatCount.theater = tctrlMain.SelectedTab.Text;
            seatCount.id = Theaters[pos].id;
            loadBuyedSeat(seatCount.id);
            Class.Theater theater = Theaters[pos];
            int alphabet = (int)'A';
            TabPage tp = tctrlMain.TabPages[tctrlMain.SelectedIndex];
            Panel pMSeat = new Panel();
            pMSeat.Dock = DockStyle.Fill;
            pMSeat.Padding = new Padding(5);
            pMSeat = createSeat(pMSeat, theater.sweet, theater.col / 2, 3, 70, alphabet + theater.normal + theater.vip + theater.sweet - 1);
            pMSeat = createSeat(pMSeat, theater.vip, theater.col, 2, 35, alphabet + theater.normal + theater.vip - 1);
            pMSeat = createSeat(pMSeat, theater.normal, theater.col, 1, 35, alphabet + theater.normal - 1);
            tp.Controls.Add(pMSeat);

            Button btnScr = createBtnInfo("btnScr", "MÀN HÌNH CHIẾU PHIM", DockStyle.Top, 0, Color.Transparent);
            btnScr.Font = new Font("Microsoft Sans Serif", 14, FontStyle.Bold);
            btnScr.AutoSize = true;
            btnScr.FlatStyle = FlatStyle.Flat;
            btnScr.Enabled = false;
            tp.Controls.Add(btnScr);

            Panel pLabel = new Panel();
            pLabel.Name = "pLabel";
            pLabel.Dock = DockStyle.Left;
            pLabel.Width = tctrlMain.Width / 8;
            pLabel.Padding = new Padding(5);

            Button btnSw = createBtnInfo("btnSw", string.Empty, DockStyle.Top, 35, colors[3]);
            Label lbSw = createLbInfo("lbSw", "SweetBox:", ContentAlignment.MiddleLeft, true, DockStyle.Top);
            Button btnVip = createBtnInfo("btnVip", string.Empty, DockStyle.Top, 35, colors[2]);
            Label lbVip = createLbInfo("lbVip", "Ghế VIP:", ContentAlignment.MiddleLeft, true, DockStyle.Top);
            Button btnNor = createBtnInfo("btnSw", string.Empty, DockStyle.Top, 35, colors[1]);
            Label lbNor = createLbInfo("lbNor", "Ghế thường:", ContentAlignment.MiddleLeft, true, DockStyle.Top);
            Button btnBuy = createBtnInfo("btnBuy", string.Empty, DockStyle.Top, 35, Color.White);
            Label lbBuy = createLbInfo("lbBuy", "Ghế đã mua:", ContentAlignment.MiddleLeft, true, DockStyle.Top);

            pLabel.Controls.Add(btnSw);
            pLabel.Controls.Add(lbSw);
            pLabel.Controls.Add(btnVip);
            pLabel.Controls.Add(lbVip);
            pLabel.Controls.Add(btnNor);
            pLabel.Controls.Add(lbNor);
            pLabel.Controls.Add(btnBuy);
            pLabel.Controls.Add(lbBuy);

            tp.Controls.Add(pLabel);
        }
        private Button createBtnInfo(string name, string text, DockStyle ds, int height, Color c)
        {
            Button btn = new Button();
            btn.Name = name;
            btn.Text = text;
            btn.Dock = ds;
            btn.Height = height;
            btn.BackColor = c;
            return btn;
        }
        private Label createLbInfo(string name, string text, ContentAlignment ca, bool asize, DockStyle ds)
        {
            Label lb = new Label();
            lb.Name = name;
            lb.Text = text;
            lb.TextAlign = ca;
            lb.AutoSize = asize;
            lb.Dock = ds;
            return lb;
        }
        private Panel createSeat(Panel pMSeat, int row, int col, int type, int width, int alpha)
        {
            for (int i = 0; i < row; i++)
            {
                Panel p = new Panel();
                p.Dock = DockStyle.Top;
                p.Height = 45;
                p.Padding = new Padding(btnScreen.Width / 2 - 140, 5, 5, 5);
                for (int j = 0; j < col; j++)
                {
                    Button btn = new Button();
                    btn.Name = "Seat" + (row - i - 1).ToString() + (col - j - 1).ToString();
                    btn.Text = (col - j).ToString();
                    btn.Dock = DockStyle.Left;
                    btn.Width = width;
                    string name = ((char)(alpha - i)).ToString() + (col - j).ToString();
                    btn.Tag = new Class.SeatTag(type, name);
                    if (Buyeds.idseats.Contains(name))
                    {
                        btn.Enabled = false;
                        btn.BackColor = Color.White;
                        btn.Text = string.Empty;
                    }
                    else
                    {
                        btn.BackColor = colors[type];
                        btn.Click += btnSeat_Click;
                    }
                    p.Controls.Add(btn);
                    ttSeat.SetToolTip(btn, name);
                }
                Label lb = new Label();
                lb.Name = "lbRank" + (row - i - 1).ToString();
                lb.Text = ((char)(alpha - i)).ToString();
                lb.TextAlign = ContentAlignment.MiddleRight;
                lb.Dock = DockStyle.Right;
                lb.AutoSize = true;
                lb.Font = new Font("Arial", 12, FontStyle.Bold);
                p.Controls.Add(lb);
                pMSeat.Controls.Add(p);
            }
            return pMSeat;
        }


        private void btnSeat_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            Class.SeatTag st = (Class.SeatTag)btn.Tag;
            int type = st.type;
            if (btn.BackColor != colors[0])
            {
                seatCount.Inc(type);
                seatCount.Name.Add(st.name);
                btn.BackColor = colors[0];
            }
            else
            {
                seatCount.Dec(type);
                seatCount.Name.Remove(st.name);
                btn.BackColor = colors[type];
            }
        }

        private void btnGo_Click(object sender, EventArgs e)
        {

            if (seatCount.isEmpty()) { MessageBox.Show("Vui lòng lựa chọn."); return; }
            if (!checkInvalid())
            {
                MessageBox.Show("Đã có ghế đã bị mua, vui lòng chọn lại.");
                loadSeat(int.Parse(tctrlMain.TabPages[tctrlMain.SelectedIndex].Tag.ToString()));
                return;
            }
            Bill b = new Bill(ClientUser, clientname);
            this.FormClosing += (e, obj) => b.Close();
            b.ShowDialog();
            loadSeat(int.Parse(tctrlMain.TabPages[tctrlMain.SelectedIndex].Tag.ToString()));
        }
        private bool checkInvalid()
        {
            foreach (string seat in seatCount.Name)
            {
                string query = string.Format("SELECT BUYED.Id FROM BUYED,TICKER WHERE TICKER.Id = BUYED.Id AND IdSeat = '{0}' AND FORMAT(Datet, 'yyyy-MM-dd') =  '{1}' AND Idtheater = {2} AND Idmovie = {3};",
                            seat, DateTime.Now.ToString("yyyy-MM-dd"), seatCount.id, MovieChosen.id);
                string data = Home.GetData(clientname, query);
                Console.WriteLine(data);
                if (!data.Contains("No data")) return false;
            }
            return true;
        }

        private void llbLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string url = MovieChosen.getURL(clientname);
            WebForm wf = new WebForm(url);
            this.FormClosing += (e, obj) => wf.Close();
            wf.ShowDialog();
        }
        /*public void loadData(DataTable dt)
{
   //Load Theater
   Theaters = new List<Class.Theater>();
   Class.Theater theater;
   for (int i = 0; i < dt.Rows.Count; i++)
   {
       theater = new Class.Theater();
       theater.id = dt.Rows[i]["Id"].ToString();
       theater.name = dt.Rows[i]["TName"].ToString();
       theater.normal = int.Parse(dt.Rows[i]["Normal"].ToString());
       theater.vip = int.Parse(dt.Rows[i]["Vip"].ToString());
       theater.sweet = int.Parse(dt.Rows[i]["Sweet"].ToString());
       theater.col = 8;
       Theaters.Add(theater);
   }
   //Show Theater to Tabpage
   TabPage tp = tctrlMain.TabPages[0];
   tctrlMain.TabPages.Clear();
   tctrlMain.TabPages.Add(tp);

   for (int i = 0; i < MovieChosen.arrRoom.Count; i++)
   {
       tp = new TabPage();
       tp.Name = "theater" + i.ToString();
       tp.Text = Theaters[MovieChosen.arrRoom[i] - 1].name;
       tp.Tag = MovieChosen.arrRoom[i];
       tctrlMain.TabPages.Add(tp);
   }
   lbMName.Text = MovieChosen.name;
   tbxMInfo.Text = MovieChosen.setInfo() + "\r\n";
}*/
    }
}
