using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P5_3_714230060
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnTampilkan_Click(object sender, EventArgs e)
        {
            string os = "";
            string status = "";
            if (rb_android.Checked)
            {
                os = "Android";
            }
            else if (rb_ios.Checked == true)
            {
                os = "iOS";
            }
            if (cbYa.Checked == true)
            {
                status = "Ya, sudah di perbaiki";
            }
            else if (cbYa.Checked != true) 
            {
                status = "belum di perbaiki";
            }
            MessageBox.Show(
                "Merk HP: " + txtMerkHP.Text+
                "\nSistem Operasi : " + os +
                "\nSistem Perbaikan : " + status,
                "Informasi service HP",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
