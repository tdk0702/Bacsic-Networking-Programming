﻿using System;
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
    public partial class ViewSource : Form
    {
        public ViewSource()
        {
            InitializeComponent();
        }

        public void Hienthi(string data)
        {
            richTextBox1.Text = data;
        }
    }
}
