﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P5_1_714230060
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void OutputLabel_Click(object sender, EventArgs e)
        {

        }

        private void HelloButton_Click(object sender, EventArgs e)
        {
            OutputLabel.Text = "hello Word";
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();    
        }
    }
}
