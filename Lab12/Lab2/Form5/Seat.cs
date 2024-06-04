using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Reflection;

namespace Lab2.Form5
{
    public partial class Seat : Form
    {

        Color[] colors = { Color.Coral, Color.LightGray, Color.Gray, Color.SkyBlue};
        public Seat()
        {
            InitializeComponent();
        }
        public class Theater
        {
            public int normal, vip, sweet, col;
            public string name, id;
            public Theater()
            {
                normal = vip = sweet = col = 0;
                name = id = string.Empty;
            }
            public Theater(string id, string name, int nor, int vip, int sw)
            {
                this.id = id;
                this.normal = nor;
                this.vip = vip;
                this.sweet = sw;
                this.name = name;
            }
        }
        public class SeatCount
        {
            public int normal, vip, sweet;
            public List<string> Name;
            public string theater;
            public SeatCount()
            {
                normal = vip = sweet = 0;
                Name = new List<string>();
                theater = string.Empty;
            }
            public void Inc(int type)
            {
                if (type == 1) normal++;
                if (type == 2) vip++;
                if (type == 3) sweet++;
            }
            public void Dec(int type)
            {
                if (type == 1) normal--;
                if (type == 2) vip--;
                if (type == 3) sweet--;
            }
        }
        public class SeatTag
        {
            public int type;
            public string name;
            public SeatTag(int type, string name)
            {
                this.type = type;
                this.name = name;
            }
        }
        static List<Theater> Theaters = new List<Theater>();
        public static Home.Movie MovieChosen = new Home.Movie();
        public static SeatCount seatCount = new SeatCount();
        static int Tabpos = 0;
        private DataTable getData(string query)
        {
            SqlConnection SQLConnect = new SqlConnection(Home.Connectpath);
            SQLConnect.Open();
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand(query, SQLConnect);
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            SQLConnect.Close();
            return dt;
        }
        private void upData(string query)
        {
            SqlConnection SQLConnect = new SqlConnection(Home.Connectpath);
            SQLConnect.Open();
            SqlCommand cmd = new SqlCommand(query, SQLConnect);
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            SQLConnect.Close();
        }
        public void loadData(DataTable dt)
        {
            Theaters = new List<Theater>();
            Theater theater;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                theater = new Theater();
                theater.id = dt.Rows[i]["Id"].ToString();
                theater.name = dt.Rows[i]["TName"].ToString();
                theater.normal = int.Parse(dt.Rows[i]["Normal"].ToString());
                theater.vip = int.Parse(dt.Rows[i]["Vip"].ToString());
                theater.sweet = int.Parse(dt.Rows[i]["Sweet"].ToString());
                theater.col = 8;
                Theaters.Add(theater);
            }
        }

        private void loadTab()
        {
            TabPage tp = tctrlMain.TabPages[0];
            tctrlMain.TabPages.Clear();
            tctrlMain.TabPages.Add(tp);

            for (int i = 0; i < MovieChosen.arrRoom.Count; i++) 
            {
                tp = new TabPage();
                tp.Name = "theater" + i.ToString();
                tp.Text = Theaters[MovieChosen.arrRoom[i]-1].name;
                tp.Tag = MovieChosen.arrRoom[i];
                tctrlMain.TabPages.Add(tp);
            }
            lbMName.Text = MovieChosen.name;
            tbxMInfo.Text = MovieChosen.setInfo() + "\r\n";
        }
        private void tctrlMain_SelectedIndexChanged(object sender, TabControlEventArgs e)
        {
            if (tctrlMain.SelectedIndex > 0)
            {
                if (Tabpos > 0) tctrlMain.TabPages[Tabpos].Controls.Clear();
                Tabpos = tctrlMain.SelectedIndex;
                seatCount.theater = tctrlMain.SelectedTab.Text;
                loadSeat(int.Parse(tctrlMain.TabPages[tctrlMain.SelectedIndex].Tag.ToString()));
            }
        }
        private void loadSeat(int pos)
        {
            Theater theater = Theaters[pos];
            int alphabet = (int)'A';
            TabPage tp = tctrlMain.TabPages[pos];
            Panel pMSeat = new Panel();
            pMSeat.Dock = DockStyle.Fill;
            pMSeat.Padding = new Padding(5);
            pMSeat = createSeat(pMSeat, theater.sweet, theater.col/2, 3, 70, alphabet + theater.normal + theater.vip + theater.sweet-1);
            pMSeat = createSeat(pMSeat, theater.vip, theater.col, 2, 35, alphabet + theater.normal + theater.vip-1);
            pMSeat = createSeat(pMSeat, theater.normal, theater.col, 1, 35, alphabet + theater.normal-1);
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
            pLabel.Controls.Add(btnSw);
            pLabel.Controls.Add(lbSw);
            pLabel.Controls.Add(btnVip);
            pLabel.Controls.Add(lbVip);
            pLabel.Controls.Add(btnNor);
            pLabel.Controls.Add(lbNor);
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
                p.Padding = new Padding(btnScreen.Width / 2-140, 5, 5, 5);
                for (int j = 0; j < col; j++)
                {
                    Button btn = new Button();
                    btn.Name = "Seat" + (row - i - 1).ToString() + (col - j - 1).ToString();
                    btn.Text = (col - j).ToString();
                    btn.Dock = DockStyle.Left;
                    btn.Width = width;
                    btn.Tag = new SeatTag(type, ((char)(alpha - i)).ToString() + (col - j).ToString());
                    btn.BackColor = colors[type];
                    btn.Click += btnSeat_Click;
                    p.Controls.Add(btn);
                }
                Label lb = new Label();
                lb.Name = "lbRank" + (row - i - 1).ToString();
                lb.Text = ((char)(alpha-i)).ToString();
                lb.TextAlign = ContentAlignment.MiddleRight;
                lb.Dock = DockStyle.Right;
                lb.AutoSize = true;
                lb.Font = new Font("Arial", 12, FontStyle.Bold);
                p.Controls.Add(lb);
                pMSeat.Controls.Add(p);
            }
            return pMSeat;
        }
        private void ChooseTicket_Load(object sender, EventArgs e)
        {
            string query = "Select * from SEAT";
            loadData(getData(query));
            loadTab();
        }

        private void btnSeat_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            SeatTag st = (SeatTag)btn.Tag;
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
            Bill b = new Bill();
            b.ShowDialog();
        }

    }
    //Lệnh Clone Conttrols
    public static class ControlExtensions
    {
        public static T Clone<T>(this T controlToClone)
            where T : Control
        {
            PropertyInfo[] controlProperties = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);

            T instance = Activator.CreateInstance<T>();

            foreach (PropertyInfo propInfo in controlProperties)
            {
                if (propInfo.CanWrite)
                {
                    if (propInfo.Name != "WindowTarget")
                        propInfo.SetValue(instance, propInfo.GetValue(controlToClone, null), null);
                }
            }

            return instance;
        }
    }
}
