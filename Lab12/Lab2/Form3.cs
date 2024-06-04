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

namespace Lab2
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private static string text = string.Empty;
        private long Split_Cal (string text)
        {
            text += "++";
            long temp = 0, num = 0;
            int plussub = 0;
            if (!long.TryParse(text.Substring(0,text.IndexOf(' ')).Trim(), out temp))
            {
                MessageBox.Show("Vui lòng chọn đúng file dữ liệu");
                return long.MaxValue-1;
            }
            text = text.Substring(text.IndexOf(' ')).Trim();
            while (text.Trim() != "++")
            {
                if (text.Substring(0, 1) == "+") plussub = 1;
                if (text.Substring(0, 1) == "-") plussub = -1;
                text = text.Substring(1).Trim();
                Console.WriteLine(text);
                if ((!long.TryParse(text.Substring(0, text.IndexOf('+') - 1).Trim(), out num)) && 
                    (!long.TryParse(text.Substring(0, text.IndexOf('-') - 1).Trim(), out num))) {
                    MessageBox.Show("Vui lòng chọn đúng file dữ liệu");
                    return long.MaxValue - 1;
                }
                temp += plussub * num;
                text = text.Substring(text.IndexOf(num.ToString())+num.ToString().Length).Trim();
            }

            return temp;
        }
        private void btnRead_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            if (ofd.FileName == string.Empty)
            {
                MessageBox.Show("Vui lòng chọn file ");
                return;
            }
            FileStream fs = new FileStream(ofd.FileName, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            text = sr.ReadToEnd();
            sr.Close();
            fs.Close();
            tbxRead.Text = text;
        }

        private void btnCal_Click(object sender, EventArgs e)
        {
            if (text == string.Empty)
            {
                MessageBox.Show("Vui lòng chọn file ");
                return;
            }
            tbxResult.Text = Split_Cal(text).ToString();
        }

        private void Form3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) btnCal_Click(this, new EventArgs());
        }
    }
}
