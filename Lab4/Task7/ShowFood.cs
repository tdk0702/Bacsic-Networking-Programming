﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task7
{
    public partial class ShowFood : Form
    {
        public ShowFood(Control selectedControl)
        {
            InitializeComponent();
            flp.Controls.Add(selectedControl);
        }
    }
}
