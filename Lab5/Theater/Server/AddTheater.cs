using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Theater.Server
{
    public partial class AddTheater : Form
    {
        public AddTheater()
        {
            InitializeComponent();
        }

        private void loadData()
        {
            lvData.Items.Clear();
            string query = "SELECT Id, TName, Normal, Vip, Sweet FROM SEAT;";
            DataTable dt = Admin.getData(query);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = dt.Rows[i]["Id"].ToString();
                lvi.SubItems.Add(dt.Rows[i]["TName"].ToString().Replace('_', ' '));
                lvi.SubItems.Add(dt.Rows[i]["Normal"].ToString());
                lvi.SubItems.Add(dt.Rows[i]["Vip"].ToString());
                lvi.SubItems.Add(dt.Rows[i]["Sweet"].ToString());
                lvData.Items.Add(lvi);
            }
        }

        private bool checkValid()
        {
            if (tbxName.Text == string.Empty) { MessageBox.Show("Vui lòng nhập tên."); return false; }
            /*string query = "SELECT Id FROM SEAT WHERE CONVERT(NVARCHAR(MAX),TName) = N'" + tbxName.Text.Trim().Replace(' ','_') + "';";
            DataTable dt = Admin.getData(query);
            if (dt.Rows.Count > 0) { MessageBox.Show("Tên rạp đã tồn tại."); return false; }*/
            if (nudNormal.Value == 0 && nudVip.Value == 0 && nudSweet.Value==0) { MessageBox.Show("Vui lòng nhập số ghế"); return false; }
            return true;
        }

        private void clearInput()
        {
            tbxName.Text = string.Empty;
            nudNormal.Value = 0;
            nudVip.Value = 0;
            nudSweet.Value = 0;
        }

        private void inputData()
        {
            if (!checkValid()) return;
            if (tbxName.Tag == null)
            {
                DataTable dt = Admin.getData("SELECT Id FROM SEAT;");
                string query = string.Format("INSERT INTO SEAT VALUES({0}, N'{1}', {2}, {3}, {4});",
                        (dt.Rows.Count + 1).ToString(), tbxName.Text.Trim().Replace(' ', '_'), nudNormal.Value.ToString(), nudVip.Value.ToString(), nudSweet.Value.ToString());
                Admin.queryData(query);
                MessageBox.Show("Đã thêm dữ liệu Rạp");
            }
            else
            {
                string id = tbxName.Tag.ToString();
                string query = string.Format("UPDATE SEAT SET TName = N'{0}', Normal = {1}, Vip = {2}, Sweet = {3} WHERE Id = {4};", 
                    tbxName.Text.Trim().Replace(' ', '_'), nudNormal.Value.ToString(), nudVip.Value.ToString(), nudSweet.Value.ToString(), id);
                Admin.queryData(query);
                MessageBox.Show("Đã cập nhật dữ liệu Rạp");
            }
            clearInput();
            loadData();
        }

        private void AddTheater_Load(object sender, EventArgs e)
        {
            tbxName.Tag = null;
            loadData();
        }

        private void AddTheater_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) inputData();
        }

        private void lvData_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                tbxName.Tag = null;
                clearInput();
            }
            if (lvData.CheckedItems.Count > 0 && e.Shift && e.KeyCode == Keys.Delete)
            {
                DialogResult dr = MessageBox.Show("Bạn có chắc muốn xoá " + lvData.SelectedItems.Count.ToString() + " rạp đã chọn không?", "Lưu ý", MessageBoxButtons.OKCancel);
                if (dr != DialogResult.OK) return; 
                string query = string.Empty;
                foreach (ListViewItem lvi in lvData.SelectedItems)
                {
                    query = "SELECT Id FROM SEAT WHERE Idtheater = " + lvi.Text + ";";
                    if (Admin.getData(query).Rows.Count > 0) { MessageBox.Show("Tồn tại phim dang sử dụng " + lvi.SubItems[0]); continue; }
                    query = "DELETE FROM SEAT WHERE Id = " + lvi.Text + ";";
                    Admin.queryData(query);

                }
                MessageBox.Show("Đã xoá thành công");
                loadData();
            } 
        }

        private void lvData_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvData.SelectedItems.Count == 1)
            {
                string id = lvData.SelectedItems[0].Text;
                tbxName.Tag = id;
                string query = "SELECT TName, Normal, Vip, Sweet FROM SEAT WHERE Id = " + id + ";";
                DataTable dt = Admin.getData(query);
                tbxName.Text = dt.Rows[0]["TName"].ToString().Replace('_', ' ');
                nudNormal.Value = int.Parse(dt.Rows[0]["Normal"].ToString());
                nudVip.Value = int.Parse(dt.Rows[0]["Vip"].ToString());
                nudSweet.Value = int.Parse(dt.Rows[0]["Sweet"].ToString());
            }
            if (lvData.SelectedItems.Count > 1)
            {
                tbxName.Tag = null;
                clearInput();
            }
        }
    }
}
