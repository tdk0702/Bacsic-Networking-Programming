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

namespace Lab3
{
    public partial class Menu : Form
    {
        public Menu()
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
                    UDP.Menu_UDP f1 = new UDP.Menu_UDP();
                    f1.Show();
                    break;
                case 1:
                    Form2.Server f2 = new Form2.Server();
                    f2.Show();
                    break;
                case 2:
                    Task3.Menu f3 = new Task3.Menu();
                    f3.Show();
                    break;
                case 3:
                    Theater.Login tt = new Theater.Login();
                    tt.Show();
                    break;
                case 4:
                    RandomFood.Menu f5 = new RandomFood.Menu();
                    f5.Show();
                    break;
                case 5:
                    Task6.Menu f6 = new Task6.Menu();
                    f6.Show();
                    break;
                default:
                    MessageBox.Show("Vui lòng chọn câu !");
                    break;
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            string[] arrItems = { "Câu 1", "Câu 2", "Câu 3", "Câu 4", "Câu 5", "Câu 6" };
            cbxChoose.Items.AddRange(arrItems);
        }
    }
}
