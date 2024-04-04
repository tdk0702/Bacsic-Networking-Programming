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
            
            switch (e.KeyCode)
            {
                case Keys.D1:
                case Keys.NumPad1:
                    cbxChoose.SelectedIndex = 0;
                    break;
                case Keys.D2:
                case Keys.NumPad2:
                    cbxChoose.SelectedIndex = 1;
                    break;
                case Keys.D3:
                case Keys.NumPad3:
                    cbxChoose.SelectedIndex = 2;
                    break;
                case Keys.D4:
                case Keys.NumPad4:
                    cbxChoose.SelectedIndex = 3;
                    break;
                case Keys.D5:
                case Keys.NumPad5:
                    cbxChoose.SelectedIndex = 4;
                    break;
                case Keys.D6:
                case Keys.NumPad6:
                    cbxChoose.SelectedIndex = 5;
                    break;
                case Keys.D7:
                case Keys.NumPad7:
                    cbxChoose.SelectedIndex = 6;
                    break;
            }
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
                    Form6.Menu f6 = new Form6.Menu();
                    f6.Show();
                    break;
                case 6:
                    Form7 f7 = new Form7();
                    f7.Show();
                    break;
                default:
                    MessageBox.Show("Vui lòng chọn câu !");
                    break;
            }
        }
    }
}
