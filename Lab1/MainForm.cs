using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace LTMCB_Lab1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnQuest1_Click(object sender, EventArgs e)
        {
            Form Quest1 = new Quest1();
            Quest1.Show();
        }

        private void btnQuest2_Click(object sender, EventArgs e)
        {
            Form Quest2 = new Quest2();
            Quest2.Show();
        }

        private void btnQuest3_Click(object sender, EventArgs e)
        {
            Form Quest3 = new Quest3();
            Quest3.Show();
        }

        private void btnQuest4_Click(object sender, EventArgs e)
        {

            Form Quest4 = new Quest4();
            Quest4.Show();
        }

        private void btnQuest5_Click(object sender, EventArgs e)
        {
            //Form Quest5 = new Quest5();
            //Quest5.Show();
        }

        private void btnQuest6_Click(object sender, EventArgs e)
        {
            Form Quest6 = new Quest6();
            Quest6.Show();
        }

        private void btnQuest7_Click(object sender, EventArgs e)
        {
            //Form Quest7 = new Quest7();
            //Quest7.Show();
        }

        private void btnQuest8_Click(object sender, EventArgs e)
        {
            //Form Quest8 = new Quest8();
            //Quest8.Show();
        }

        private void btnQuest9_Click(object sender, EventArgs e)
        {
            //Form Quest9 = new Quest5();
            //Quest9.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
        }
    }
}
