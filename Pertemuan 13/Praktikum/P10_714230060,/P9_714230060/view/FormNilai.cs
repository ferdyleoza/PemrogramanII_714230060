﻿using MySql.Data.MySqlClient;
using P10_714230060;
using P9_714230060.controller;
using P9_714230060.lib;
using P9_714230060.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P9_714230060.view
{
    public partial class FormNilai : Form
    {

        Koneksi koneksi = new Koneksi();
        M_nilai m_nilai = new M_nilai();
        string id_nilai;

        public FormNilai()
        {
            InitializeComponent();
        }

        public void Tampil()
        {
            DataNilai.DataSource = koneksi.ShowData("SELECT id_nilai, matkul,kategori, t_nilai.npm, nama, nilai FROM t_nilai JOIN t_mahasiswa ON t_mahasiswa.npm = t_nilai.npm");

            // Mengubah Nama Kolom Tabel
            DataNilai.Columns[0].HeaderText = "ID";
            DataNilai.Columns[1].HeaderText = "Matkul";
            DataNilai.Columns[2].HeaderText = "Kategori";
            DataNilai.Columns[3].HeaderText = "NPM";
            DataNilai.Columns[4].HeaderText = "Nama";
            DataNilai.Columns[5].HeaderText = "Nilai";
        }


        private void FormNilai_Load(object sender, EventArgs e)
        {
            Tampil();
            GetDataMhs();
        }

        public void GetDataMhs()
        {
            // ambil data NPM dari table (t_mahasiswa) untuk mengisi data pada combobox NPM
            koneksi.OpenConnection();
            MySqlDataReader reader = koneksi.reader("SELECT * FROM t_mahasiswa");
            while (reader.Read())
            {
                int npm = reader.GetInt32("npm");
                checkBoxNPM.Items.Add(npm);
            }
            reader.Close();
            koneksi.CloseConnection();
        }

        private void DataNilai_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id_nilai = DataNilai.Rows[e.RowIndex].Cells[0].Value.ToString();
            checkBoxMatkul.Text = DataNilai.Rows[e.RowIndex].Cells[1].Value.ToString();
            checkBoxKategori.Text = DataNilai.Rows[e.RowIndex].Cells[2].Value.ToString();
            checkBoxNPM.Text = DataNilai.Rows[e.RowIndex].Cells[3].Value.ToString();
            textBoxNilai.Text = DataNilai.Rows[e.RowIndex].Cells[5].Value.ToString();
        }

        private void textBoxCariData_TextChanged(object sender, EventArgs e)
        {
            DataNilai.DataSource = koneksi.ShowData("SELECT id_nilai, matkul, kategori," +
           "t_nilai.npm, nama, nilai " +
               "FROM t_nilai JOIN t_mahasiswa ON t_mahasiswa.npm = t_nilai.npm " +
               "WHERE t_nilai.npm LIKE '%' '" + textBoxCariData.Text + "' '%' " +
               "OR nama LIKE '%' '" + textBoxCariData.Text + "' '%'" +
               "OR matkul LIKE '%' '" + textBoxCariData.Text + "' '%'");
        }


        public void GetNamaMhs()
        {
            //ambil data nama ketika combobox npm dipilih
            koneksi.OpenConnection();
            MySqlDataReader reader = koneksi.reader("SELECT nama FROM t_mahasiswa WHERE npm = '" + checkBoxNPM.Text + "'");
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    textBoxNama.Text = reader.GetString(0);
                }
            }
            reader.Close();
            koneksi.CloseConnection();
        }

        private void checkBoxNPM_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetNamaMhs();
        }

        public void ResetForm()
        {
            checkBoxMatkul.SelectedIndex = -1;
            checkBoxKategori.SelectedIndex = -1;
            checkBoxNPM.SelectedIndex = -1;
            textBoxNilai.Text = "";
            textBoxNama.Text = "";
            textBoxCariData.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ResetForm();
            Tampil();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (checkBoxMatkul.SelectedIndex == -1 || checkBoxKategori.SelectedIndex == -1
                || checkBoxNPM.SelectedIndex == -1 || textBoxNilai.Text == "")
            {
                MessageBox.Show("Data tidak boleh kosong", "Peringatan",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Nilai nilai = new Nilai();
                m_nilai.Matkul = checkBoxMatkul.Text;
                m_nilai.Kategori = checkBoxKategori.Text;
                m_nilai.Npm = checkBoxNPM.Text;
                m_nilai.Nilai = textBoxNilai.Text;
                nilai.Insert(m_nilai);
                ResetForm();
                Tampil();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (checkBoxMatkul.SelectedIndex == -1 || checkBoxKategori.SelectedIndex == -1  
                || checkBoxNPM.SelectedIndex == -1 || textBoxNilai.Text == "")
            {
                MessageBox.Show("Data tidak boleh kosong", "Peringatan",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Nilai nilai = new Nilai();
                m_nilai.Matkul = checkBoxMatkul.Text;
                m_nilai.Kategori = checkBoxKategori.Text;
                m_nilai.Npm = checkBoxNPM.Text;
                m_nilai.Nilai = textBoxNilai.Text;
                nilai.Update(m_nilai, id_nilai);
                ResetForm();
                Tampil();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult pesan = MessageBox.Show("Apakah yakin akan menghapus data ini?","Perhatian", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (pesan == DialogResult.Yes)
            {
                Nilai nilai = new Nilai();
                nilai.Delete(id_nilai);
                ResetForm();
                Tampil();
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Excel Documents (*.xlsx)|*.xlsx";
            save.FileName = "Report Nilai.xlsx";

            if (save.ShowDialog() == DialogResult.OK)
            {
                string directory = Path.GetDirectoryName(save.FileName);
                string fileNameWithoutExt = Path.GetFileNameWithoutExtension(save.FileName);
                string extension = Path.GetExtension(save.FileName);
                int count = 1;
                string filePath = save.FileName;
                while (File.Exists(filePath))
                {
                    filePath = Path.Combine(directory, $"{fileNameWithoutExt} ({count}){extension}");
                    count++;
                }

                // Membuat instance dari kelas Excel
                Exel excel_lib = new Exel();

                // Memanggil metode ExportToExcel
                excel_lib.ExportToExcel(DataNilai, filePath);

                // Notifikasi berhasil
                MessageBox.Show("Data berhasil diekspor ke file Excel.",
                    "Informasi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }
    }
}
