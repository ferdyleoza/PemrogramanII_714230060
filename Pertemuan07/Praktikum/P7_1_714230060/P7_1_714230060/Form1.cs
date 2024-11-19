using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P7_1_714230060
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Size = new Size(301, 222);
            this.FormBorderStyle = FormBorderStyle.FixedDialog; 
            this.MaximizeBox = false; 
            this.MinimizeBox = false; 
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxAngkatan_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonCek_Click(object sender, EventArgs e)
        {
            StringBuilder errorMessage = new StringBuilder();

            if (string.IsNullOrWhiteSpace(textBoxNama.Text))
            {
                errorMessage.AppendLine("Nama Harus di isi");
            }

            if (comboBoxAngkatan.SelectedIndex == -1)
            {
                errorMessage.AppendLine("Angkatan Harus di isi");
            }

            if (string.IsNullOrWhiteSpace(textBoxKelas.Text))
            {
                errorMessage.AppendLine("Kelas Harus di isi");
            }
            string errorMsg = errorMessage.ToString();

            if (string.IsNullOrEmpty(errorMsg))
            {
               MessageBox.Show(
               "Lengkap!!",
               "Informasi Data Submit",
               MessageBoxButtons.OK, MessageBoxIcon.Information);

               Size = new Size(301, 497);
            }


            else
            {
               MessageBox.Show(
               errorMsg.Trim(),
               "Error",
               MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }  
                
        }

        private void buttonTutup_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radioButtonWeekday_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonWeekday.Checked)
            {
                checkBoxKuliah.Enabled = true;checkBoxKuliah.Checked = false;
                checkBoxTidur.Enabled = true;checkBoxTidur.Checked = false;
                checkBoxLiburan.Enabled = false;checkBoxLiburan.Checked = false;
            }
        }

        private void radioButtonWeekend_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonWeekend.Checked)
            {
                checkBoxKuliah.Enabled = false;checkBoxKuliah.Checked = false;
                checkBoxTidur.Enabled = true;checkBoxTidur.Checked=false;
                checkBoxLiburan.Enabled = true;checkBoxLiburan.Checked=false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string hari = null;
            //string kegiatan = null;

            //foreach (Control control in Controls)
            //{
            //    if (control is  RadioButton radioButton && radioButton.Checked)
            //    {
            //        hari = radioButton.Text;
            //        break;
            //    }
            //}



            //foreach (Control control in Controls)
            //{
            //    if (control is CheckBox checkBox && checkBox.Checked)
            //    {
            //        if (!string.IsNullOrEmpty(kegiatan))
            //        {
            //            kegiatan += ",";
            //        }
            //        kegiatan += checkBox.Text;
            //    }
            //}




         //menggunakanLINQ (LANGUEAGE INTEGRETED QUERY)
         string hari = Controls.OfType<RadioButton>()
                .FirstOrDefault(r => r.Checked)?.Text;


            string kegiatan = string.Join(", ",
                Controls.OfType<CheckBox>()
                .Where(cb => cb.Checked)
                .Select(cb => cb.Text));





            MessageBox.Show(
                "Nama: " + textBoxNama.Text + "\n" +
                "angkatan: " + comboBoxAngkatan.Text + "\n" +
                "Kelas: " + textBoxKelas.Text + "\n" +
                "=============================\n"+
                "Hari: " + hari + "\n" +
                "Kegiatan: " + kegiatan + "\n",
                "Informasi data Submit",
                MessageBoxButtons.OK, MessageBoxIcon.Information

                );
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            //textBoxNama.Text = "";
            //comboBoxAngkatan.SelectedIndex = -1;
            //textBoxKelas.Text = "";

            //radioButtonWeekday.Checked = false;
            //radioButtonWeekend.Checked = false;

            //checkBoxKuliah.Checked = false;
            //checkBoxLiburan.Checked = false;
            //checkBoxTidur.Checked = false;


            foreach (Control control in Controls)
            {
                if (control is TextBox textBox)
                    textBox.Text = "";
                else if (control is ComboBox comboBox)
                    comboBox.SelectedIndex =-1;
                else if (control is RadioButton radioButton)
                    radioButton.Checked = false;
                else if (control is CheckBox checkBox)
                    checkBox.Checked = false;
            }
            Size = new Size(301, 222);
            this.FormBorderStyle = FormBorderStyle.FixedDialog; 
            this.MaximizeBox = false; 
            this.MinimizeBox = false; 

            MessageBox.Show(
               "Berhasi reset",
                "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            
        }
    }
}
