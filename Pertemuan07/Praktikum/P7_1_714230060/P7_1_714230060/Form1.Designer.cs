﻿namespace P7_1_714230060
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
            this.textBoxNama = new System.Windows.Forms.TextBox();
            this.textBoxKelas = new System.Windows.Forms.TextBox();
            this.comboBoxAngkatan = new System.Windows.Forms.ComboBox();
            this.buttonCek = new System.Windows.Forms.Button();
            this.buttonTutup = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.radioButtonWeekday = new System.Windows.Forms.RadioButton();
            this.radioButtonWeekend = new System.Windows.Forms.RadioButton();
            this.checkBoxKuliah = new System.Windows.Forms.CheckBox();
            this.checkBoxTidur = new System.Windows.Forms.CheckBox();
            this.checkBoxLiburan = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nama";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Angkatan";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kelas";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBoxNama
            // 
            this.textBoxNama.Location = new System.Drawing.Point(152, 6);
            this.textBoxNama.Name = "textBoxNama";
            this.textBoxNama.Size = new System.Drawing.Size(247, 26);
            this.textBoxNama.TabIndex = 3;
            this.textBoxNama.Text = "1";
            this.textBoxNama.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBoxKelas
            // 
            this.textBoxKelas.Location = new System.Drawing.Point(152, 102);
            this.textBoxKelas.Multiline = true;
            this.textBoxKelas.Name = "textBoxKelas";
            this.textBoxKelas.Size = new System.Drawing.Size(247, 112);
            this.textBoxKelas.TabIndex = 4;
            // 
            // comboBoxAngkatan
            // 
            this.comboBoxAngkatan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAngkatan.FormattingEnabled = true;
            this.comboBoxAngkatan.Items.AddRange(new object[] {
            "2020",
            "2021",
            "2022",
            "2023",
            "2024"});
            this.comboBoxAngkatan.Location = new System.Drawing.Point(152, 54);
            this.comboBoxAngkatan.Name = "comboBoxAngkatan";
            this.comboBoxAngkatan.Size = new System.Drawing.Size(247, 28);
            this.comboBoxAngkatan.TabIndex = 5;
            this.comboBoxAngkatan.SelectedIndexChanged += new System.EventHandler(this.comboBoxAngkatan_SelectedIndexChanged);
            // 
            // buttonCek
            // 
            this.buttonCek.Location = new System.Drawing.Point(152, 238);
            this.buttonCek.Name = "buttonCek";
            this.buttonCek.Size = new System.Drawing.Size(75, 29);
            this.buttonCek.TabIndex = 6;
            this.buttonCek.Text = "Cek";
            this.buttonCek.UseVisualStyleBackColor = true;
            this.buttonCek.Click += new System.EventHandler(this.buttonCek_Click);
            // 
            // buttonTutup
            // 
            this.buttonTutup.Location = new System.Drawing.Point(292, 238);
            this.buttonTutup.Name = "buttonTutup";
            this.buttonTutup.Size = new System.Drawing.Size(75, 29);
            this.buttonTutup.TabIndex = 7;
            this.buttonTutup.Text = "Tutup";
            this.buttonTutup.UseVisualStyleBackColor = true;
            this.buttonTutup.Click += new System.EventHandler(this.buttonTutup_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(146, 302);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 32);
            this.label4.TabIndex = 8;
            this.label4.Text = "KEGIATAN";
            // 
            // radioButtonWeekday
            // 
            this.radioButtonWeekday.AutoSize = true;
            this.radioButtonWeekday.Location = new System.Drawing.Point(16, 355);
            this.radioButtonWeekday.Name = "radioButtonWeekday";
            this.radioButtonWeekday.Size = new System.Drawing.Size(124, 24);
            this.radioButtonWeekday.TabIndex = 9;
            this.radioButtonWeekday.TabStop = true;
            this.radioButtonWeekday.Text = "Senin-Jumat";
            this.radioButtonWeekday.UseVisualStyleBackColor = true;
            this.radioButtonWeekday.CheckedChanged += new System.EventHandler(this.radioButtonWeekday_CheckedChanged);
            // 
            // radioButtonWeekend
            // 
            this.radioButtonWeekend.AutoSize = true;
            this.radioButtonWeekend.Location = new System.Drawing.Point(16, 402);
            this.radioButtonWeekend.Name = "radioButtonWeekend";
            this.radioButtonWeekend.Size = new System.Drawing.Size(138, 24);
            this.radioButtonWeekend.TabIndex = 10;
            this.radioButtonWeekend.TabStop = true;
            this.radioButtonWeekend.Text = "Sabtu -Minggu";
            this.radioButtonWeekend.UseVisualStyleBackColor = true;
            this.radioButtonWeekend.CheckedChanged += new System.EventHandler(this.radioButtonWeekend_CheckedChanged);
            // 
            // checkBoxKuliah
            // 
            this.checkBoxKuliah.AutoSize = true;
            this.checkBoxKuliah.Location = new System.Drawing.Point(16, 486);
            this.checkBoxKuliah.Name = "checkBoxKuliah";
            this.checkBoxKuliah.Size = new System.Drawing.Size(78, 24);
            this.checkBoxKuliah.TabIndex = 11;
            this.checkBoxKuliah.Text = "Kuliah";
            this.checkBoxKuliah.UseVisualStyleBackColor = true;
            // 
            // checkBoxTidur
            // 
            this.checkBoxTidur.AutoSize = true;
            this.checkBoxTidur.Location = new System.Drawing.Point(16, 538);
            this.checkBoxTidur.Name = "checkBoxTidur";
            this.checkBoxTidur.Size = new System.Drawing.Size(70, 24);
            this.checkBoxTidur.TabIndex = 12;
            this.checkBoxTidur.Text = "Tidur";
            this.checkBoxTidur.UseVisualStyleBackColor = true;
            // 
            // checkBoxLiburan
            // 
            this.checkBoxLiburan.AutoSize = true;
            this.checkBoxLiburan.Location = new System.Drawing.Point(16, 585);
            this.checkBoxLiburan.Name = "checkBoxLiburan";
            this.checkBoxLiburan.Size = new System.Drawing.Size(88, 24);
            this.checkBoxLiburan.TabIndex = 13;
            this.checkBoxLiburan.Text = "Liburan";
            this.checkBoxLiburan.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(152, 640);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 35);
            this.button1.TabIndex = 14;
            this.button1.Text = "Cetak";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(273, 640);
            this.buttonReset.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(112, 35);
            this.buttonReset.TabIndex = 15;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 705);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkBoxLiburan);
            this.Controls.Add(this.checkBoxTidur);
            this.Controls.Add(this.checkBoxKuliah);
            this.Controls.Add(this.radioButtonWeekend);
            this.Controls.Add(this.radioButtonWeekday);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonTutup);
            this.Controls.Add(this.buttonCek);
            this.Controls.Add(this.comboBoxAngkatan);
            this.Controls.Add(this.textBoxKelas);
            this.Controls.Add(this.textBoxNama);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxNama;
        private System.Windows.Forms.TextBox textBoxKelas;
        private System.Windows.Forms.ComboBox comboBoxAngkatan;
        private System.Windows.Forms.Button buttonCek;
        private System.Windows.Forms.Button buttonTutup;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radioButtonWeekday;
        private System.Windows.Forms.RadioButton radioButtonWeekend;
        private System.Windows.Forms.CheckBox checkBoxKuliah;
        private System.Windows.Forms.CheckBox checkBoxTidur;
        private System.Windows.Forms.CheckBox checkBoxLiburan;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonReset;
    }
}

