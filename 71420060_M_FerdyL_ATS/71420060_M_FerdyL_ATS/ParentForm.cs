﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _71420060_M_FerdyL_ATS
{
    public partial class ParentForm : Form
    {
        public ParentForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ExitMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NewMenuItem_Click(object sender, EventArgs e)
        {
            Form_Pilihan_Matkul newMatkul = new Form_Pilihan_Matkul();
            newMatkul.MdiParent = this;
            newMatkul.Show();
        }
    }
}
