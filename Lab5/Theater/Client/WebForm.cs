using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Theater.Client
{
    public partial class WebForm : Form
    {
        public WebForm()
        {
            InitializeComponent();
        }
        private string URL = string.Empty;
        public WebForm(string url)
        {
            URL = url;
            InitializeComponent();
        }

        private void WebForm_Load(object sender, EventArgs e)
        {
            wvWeb.Source = new Uri(URL);
        }
    }
}
