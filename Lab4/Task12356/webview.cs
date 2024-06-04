using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task12356
{
    public partial class webview : Form
    {
        public webview()
        {
            InitializeComponent();
            webView2.Source = new Uri("https://www.google.com");
        }
    }
}
