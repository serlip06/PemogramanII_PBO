﻿namespace P10_1_714220023
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.angkatan = new System.Windows.Forms.ComboBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.btnUbah = new System.Windows.Forms.Button();
            this.btnHapus = new System.Windows.Forms.Button();
            this.npm = new System.Windows.Forms.TextBox();
            this.alamat = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.nohp = new System.Windows.Forms.TextBox();
            this.nama = new System.Windows.Forms.TextBox();
            this.DataMahasiswa = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataMahasiswa)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DataMahasiswa);
            this.groupBox1.Location = new System.Drawing.Point(33, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(658, 181);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Table Data Mahasiswa";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.nama);
            this.groupBox2.Controls.Add(this.nohp);
            this.groupBox2.Controls.Add(this.email);
            this.groupBox2.Controls.Add(this.alamat);
            this.groupBox2.Controls.Add(this.angkatan);
            this.groupBox2.Controls.Add(this.npm);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(33, 211);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(320, 272);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Form Data Mahasiswa";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnHapus);
            this.groupBox3.Controls.Add(this.btnRefresh);
            this.groupBox3.Controls.Add(this.btnUbah);
            this.groupBox3.Controls.Add(this.btnSimpan);
            this.groupBox3.Location = new System.Drawing.Point(395, 261);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(308, 210);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tombol Action";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "NPM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nama";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Angkatan";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Alamat";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "No. Hp";
            // 
            // angkatan
            // 
            this.angkatan.FormattingEnabled = true;
            this.angkatan.Location = new System.Drawing.Point(88, 91);
            this.angkatan.Name = "angkatan";
            this.angkatan.Size = new System.Drawing.Size(172, 21);
            this.angkatan.TabIndex = 8;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(22, 43);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(267, 23);
            this.btnRefresh.TabIndex = 9;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // btnSimpan
            // 
            this.btnSimpan.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnSimpan.Location = new System.Drawing.Point(22, 89);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(267, 23);
            this.btnSimpan.TabIndex = 10;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = false;
            // 
            // btnUbah
            // 
            this.btnUbah.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnUbah.Location = new System.Drawing.Point(22, 131);
            this.btnUbah.Name = "btnUbah";
            this.btnUbah.Size = new System.Drawing.Size(258, 23);
            this.btnUbah.TabIndex = 11;
            this.btnUbah.Text = "Ubah";
            this.btnUbah.UseVisualStyleBackColor = false;
            // 
            // btnHapus
            // 
            this.btnHapus.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnHapus.Location = new System.Drawing.Point(22, 178);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(258, 23);
            this.btnHapus.TabIndex = 12;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = false;
            // 
            // npm
            // 
            this.npm.Location = new System.Drawing.Point(88, 27);
            this.npm.Name = "npm";
            this.npm.Size = new System.Drawing.Size(172, 20);
            this.npm.TabIndex = 8;
            // 
            // alamat
            // 
            this.alamat.Location = new System.Drawing.Point(88, 134);
            this.alamat.Multiline = true;
            this.alamat.Name = "alamat";
            this.alamat.Size = new System.Drawing.Size(172, 41);
            this.alamat.TabIndex = 9;
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(88, 198);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(172, 20);
            this.email.TabIndex = 10;
            // 
            // nohp
            // 
            this.nohp.Location = new System.Drawing.Point(88, 226);
            this.nohp.Name = "nohp";
            this.nohp.Size = new System.Drawing.Size(172, 20);
            this.nohp.TabIndex = 11;
            // 
            // nama
            // 
            this.nama.Location = new System.Drawing.Point(88, 60);
            this.nama.Name = "nama";
            this.nama.Size = new System.Drawing.Size(172, 20);
            this.nama.TabIndex = 12;
            // 
            // DataMahasiswa
            // 
            this.DataMahasiswa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataMahasiswa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataMahasiswa.Location = new System.Drawing.Point(22, 19);
            this.DataMahasiswa.Name = "DataMahasiswa";
            this.DataMahasiswa.Size = new System.Drawing.Size(625, 150);
            this.DataMahasiswa.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 495);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataMahasiswa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox angkatan;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Button btnUbah;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.TextBox nama;
        private System.Windows.Forms.TextBox nohp;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.TextBox alamat;
        private System.Windows.Forms.TextBox npm;
        private System.Windows.Forms.DataGridView DataMahasiswa;
    }
}

