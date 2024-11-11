namespace P5_4_714230060
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.SeninRabu = new System.Windows.Forms.RadioButton();
            this.SelasaKamis = new System.Windows.Forms.RadioButton();
            this.SabtuMinggu = new System.Windows.Forms.RadioButton();
            this.Minggu = new System.Windows.Forms.RadioButton();
            this.SepakBola = new System.Windows.Forms.CheckBox();
            this.Renang = new System.Windows.Forms.CheckBox();
            this.Tenis = new System.Windows.Forms.CheckBox();
            this.Yoga = new System.Windows.Forms.CheckBox();
            this.Basket = new System.Windows.Forms.CheckBox();
            this.BuluTangkis = new System.Windows.Forms.CheckBox();
            this.Voli = new System.Windows.Forms.CheckBox();
            this.Panahan = new System.Windows.Forms.CheckBox();
            this.Tampilan = new System.Windows.Forms.Button();
            this.Selesai = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(181, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nama";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(181, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Jenis Kelamin";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(181, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tanggal Lahir";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(459, 39);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(202, 26);
            this.textBox1.TabIndex = 3;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(459, 85);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 28);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(459, 146);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 26);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Panahan);
            this.groupBox1.Controls.Add(this.Voli);
            this.groupBox1.Controls.Add(this.BuluTangkis);
            this.groupBox1.Controls.Add(this.Basket);
            this.groupBox1.Controls.Add(this.Yoga);
            this.groupBox1.Controls.Add(this.Tenis);
            this.groupBox1.Controls.Add(this.Renang);
            this.groupBox1.Controls.Add(this.SepakBola);
            this.groupBox1.Location = new System.Drawing.Point(104, 210);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(337, 210);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pilihan Kelas";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Minggu);
            this.groupBox2.Controls.Add(this.SabtuMinggu);
            this.groupBox2.Controls.Add(this.SelasaKamis);
            this.groupBox2.Controls.Add(this.SeninRabu);
            this.groupBox2.Location = new System.Drawing.Point(509, 210);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(322, 210);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pilihan Jadwal";
            // 
            // SeninRabu
            // 
            this.SeninRabu.AutoSize = true;
            this.SeninRabu.Location = new System.Drawing.Point(26, 42);
            this.SeninRabu.Name = "SeninRabu";
            this.SeninRabu.Size = new System.Drawing.Size(244, 24);
            this.SeninRabu.TabIndex = 0;
            this.SeninRabu.TabStop = true;
            this.SeninRabu.Text = "Senin s/d Rabu, 14.00 - 16.00";
            this.SeninRabu.UseVisualStyleBackColor = true;
            // 
            // SelasaKamis
            // 
            this.SelasaKamis.AutoSize = true;
            this.SelasaKamis.Location = new System.Drawing.Point(24, 81);
            this.SelasaKamis.Name = "SelasaKamis";
            this.SelasaKamis.Size = new System.Drawing.Size(256, 24);
            this.SelasaKamis.TabIndex = 1;
            this.SelasaKamis.TabStop = true;
            this.SelasaKamis.Text = "Selasa s/d Kamis, 14.00 - 16.00";
            this.SelasaKamis.UseVisualStyleBackColor = true;
            // 
            // SabtuMinggu
            // 
            this.SabtuMinggu.AutoSize = true;
            this.SabtuMinggu.Location = new System.Drawing.Point(26, 120);
            this.SabtuMinggu.Name = "SabtuMinggu";
            this.SabtuMinggu.Size = new System.Drawing.Size(259, 24);
            this.SabtuMinggu.TabIndex = 2;
            this.SabtuMinggu.TabStop = true;
            this.SabtuMinggu.Text = "Sabtu s/d Minggu, 09.00 - 11.00";
            this.SabtuMinggu.UseVisualStyleBackColor = true;
            // 
            // Minggu
            // 
            this.Minggu.AutoSize = true;
            this.Minggu.Location = new System.Drawing.Point(26, 159);
            this.Minggu.Name = "Minggu";
            this.Minggu.Size = new System.Drawing.Size(191, 24);
            this.Minggu.TabIndex = 3;
            this.Minggu.TabStop = true;
            this.Minggu.Text = "Minggu, 13.00 - 20.00 ";
            this.Minggu.UseVisualStyleBackColor = true;
            // 
            // SepakBola
            // 
            this.SepakBola.AutoSize = true;
            this.SepakBola.Location = new System.Drawing.Point(23, 43);
            this.SepakBola.Name = "SepakBola";
            this.SepakBola.Size = new System.Drawing.Size(117, 24);
            this.SepakBola.TabIndex = 0;
            this.SepakBola.Text = "Sepak Bola";
            this.SepakBola.UseVisualStyleBackColor = true;
            // 
            // Renang
            // 
            this.Renang.AutoSize = true;
            this.Renang.Location = new System.Drawing.Point(23, 91);
            this.Renang.Name = "Renang";
            this.Renang.Size = new System.Drawing.Size(92, 24);
            this.Renang.TabIndex = 1;
            this.Renang.Text = "Renang";
            this.Renang.UseVisualStyleBackColor = true;
            // 
            // Tenis
            // 
            this.Tenis.AutoSize = true;
            this.Tenis.Location = new System.Drawing.Point(23, 132);
            this.Tenis.Name = "Tenis";
            this.Tenis.Size = new System.Drawing.Size(73, 24);
            this.Tenis.TabIndex = 2;
            this.Tenis.Text = "Tenis";
            this.Tenis.UseVisualStyleBackColor = true;
            // 
            // Yoga
            // 
            this.Yoga.AutoSize = true;
            this.Yoga.Location = new System.Drawing.Point(23, 175);
            this.Yoga.Name = "Yoga";
            this.Yoga.Size = new System.Drawing.Size(73, 24);
            this.Yoga.TabIndex = 3;
            this.Yoga.Text = "Yoga";
            this.Yoga.UseVisualStyleBackColor = true;
            // 
            // Basket
            // 
            this.Basket.AutoSize = true;
            this.Basket.Location = new System.Drawing.Point(165, 42);
            this.Basket.Name = "Basket";
            this.Basket.Size = new System.Drawing.Size(85, 24);
            this.Basket.TabIndex = 4;
            this.Basket.Text = "Basket";
            this.Basket.UseVisualStyleBackColor = true;
            // 
            // BuluTangkis
            // 
            this.BuluTangkis.AutoSize = true;
            this.BuluTangkis.Location = new System.Drawing.Point(165, 91);
            this.BuluTangkis.Name = "BuluTangkis";
            this.BuluTangkis.Size = new System.Drawing.Size(126, 24);
            this.BuluTangkis.TabIndex = 5;
            this.BuluTangkis.Text = "Bulu Tangkis";
            this.BuluTangkis.UseVisualStyleBackColor = true;
            this.BuluTangkis.CheckedChanged += new System.EventHandler(this.checkBox6_CheckedChanged);
            // 
            // Voli
            // 
            this.Voli.AutoSize = true;
            this.Voli.Location = new System.Drawing.Point(165, 132);
            this.Voli.Name = "Voli";
            this.Voli.Size = new System.Drawing.Size(61, 24);
            this.Voli.TabIndex = 6;
            this.Voli.Text = "Voli";
            this.Voli.UseVisualStyleBackColor = true;
            // 
            // Panahan
            // 
            this.Panahan.AutoSize = true;
            this.Panahan.Location = new System.Drawing.Point(165, 175);
            this.Panahan.Name = "Panahan";
            this.Panahan.Size = new System.Drawing.Size(99, 24);
            this.Panahan.TabIndex = 7;
            this.Panahan.Text = "Panahan";
            this.Panahan.UseVisualStyleBackColor = true;
            this.Panahan.CheckedChanged += new System.EventHandler(this.checkBox8_CheckedChanged);
            // 
            // Tampilan
            // 
            this.Tampilan.Location = new System.Drawing.Point(339, 456);
            this.Tampilan.Name = "Tampilan";
            this.Tampilan.Size = new System.Drawing.Size(102, 37);
            this.Tampilan.TabIndex = 8;
            this.Tampilan.Text = "Tampilan";
            this.Tampilan.UseVisualStyleBackColor = true;
            this.Tampilan.Click += new System.EventHandler(this.Tampilan_Click);
            // 
            // Selesai
            // 
            this.Selesai.Location = new System.Drawing.Point(521, 456);
            this.Selesai.Name = "Selesai";
            this.Selesai.Size = new System.Drawing.Size(86, 37);
            this.Selesai.TabIndex = 9;
            this.Selesai.Text = "Selesai";
            this.Selesai.UseVisualStyleBackColor = true;
            this.Selesai.Click += new System.EventHandler(this.Selesai_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 544);
            this.Controls.Add(this.Selesai);
            this.Controls.Add(this.Tampilan);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox Panahan;
        private System.Windows.Forms.CheckBox Voli;
        private System.Windows.Forms.CheckBox BuluTangkis;
        private System.Windows.Forms.CheckBox Basket;
        private System.Windows.Forms.CheckBox Yoga;
        private System.Windows.Forms.CheckBox Tenis;
        private System.Windows.Forms.CheckBox Renang;
        private System.Windows.Forms.CheckBox SepakBola;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton Minggu;
        private System.Windows.Forms.RadioButton SabtuMinggu;
        private System.Windows.Forms.RadioButton SelasaKamis;
        private System.Windows.Forms.RadioButton SeninRabu;
        private System.Windows.Forms.Button Tampilan;
        private System.Windows.Forms.Button Selesai;
    }
}

