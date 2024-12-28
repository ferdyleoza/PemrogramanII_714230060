﻿using P10_714230060.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P10_714230060
{
    public partial class Form1 : Form
    {
        Koneksi koneksi = new Koneksi();
        M_mahasiswa m_mhs = new M_mahasiswa();

        public void Tampil()
        {
            //query db get MGS
            DataMahasiswa.DataSource = koneksi.ShowData("SELECT * FROM t_mahasiswa");

            //mengubah nama kolom tabel
            DataMahasiswa.Columns[0].HeaderText = "NPM";
            DataMahasiswa.Columns[0].HeaderText = "Nama";
            DataMahasiswa.Columns[0].HeaderText = "Angkatan";
            DataMahasiswa.Columns[0].HeaderText = "Alamat";
            DataMahasiswa.Columns[0].HeaderText = "Email";
            DataMahasiswa.Columns[0].HeaderText = "No HP";
        }

        public void ResetForm()
        {
            textboxNpm.Text = "";
            textboxNama.Text = "";
            comboBoxAngkatan.SelectedIndex = -1;
            textboxAlamat.Text = "";
            textboxEmail.Text = "";
            textboxNohp.Text = "";
        }



        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Tampil();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (textboxNpm.Text == "" || textboxNama.Text == "" || comboBoxAngkatan.SelectedIndex == -1 || textboxAlamat.Text == "" || textboxEmail.Text == "" || textboxNohp.Text == "")
            {
                MessageBox.Show("Data tidak boleh kosong", "Peringatan",
               MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Mahasiswa mhs = new Mahasiswa();
                m_mhs.Npm = textboxNpm.Text;
                m_mhs.Nama = textboxNama.Text;
                m_mhs.Angkatan = comboBoxAngkatan.Text;
                m_mhs.Alamat = textboxAlamat.Text;
                m_mhs.Email = textboxEmail.Text;
                m_mhs.Nohp = textboxNohp.Text;

                mhs.Insert(m_mhs);

                ResetForm();
                Tampil();
            }
        }

        private void textboxNpm_TextChanged(object sender, EventArgs e)
        {

        }

        private void DataMahasiswa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textboxNpm.Text = DataMahasiswa.Rows[e.RowIndex].Cells[0].Value.ToString();
            textboxNama.Text = DataMahasiswa.Rows[e.RowIndex].Cells[1].Value.ToString();
            comboBoxAngkatan.Text = DataMahasiswa.Rows[e.RowIndex].Cells[2].Value.ToString();
            textboxAlamat.Text = DataMahasiswa.Rows[e.RowIndex].Cells[3].Value.ToString();
            textboxEmail.Text = DataMahasiswa.Rows[e.RowIndex].Cells[4].Value.ToString();
            textboxNohp.Text = DataMahasiswa.Rows[e.RowIndex].Cells[5].Value.ToString();
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            DialogResult pesan = MessageBox.Show(
               "Apakah yakin akan menghapus data ini?",
               "Perhatian",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Question);

            if (pesan == DialogResult.Yes)
            {
                Mahasiswa mhs = new Mahasiswa();
                mhs.Delete(textboxNpm.Text);
                ResetForm();
                Tampil();
            }
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            if (textboxNpm.Text == "" || textboxNama.Text == "" || comboBoxAngkatan.SelectedIndex == -1 || textboxAlamat.Text == "" || textboxEmail.Text == "" || textboxNohp.Text == "")
            {
                MessageBox.Show("Data tidak boleh kosong", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Mahasiswa mhs = new Mahasiswa();
                M_mahasiswa m_mhs = new M_mahasiswa();

                // Isi properti model M_mahasiswa dengan data dari form
                m_mhs.Npm = textboxNpm.Text;
                m_mhs.Nama = textboxNama.Text;
                m_mhs.Angkatan = comboBoxAngkatan.Text;
                m_mhs.Alamat = textboxAlamat.Text;
                m_mhs.Email = textboxEmail.Text;
                m_mhs.Nohp = textboxNohp.Text;

                // Panggil metode Update dengan parameter yang benar
                bool result = mhs.Update(m_mhs, textboxNpm.Text);

                if (result)
                {
                    MessageBox.Show("Data berhasil diubah!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                ResetForm(); // Bersihkan form
                Tampil();    // Refresh tampilan data
            }
        }
    }
}
