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

namespace Lab3.Theater
{
    public partial class AddMovie : Form
    {
        public AddMovie()
        {
            InitializeComponent();
        }
        private void inputData(string name, string origin, int price, List<int> arr)
        {
            name = name.Replace(' ', '_');
            origin = origin.Replace(' ', '_');
            DataTable dt;
            if (tbxName.Tag == null)
            {
                string insertcmd = string.Format("INSERT INTO INFO VALUES(N'{0}',N'{1}',{2})", name, origin, price.ToString());
                Admin.queryData(insertcmd);
                dt = Admin.getData(string.Format("SELECT Id FROM INFO WHERE CONVERT(NVARCHAR(MAX),Mname) = N'{0}';", name));
                string id = dt.Rows[0]["Id"].ToString();
                foreach (int num in arr)
                {
                    insertcmd = string.Format("INSERT INTO THEATERS VALUES({0},{1})", id, num.ToString());
                    Admin.queryData(insertcmd);
                }
                MessageBox.Show("Đã thêm dữ liệu Movie");
            }
            else
            {
                string id = tbxName.Tag.ToString();
                string query = string.Format("UPDATE INFO SET Mname = N'{0}', Origin = N'{1}', Price = {2} WHERE Id = {3};", name, origin, price.ToString(),id);
                Admin.queryData(query);
                query = "DELETE FROM THEATERS WHERE Id = " + id + ";";
                Admin.queryData(query);
                foreach (int num in arr)
                {
                    query = string.Format("INSERT INTO THEATERS VALUES({0},{1})", id, num.ToString());
                    Admin.queryData(query);
                }
                MessageBox.Show("Đã cập nhật dữ liệu Movie");
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
            if (tbxInfo.Text.Trim() == string.Empty) return false;
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
                inputData(tbxName.Text.Trim(),tbxOrigin.Text.Trim(), price, theaArr);
                clearInput();
            }
        }
        private void clearInput()
        {
            tbxName.Text = string.Empty;
            tbxOrigin.Text = string.Empty;
            tbxInfo.Text = string.Empty;
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
                tbxInfo.Text = "Info!!";
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
    }
}
