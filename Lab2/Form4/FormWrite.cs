using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;

namespace Lab2.Form4
{
    public partial class FormWrite : Form
    {
        public FormWrite()
        {
            InitializeComponent();
        }
        [Serializable]
        public class Student
        {
            public string name, id, phone;
            public double scr1, scr2, scr3, avg;
            public Student() {
                name = id = phone = string.Empty;
                scr1 = scr2 = scr3 = avg = -1;
            }
            public Student(string n, string i, string p, double s1, double s2, double s3)
            {
                name = n; id = i; phone = p; scr1 = s1; scr2 = s2; scr3 = s3;
                avg = (s1 + s2 + s3) / 3.0;
            }
            public void Avg()
            {
                avg = (scr1 + scr2 + scr3) / 3.0;
            }
        };
        public static List<FormWrite.Student> StData = new List<FormWrite.Student>();
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Form4.AddForm af = new Form4.AddForm();
            af.ShowDialog();
            lvInfo_Reload();
        }


        private void lvInfo_Reload()
        {
            List<Student> list_st = StData;
            lvInfo.Items.Clear();
            for (int i = 0; i < list_st.Count; i++)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = (i + 1).ToString();
                lvi.SubItems.Add(list_st[i].name);
                lvi.SubItems.Add(list_st[i].id);
                lvi.SubItems.Add(list_st[i].phone);
                lvi.SubItems.Add(list_st[i].scr1.ToString());
                lvi.SubItems.Add(list_st[i].scr2.ToString());
                lvi.SubItems.Add(list_st[i].scr3.ToString());
                lvi.SubItems.Add(list_st[i].avg.ToString());

                lvInfo.Items.Add(lvi);
            }
        }

        private string convertLvitoString()
        {
            string text = string.Empty;
            foreach (ListViewItem item in lvInfo.Items)
            {
                foreach (ListViewItem.ListViewSubItem subi in item.SubItems)
                {
                    text += subi.Text + "\r\n";
                }
                text += "/br" + "\r\n";
            }
            return text;
        }
        private bool convertStringtoLvi(string text)
        {
            StData.Clear();
            Student st;
            while (text.IndexOf("/br") != -1)
            {
                st = new Student();
                st.name = text.Substring(0, text.IndexOf("\r\n")).Trim();
                text.Remove(0, text.IndexOf("\r\n"));
                st.id = text.Substring(0, text.IndexOf("\r\n")).Trim();
                text.Remove(0, text.IndexOf("\r\n"));
                st.phone = text.Substring(0, text.IndexOf("\r\n")).Trim();
                text.Remove(0, text.IndexOf("\r\n"));
                try
                {
                    st.scr1 = double.Parse(text.Substring(0, text.IndexOf("\r\n")).Trim());
                    text.Remove(0, text.IndexOf("\r\n"));
                    st.scr2 = double.Parse(text.Substring(0, text.IndexOf("\r\n")).Trim());
                    text.Remove(0, text.IndexOf("\r\n"));
                    st.scr3 = double.Parse(text.Substring(0, text.IndexOf("\r\n")).Trim());
                    text.Remove(0, text.IndexOf("\r\n"));
                }
                catch (FormatException)
                {
                    MessageBox.Show("Vui lòng kiểm tra lại file dữ liệu");
                    return false;
                }
                st.Avg();
                text.Remove(0, text.IndexOf("\r\n"));
                StData.Add(st);
            }
            return true;
        }

        private void btnAddtofile_Click(object sender, EventArgs e)
        {
            //string text = convertLvitoString();
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Text files (*.txt)|*.txt";
            sfd.ShowDialog();
            if (sfd.FileName == string.Empty)
            {
                MessageBox.Show("Vui lòng nhập tên file");
                return;
            }
            FileStream fs = new FileStream(sfd.FileName, FileMode.OpenOrCreate, FileAccess.Write);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, StData);
            MessageBox.Show("Tạo và ghi dữ liệu thành công");
            fs.Close();
        }

        private void btnReadfrfile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Text files (*.txt)|*.txt";
            ofd.ShowDialog();
            if (ofd.FileName == string.Empty)
            {
                MessageBox.Show("Vui lòng chọn file");
                return;
            }
            FileStream fs = new FileStream(ofd.FileName, FileMode.Open, FileAccess.Read);
            BinaryFormatter bf = new BinaryFormatter();
            var data = bf.Deserialize(fs);
            StData = (List<Student>)data;
            lvInfo_Reload();
            fs.Close();
        }

        private void BackNext(int pos)
        {
            lbInfo.Text = "SINH VIÊN " + (pos + 1).ToString();
            tbxName.Text = StData[pos].name;
            tbxID.Text = StData[pos].id;
            tbxPhone.Text = StData[pos].phone;
            tbxScore1.Text = StData[pos].scr1.ToString();
            tbxScore2.Text = StData[pos].scr2.ToString();
            tbxScore3.Text = StData[pos].scr3.ToString();
            tbxAvg.Text = StData[pos].avg.ToString();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            int i = int.Parse(lbInfo.Tag.ToString().Trim());
            i--;
            lbInfo.Tag = i;
            if (i == 0) {  
                btnBack.Enabled = false;
                btnBack.Text = "v";
                btnBack.Font = new Font("Wingdings", 24, FontStyle.Bold);
            }
            if (i < StData.Count - 1)
            {
                btnNext.Enabled = true;
                btnNext.Text = "u";
                btnNext.Font = new Font("Wingdings 3", 24, FontStyle.Bold);
            }
            BackNext(i);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            int i = int.Parse(lbInfo.Tag.ToString().Trim());
            i++;
            lbInfo.Tag = i;
            if (i == StData.Count - 1){
                btnNext.Enabled = false;
                btnNext.Text = "v";
                btnNext.Font = new Font("Wingdings", 24, FontStyle.Bold);
            }
            if (i > 0)
            {
                btnBack.Enabled = true;
                btnBack.Text = "t";
                btnBack.Font = new Font("Wingdings 3", 24, FontStyle.Bold);
            }
            BackNext(i);
        }

        private void tcInfo_Selected(object sender, TabControlEventArgs e)
        {
            switch (tcInfo.SelectedIndex)
            {
                case 0:
                    lvInfo_Reload();
                    break;
                case 1:
                    lbInfo.Tag = "0";
                    BackNext(0);
                    break;
            }
        }

        private void FormWrite_Load(object sender, EventArgs e)
        {
            lvInfo.Items.Clear();
        }


        private void lvInfo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                foreach (ListViewItem lvi in lvInfo.SelectedItems)
                    lvInfo.Items.Remove(lvi);

            }
        }
    }
}
