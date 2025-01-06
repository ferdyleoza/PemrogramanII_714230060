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

namespace P_11_714230060.view
{
    public partial class FormBarang : Form
    {

        Koneksi koneksi = new Koneksi();
        M_barang m_barang = new M_barang();
        Barang barang = new Barang();
        string id_barang;


        public FormBarang()
        {
            InitializeComponent();
        }

        public FormBarang(string id_barang)
        {
            this.id_barang = id_barang;
        }


        private void FormBarang_Load(object sender, EventArgs e)
        {
            Tampil();
        }

        public void Tampil()
        {
            DataBarang.DataSource = koneksi.ShowData("SELECT * FROM t_barang");
            DataBarang.Columns[0].HeaderText = "ID";
            DataBarang.Columns[1].HeaderText = "Nama Barang";
            DataBarang.Columns[2].HeaderText = "Harga";
        }
        public void Reset()
        {
            textboxNamaBarang.Text = "";
            textboxHarga.Text = "";
            textboxID.Text = "";
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Reset();
            Tampil();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (textboxNamaBarang.Text == "" || textboxHarga.Text == "")
            {
                MessageBox.Show("Data tidak boleh kosong", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                m_barang.Nama_barang = textboxNamaBarang.Text;
                m_barang.Harga = textboxHarga.Text;
                barang.Insert(m_barang);
                Reset();
                Tampil();
            }
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            if (textboxNamaBarang.Text == "" || textboxHarga.Text == "")
            {
                MessageBox.Show("Data tidak boleh kosong", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                m_barang.Nama_barang = textboxNamaBarang.Text;
                m_barang.Harga = textboxHarga.Text;
                barang.Update(m_barang, textboxID.Text);
                Reset();
                Tampil();
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            DialogResult pesan = MessageBox.Show("Apakah anda yakin ingin menghapus data ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (pesan == DialogResult.Yes)
            {
                barang.Delete(textboxID.Text);
                Reset();
                Tampil();
            }
        }

        private void textboxCariData_TextChanged(object sender, EventArgs e)
        {
            DataMahasiswa.DataSource = koneksi.ShowData("SELECT * FROM t_mahasiswa WHERE npm LIKE '%" + textboxCariData.Text + "%' OR nama LIKE '%" + textboxCariData.Text + "%'");

        }
    }
}
