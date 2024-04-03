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

namespace Lab2
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void comboBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) btnChoose_Click(this, new EventArgs());
        }

        private void btnChoose_Click(object sender, EventArgs e)
        {
            switch (cbxChoose.SelectedIndex)
            {
                case 0:
                    Form1 f1 = new Form1();
                    f1.Show();
                    break;
                case 1:
                    Form2 f2 = new Form2();
                    f2.Show();
                    break;
                case 2:
                    Form3 f3 = new Form3();
                    f3.Show();
                    break;
                case 3:
                    Form4.FormWrite f4 = new Form4.FormWrite();
                    f4.Show();
                    break;
                case 4:
                    Form5.Home f5 = new Form5.Home();
                    f5.Show();
                    break;
                case 5:
                    //Form6 f = new Form6();
                    //f.Show();
                    break;
                case 6:
                    //Form7 f = new Form7();
                    //f.Show();
                    break;
                default:
                    MessageBox.Show("Vui lòng chọn câu !");
                    break;
            }
        }
    }
}
