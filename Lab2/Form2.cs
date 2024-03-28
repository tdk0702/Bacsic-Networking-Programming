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
            string text = string.Empty;
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            FileStream fs = new FileStream(ofd.FileName, FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            text = sr.ReadToEnd().Trim();
            sr.Close();
            fs.Close();
            tbxContent.Text = text;
            tbxName.Text = ofd.FileName.Substring(ofd.FileName.LastIndexOf('\\')+1);
            tbxSize.Text = new FileInfo(ofd.FileName).Length.ToString() + " bytes";
            tbxURL.Text = new FileInfo(ofd.FileName).FullName;
            tbxLine.Text = (text.Length - text.Replace("\r\n", "").Length - 1).ToString();
            tbxWord.Text = (text.Length - text.Replace("\r\n", "").Replace(" ","").Length - 1).ToString();
            tbxChar.Text = text.Length.ToString();
        }

        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) btnRead_Click(this, new EventArgs());
        }
    }
}
