using P_11_714230060.controller;
using P_11_714230060.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P_11_714230060
{
    public partial class Form1 : Form
    {


        Koneksi koneksi = new Koneksi();
        M_mahasiswa m_mhs = new M_mahasiswa();
        public void Tampil()
        {
            // Query DB Get MGS
            DataMahasiswa.DataSource = koneksi.ShowData("SELECT * FROM t_mahasiswa");

            // Mengubah Nama Kolom Tabel
            DataMahasiswa.Columns[0].HeaderText = "NPM";
            DataMahasiswa.Columns[1].HeaderText = "Nama";
            DataMahasiswa.Columns[2].HeaderText = "Angkatan";
            DataMahasiswa.Columns[3].HeaderText = "Alamat";
            DataMahasiswa.Columns[4].HeaderText = "Email";
            DataMahasiswa.Columns[5].HeaderText = "No HP";

        }
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //memanggil method Tampil
            Tampil();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (textboxNPM.Text == "" || textboxNama.Text == "" || comboBoxAngkatan.SelectedIndex == -1 || textboxAlamat.Text == "" || textboxEmail.Text == "" || textboxNohp.Text == "")
            {
                MessageBox.Show("Data tidak boleh kosong", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Mahasiswa mhs = new Mahasiswa();
                m_mhs.Npm = textboxNPM.Text;
                m_mhs.Nama = textboxNama.Text;
                m_mhs.Angkatan = comboBoxAngkatan.Text;
                m_mhs.Alamat = textboxAlamat.Text;
                m_mhs.Email = textboxEmail.Text;
                m_mhs.Nohp = textboxNohp.Text;

                mhs.Insert(m_mhs);

                ResetForm();
                Tampil();
            }

            public void ResetForm()
            {
                textboxNPM.Text = "";
                textboxNama.Text = "";
                comboBoxAngkatan.SelectedIndex = -1;
                textboxAlamat.Text = "";
                textboxEmail.Text = "";
                textboxNohp.Text = "";
                textboxCariData.Text = "";
            }
        }
    }
}
