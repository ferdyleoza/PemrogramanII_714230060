using System;
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
    public partial class Form_Pilihan_Matkul : Form
    {
        public Form_Pilihan_Matkul()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                checkBox1.Enabled = true; checkBox1.Checked = false;
                checkBox2.Enabled = false; checkBox2.Checked = false;
                checkBox3.Enabled = false; checkBox3.Checked = false;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            StringBuilder errorMessage = new StringBuilder();

            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                errorMessage.AppendLine("NPM Harus di isi");
            }

            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                errorMessage.AppendLine("Nama Harus di isi");
            }

            if (string.IsNullOrWhiteSpace(textBox4.Text))
            {
                errorMessage.AppendLine("Tahun Akademik Harus di isi");
            }

            if (string.IsNullOrWhiteSpace(textBox5.Text))
            {
                errorMessage.AppendLine("Kelas Harus di isi");
            }

            if (comboBox1.SelectedIndex == -1)
            {
                errorMessage.AppendLine("Program Studi Harus di isi");
            }

            string errorMsg = errorMessage.ToString();

            if (string.IsNullOrEmpty(errorMsg))
            {
                MessageBox.Show(
                    "Lengkap!!",
                    "Informasi Data Submit",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                //Size = new Size(976, 387);
            }
            else
            {
                MessageBox.Show(
                    errorMsg.Trim(),
                    "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Form_Pilihan_Matkul_Load(object sender, EventArgs e)
        {
            InitializeComponent();
            InitializeComponent();
            Size = new Size(976, 387);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            comboBox1.Items.Add("D4 Teknik Informatika");
            comboBox1.Items.Add("D3 Teknik Informatika");
            comboBox1.Text = "--Pilih Jurusan--";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (Control control in Controls)
            {
                if (control is TextBox textBox)
                    textBox.Text = "";
                else if (control is ComboBox comboBox)
                    comboBox.SelectedIndex = -1;
                else if (control is RadioButton radioButton)
                    radioButton.Checked = false;
                else if (control is CheckBox checkBox)
                    checkBox.Checked = false;
            }
            Size = new Size(652, 493);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            MessageBox.Show(
               "Batal",
                "Batal",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string kurikulum = Controls.OfType<RadioButton>()
                .FirstOrDefault(r => r.Checked)?.Text;


            string kegiatan = string.Join(", ",
                Controls.OfType<CheckBox>()
                .Where(cb => cb.Checked)
                .Select(cb => cb.Text));




            MessageBox.Show(
                "NPM: " + textBox1.Text + "\n" +
                "Nama: " + textBox2.Text + "\n" +
                "Alamat: " + textBox3.Text + "\n" +
                "Tahun Akademik: " + textBox4.Text + "\n" +
                "Kelas: " + textBox5.Text + "\n" +
                "Program Studi: " + comboBox1.Text + "\n" +
                "=============================\n" +
                "Kurikulum: " + kurikulum + "\n" +
                "Matakulaih: " + kegiatan + "\n",
                "Informasi data Submit",
                MessageBoxButtons.OK, MessageBoxIcon.Information

                );
        }
    }
}
