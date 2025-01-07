namespace P9_714230060.view
{
    partial class FromTransaksiBarang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.DataTransaksiBarang = new System.Windows.Forms.DataGridView();
            this.comboBoxIDBarang = new System.Windows.Forms.ComboBox();
            this.textboxNamaBrg = new System.Windows.Forms.TextBox();
            this.textboxHargaBrg = new System.Windows.Forms.TextBox();
            this.textboxQuantity = new System.Windows.Forms.TextBox();
            this.textboxTotal = new System.Windows.Forms.TextBox();
            this.textboxCariData = new System.Windows.Forms.TextBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.btnUbah = new System.Windows.Forms.Button();
            this.btnHapus = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataTransaksiBarang)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DataTransaksiBarang);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1107, 310);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tabel Transaksi Barang";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.textboxTotal);
            this.groupBox2.Controls.Add(this.textboxQuantity);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Location = new System.Drawing.Point(13, 371);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(679, 332);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Form Transaksi Barang";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.textboxHargaBrg);
            this.groupBox3.Controls.Add(this.textboxNamaBrg);
            this.groupBox3.Controls.Add(this.comboBoxIDBarang);
            this.groupBox3.Location = new System.Drawing.Point(167, 60);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(506, 144);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnHapus);
            this.groupBox4.Controls.Add(this.btnUbah);
            this.groupBox4.Controls.Add(this.btnSimpan);
            this.groupBox4.Controls.Add(this.btnRefresh);
            this.groupBox4.Location = new System.Drawing.Point(698, 477);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(422, 251);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Tombol Action";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.textboxCariData);
            this.groupBox5.Location = new System.Drawing.Point(698, 371);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(422, 100);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Form Pencarian";
            // 
            // DataTransaksiBarang
            // 
            this.DataTransaksiBarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataTransaksiBarang.Location = new System.Drawing.Point(22, 25);
            this.DataTransaksiBarang.Name = "DataTransaksiBarang";
            this.DataTransaksiBarang.RowHeadersWidth = 62;
            this.DataTransaksiBarang.RowTemplate.Height = 28;
            this.DataTransaksiBarang.Size = new System.Drawing.Size(1079, 278);
            this.DataTransaksiBarang.TabIndex = 0;
            this.DataTransaksiBarang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataTransaksiBarang_CellContentClick);
            // 
            // comboBoxIDBarang
            // 
            this.comboBoxIDBarang.FormattingEnabled = true;
            this.comboBoxIDBarang.Location = new System.Drawing.Point(16, 37);
            this.comboBoxIDBarang.Name = "comboBoxIDBarang";
            this.comboBoxIDBarang.Size = new System.Drawing.Size(213, 28);
            this.comboBoxIDBarang.TabIndex = 0;
            this.comboBoxIDBarang.SelectedIndexChanged += new System.EventHandler(this.comboBoxIDBarang_SelectedIndexChanged);
            // 
            // textboxNamaBrg
            // 
            this.textboxNamaBrg.Location = new System.Drawing.Point(16, 104);
            this.textboxNamaBrg.Name = "textboxNamaBrg";
            this.textboxNamaBrg.Size = new System.Drawing.Size(213, 26);
            this.textboxNamaBrg.TabIndex = 1;
            // 
            // textboxHargaBrg
            // 
            this.textboxHargaBrg.Location = new System.Drawing.Point(289, 103);
            this.textboxHargaBrg.Name = "textboxHargaBrg";
            this.textboxHargaBrg.Size = new System.Drawing.Size(211, 26);
            this.textboxHargaBrg.TabIndex = 2;
            // 
            // textboxQuantity
            // 
            this.textboxQuantity.Location = new System.Drawing.Point(183, 243);
            this.textboxQuantity.Name = "textboxQuantity";
            this.textboxQuantity.Size = new System.Drawing.Size(267, 26);
            this.textboxQuantity.TabIndex = 3;
            // 
            // textboxTotal
            // 
            this.textboxTotal.Location = new System.Drawing.Point(183, 284);
            this.textboxTotal.Name = "textboxTotal";
            this.textboxTotal.Size = new System.Drawing.Size(267, 26);
            this.textboxTotal.TabIndex = 4;
            // 
            // textboxCariData
            // 
            this.textboxCariData.Location = new System.Drawing.Point(96, 45);
            this.textboxCariData.Name = "textboxCariData";
            this.textboxCariData.Size = new System.Drawing.Size(320, 26);
            this.textboxCariData.TabIndex = 0;
            this.textboxCariData.TextChanged += new System.EventHandler(this.textboxCariData_TextChanged);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(6, 25);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(410, 38);
            this.btnRefresh.TabIndex = 0;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnSimpan
            // 
            this.btnSimpan.Location = new System.Drawing.Point(6, 81);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(410, 38);
            this.btnSimpan.TabIndex = 1;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = true;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // btnUbah
            // 
            this.btnUbah.Location = new System.Drawing.Point(6, 131);
            this.btnUbah.Name = "btnUbah";
            this.btnUbah.Size = new System.Drawing.Size(410, 38);
            this.btnUbah.TabIndex = 2;
            this.btnUbah.Text = "Ubah";
            this.btnUbah.UseVisualStyleBackColor = true;
            this.btnUbah.Click += new System.EventHandler(this.btnUbah_Click);
            // 
            // btnHapus
            // 
            this.btnHapus.Location = new System.Drawing.Point(6, 188);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(410, 38);
            this.btnHapus.TabIndex = 3;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = true;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "ID Barang";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nama Barang";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(252, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "RP";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(289, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Harga Barang";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Quantity";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 294);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Total";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(126, 289);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "RP";
            // 
            // FromTransaksiBarang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 771);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FromTransaksiBarang";
            this.Text = "FromTransaksiBarang";
            this.Load += new System.EventHandler(this.FromTransaksiBarang_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataTransaksiBarang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView DataTransaksiBarang;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textboxHargaBrg;
        private System.Windows.Forms.TextBox textboxNamaBrg;
        private System.Windows.Forms.ComboBox comboBoxIDBarang;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textboxTotal;
        private System.Windows.Forms.TextBox textboxQuantity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Button btnUbah;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.TextBox textboxCariData;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
    }
}