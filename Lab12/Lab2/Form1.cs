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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Text|*.txt";
            ofd.ShowDialog();
            if (string.IsNullOrEmpty(ofd.FileName))
            {
                MessageBox.Show("Vui lòng chọn file.");
                return;
            }
            FileStream fs = new FileStream(ofd.FileName, FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            string text = sr.ReadToEnd();
            tbxShow.Text = text;
            sr.Close();
            fs.Close();
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Text|*.txt";
            ofd.ShowDialog();
            if (string.IsNullOrEmpty(ofd.FileName))
            {
                MessageBox.Show("Vui lòng chọn file.");
                return;
            }
            FileStream fs = new FileStream(ofd.FileName, FileMode.Create, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            string text = tbxShow.Text.ToUpper();
            sw.Write(text);
            sw.Close();
            fs.Close();
        }
    }
}
