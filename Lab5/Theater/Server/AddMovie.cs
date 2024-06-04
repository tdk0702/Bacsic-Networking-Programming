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
using HtmlAgilityPack;
using System.Net;

namespace Theater.Server
{
    public partial class AddMovie : Form
    {
        public AddMovie()
        {
            InitializeComponent();
        }
        private void inputData(string name, string origin, string img, string url, int price, List<int> arr)
        {
            name = name.Replace(' ', '_');
            origin = origin.Replace(' ', '_');
            DataTable dt;
            if (tbxName.Tag == null)
            {
                string insertcmd = string.Format("INSERT INTO INFO VALUES(N'{0}',N'{1}',N'{2}',{3}, N'{4}')", name, origin, img, price.ToString(), url);
                Admin.queryData(insertcmd);
                dt = Admin.getData(string.Format("SELECT Id FROM INFO WHERE CONVERT(NVARCHAR(MAX),Mname) = N'{0}';", name));
                string id = dt.Rows[0]["Id"].ToString();
                foreach (int num in arr)
                {
                    insertcmd = string.Format("INSERT INTO THEATERS VALUES({0},{1})", id, num.ToString());
                    Admin.queryData(insertcmd);
                }
                Console.WriteLine("Đã thêm dữ liệu Movie");
            }
            else
            {
                string id = tbxName.Tag.ToString();
                string query = string.Format("UPDATE INFO SET Mname = N'{0}', Origin = N'{1}', Img = N'{2}', Price = {3}, Url = N'{4}' WHERE Id = {5};", name, origin, img, price.ToString(), url, id);
                Admin.queryData(query);
                query = "DELETE FROM THEATERS WHERE Id = " + id + ";";
                Admin.queryData(query);
                foreach (int num in arr)
                {
                    query = string.Format("INSERT INTO THEATERS VALUES({0},{1})", id, num.ToString());
                    Admin.queryData(query);
                }
                Console.WriteLine("Đã cập nhật dữ liệu Movie");
            }
            clearInput();
            getData();
        }
        private void getData()
        {
            lvData.Items.Clear();
            string query = "SELECT Id, Mname, Price FROM INFO;";
            DataTable dt = Admin.getData(query);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = dt.Rows[i]["Id"].ToString();
                lvi.SubItems.Add(dt.Rows[i]["Mname"].ToString().Replace('_', ' '));
                lvi.SubItems.Add(dt.Rows[i]["Price"].ToString() + ".000 VNĐ");
                query = "SELECT TName FROM THEATERS, SEAT WHERE SEAT.Id = THEATERS.Idtheater AND THEATERS.Id = " + lvi.Text + ";";
                DataTable dts = Admin.getData(query);
                string seat = string.Empty;
                for (int j = 0; j < dts.Rows.Count; j++)
                {
                    seat += ", " + dts.Rows[j]["TName"].ToString().Replace('_', ' ');
                }
                seat = seat.Substring(2);
                lvi.ToolTipText = seat;
                lvData.Items.Add(lvi);
            }
        }
        private void getTheaters()
        {
            string query = "SELECT Id, TName FROM SEAT;";
            DataTable dt = Admin.getData(query);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                clbTheater.Items.Add(dt.Rows[i]["Id"].ToString() + " - " + dt.Rows[i]["TName"].ToString().Replace('_',' '));
            }
        }
        private bool isTbxEmpty()
        {
            if (tbxName.Text.Trim() == string.Empty) return false;
            if (tbxOrigin.Text.Trim() == string.Empty) return false;
            if (tbxPrice.Text.Trim() == string.Empty) return false;
            if (clbTheater.CheckedItems.Count == 0) return false;
            return true;
        }
        private void tbxData_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!isTbxEmpty()) { MessageBox.Show("vui lòng nhập dữ liệu"); return; }
                
                List<int> theaArr = new List<int>();
                int price=0;
                try
                {
                    price = int.Parse(tbxPrice.Text.Trim());
                }
                catch (FormatException expt)
                {
                    MessageBox.Show("Giá tiền phải có giá trị là số nguyên. Err:" + expt.ToString());
                    return;
                }
                try
                {
                    foreach(string item in clbTheater.CheckedItems)
                    {
                        int num = int.Parse(item.Substring(0,item.IndexOf(' ')));
                        theaArr.Add(num);
                    }
                }
                catch (FormatException expt)
                {
                    MessageBox.Show("Phòng chiếu phải là mảng số nguyên. Err:" + expt.ToString());
                    return;
                }
                inputData(tbxName.Text.Trim(),tbxOrigin.Text.Trim(),"", "", price, theaArr);
                clearInput();
            }
        }
        private void clearInput()
        {
            tbxName.Text = string.Empty;
            tbxOrigin.Text = string.Empty;
            tbxPrice.Text = string.Empty;
            //clbTheater.ClearSelected();
            for (int i = 0; i < clbTheater.Items.Count; i++)
                clbTheater.SetItemChecked(i,false);
        }

        private void lvData_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                tbxName.Tag = null;
                clearInput();
            }
            if (lvData.SelectedItems.Count > 0 && e.Shift && e.KeyCode == Keys.Delete)
            {
                DialogResult dr = MessageBox.Show("Bạn có chắc muốn xoá " + lvData.SelectedItems.Count.ToString() + " phim đã chọn không ?", "Lưu ý", MessageBoxButtons.OKCancel);
                if (dr != DialogResult.OK) return;
                string query = string.Empty;
                foreach(ListViewItem lvi in lvData.SelectedItems)
                {
                    query = "DELETE FROM THEATERS WHERE Id = " + lvi.Text + ";";
                    Admin.queryData(query);
                    query = "DELETE FROM INFO WHERE Id = " + lvi.Text + ";";
                    Admin.queryData(query);

                }
                lvData.SelectedItems.Clear();
                MessageBox.Show("Đã xoá thành công");
                getData();
            }
        }

        private void AddMovie_Load(object sender, EventArgs e)
        {
            tbxName.Tag = null;
            clbTheater.Items.Clear();
            getData();
            getTheaters();
        }

        private void DeleteData()
        {
            string query = @"DELETE FROM THEATERS;";
            Admin.queryData(query);
            query = @"DELETE FROM INFO;";
            Admin.queryData(query);
            query = @"DBCC CHECKIDENT ('INFO', RESEED, 0);";
            Admin.queryData(query);
            lvData.Items.Clear();
        }

        private void lvData_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvData.SelectedItems.Count == 1)
            {
                string id = lvData.SelectedItems[0].Text;
                tbxName.Tag = id;
                string query = "SELECT Mname, Origin, Price FROM INFO WHERE Id = " + id + ";";
                DataTable dt = Admin.getData(query);
                tbxName.Text = dt.Rows[0]["Mname"].ToString().Replace('_',' ');
                tbxOrigin.Text = dt.Rows[0]["Origin"].ToString().Replace('_', ' ');
                tbxPrice.Text = dt.Rows[0]["Price"].ToString();
                query = "SELECT Idtheater FROM THEATERS WHERE Id = " + id + ";";
                dt = Admin.getData(query);
                for (int i = 0;i < dt.Rows.Count; i++)
                {
                    clbTheater.SetItemChecked(int.Parse(dt.Rows[i]["Idtheater"].ToString())-1,true);
                }
            }
            if (lvData.SelectedItems.Count > 1)
            {
                tbxName.Tag = null;
                clearInput();
            }
        }
        private int RandomPrice()
        {
            Random random = new Random();
            return 5 * random.Next(13, 20);
        }
        private List<int> RandomTheater()
        {
            Random random = new Random();
            string query = "SELECT * FROM SEAT;";
            DataTable dt = Admin.getData(query);
            bool[] boolarr = random.Next((int)Math.Pow(2,dt.Rows.Count)-1).ToBooleanArray();
            List<int> tts = new List<int>();
            for (int i = 0; i < boolarr.Length; i++) if (boolarr[i]) tts.Add(i + 1);
            return tts;
        }
        private void btnGet_Click(object sender, EventArgs e)
        {
            DeleteData();
            string urlstring = tbxUrl.Text.Trim();
            using (WebClient wc = new WebClient())
            {
                var json = wc.DownloadString(urlstring);
                HtmlAgilityPack.HtmlDocument hd = new HtmlAgilityPack.HtmlDocument();
                hd.LoadHtml(json);
                HtmlNodeCollection hnc = hd.DocumentNode.SelectNodes("//div[@class='film-info film-xs-info']/h3/a");
                List<string> urls = new List<string>();
                foreach (HtmlNode hn in hnc)
                {
                    string url = hn.GetAttributeValue("href", "");
                    urls.Add(urlstring.Substring(0, urlstring.LastIndexOf("/")) + url);
                }
                foreach (string url in urls)
                {
                    json = wc.DownloadString(url);
                    hd.LoadHtml(json);
                    HtmlNode hn = hd.DocumentNode.SelectSingleNode("//h1[@class='bold no-margin margin-bottom-15']");
                    string name = hn.InnerText.Trim();
                    hn = hd.DocumentNode.SelectSingleNode("//p[@class='margin-bottom-15 font-lg font-family-san text-justify']");
                    string origin = hn.InnerText.Trim() + "\r\n";
                    hnc = hd.DocumentNode.SelectNodes("//div[@class='row font-lg font-family-san font-xs-14']/div");
                    foreach (HtmlNode htmlNode in hnc)
                    {
                        origin += htmlNode.InnerText.Trim() + "\r\n";
                        Thread.Sleep(10);
                    }
                    origin = origin.Replace(":\r\n", ": ");
                    hn = hd.DocumentNode.SelectSingleNode("//div[@class='pi-img-wrapper']/img");
                    string img = hn.GetAttributeValue("src", "");
                    inputData(name, origin, img, url, RandomPrice(), RandomTheater());
                }
            }
            getData();
            MessageBox.Show("Lấy dữ liệu hoàn tất.");
        }
    }

    public static class Int32Extensions
    {
        public static Boolean[] ToBooleanArray(this Int32 i)
        {
            return Convert.ToString(i, 2 /*for binary*/).Select(s => s.Equals('1')).ToArray();
        }
    }
}
