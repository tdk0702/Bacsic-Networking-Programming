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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            FileStream fs = new FileStream(ofd.FileName, FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            tbxContent.Text = sr.ReadToEnd();
            sr.Close();
            fs.Close();
            tbxName.Text = ofd.FileName.Substring(ofd.FileName.LastIndexOf('\\')+1);
            tbxSize.Text = new FileInfo(ofd.FileName).Length.ToString() + "bytes";
            tbxURL.Text = new FileInfo(ofd.FileName).FullName;
            string text = tbxContent.Text;
            tbxLine.Text = (text.Length - text.Replace("\r\n", "").Length).ToString();
            tbxWord.Text = (text.Length - text.Replace("\r\n", "").Replace(" ","").Length).ToString();
            tbxChar.Text = text.Length.ToString();
        }

        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) btnRead_Click(this, new EventArgs());
        }
    }
}
