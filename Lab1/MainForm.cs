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

        }

        private void btnQuest5_Click(object sender, EventArgs e)
        {

        }

        private void btnQuest6_Click(object sender, EventArgs e)
        {

        }

        private void btnQuest7_Click(object sender, EventArgs e)
        {

        }

        private void btnQuest8_Click(object sender, EventArgs e)
        {

        }

        private void btnQuest9_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
        }
    }
}
