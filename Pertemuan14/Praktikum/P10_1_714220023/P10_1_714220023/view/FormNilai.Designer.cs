namespace P10_1_714220023.view
{
    partial class FormNilai
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
            this.DataNilai = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbnama = new System.Windows.Forms.TextBox();
            this.tbnilai = new System.Windows.Forms.TextBox();
            this.cbnpm = new System.Windows.Forms.ComboBox();
            this.cbkategori = new System.Windows.Forms.ComboBox();
            this.cbmatkul = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbCariData = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataNilai)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // DataNilai
            // 
            this.DataNilai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataNilai.Location = new System.Drawing.Point(6, 19);
            this.DataNilai.Name = "DataNilai";
            this.DataNilai.Size = new System.Drawing.Size(853, 185);
            this.DataNilai.TabIndex = 0;
            this.DataNilai.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataNilai_CellClick);
            this.DataNilai.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataNilai_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DataNilai);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(876, 220);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tabel Data Nilai";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbnama);
            this.groupBox2.Controls.Add(this.tbnilai);
            this.groupBox2.Controls.Add(this.cbnpm);
            this.groupBox2.Controls.Add(this.cbkategori);
            this.groupBox2.Controls.Add(this.cbmatkul);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(18, 238);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(501, 296);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Form Input Nilai ";
            // 
            // tbnama
            // 
            this.tbnama.Location = new System.Drawing.Point(353, 135);
            this.tbnama.Name = "tbnama";
            this.tbnama.Size = new System.Drawing.Size(142, 20);
            this.tbnama.TabIndex = 8;
            // 
            // tbnilai
            // 
            this.tbnilai.Location = new System.Drawing.Point(94, 182);
            this.tbnilai.Name = "tbnilai";
            this.tbnilai.Size = new System.Drawing.Size(253, 20);
            this.tbnilai.TabIndex = 7;
            // 
            // cbnpm
            // 
            this.cbnpm.FormattingEnabled = true;
            this.cbnpm.Location = new System.Drawing.Point(94, 135);
            this.cbnpm.Name = "cbnpm";
            this.cbnpm.Size = new System.Drawing.Size(253, 21);
            this.cbnpm.TabIndex = 6;
            this.cbnpm.SelectedIndexChanged += new System.EventHandler(this.cbnpm_SelectedIndexChanged);
            // 
            // cbkategori
            // 
            this.cbkategori.FormattingEnabled = true;
            this.cbkategori.Items.AddRange(new object[] {
            "UTS",
            "UAS"});
            this.cbkategori.Location = new System.Drawing.Point(94, 89);
            this.cbkategori.Name = "cbkategori";
            this.cbkategori.Size = new System.Drawing.Size(253, 21);
            this.cbkategori.TabIndex = 5;
            // 
            // cbmatkul
            // 
            this.cbmatkul.FormattingEnabled = true;
            this.cbmatkul.Items.AddRange(new object[] {
            "Pemrograman I",
            "Pemrograman II",
            "Pemrograman III",
            "Pemrograman IV",
            "Literasi Data ",
            "Sistem ERP",
            "RPL",
            "Metologi Penelitian",
            "PKN",
            "General English I"});
            this.cbmatkul.Location = new System.Drawing.Point(94, 46);
            this.cbmatkul.Name = "cbmatkul";
            this.cbmatkul.Size = new System.Drawing.Size(253, 21);
            this.cbmatkul.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nilai";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "NPM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kategori";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Matkul";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnExport);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.tbCariData);
            this.groupBox3.Location = new System.Drawing.Point(525, 239);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(363, 128);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Form Pencarian";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Cari Data";
            // 
            // tbCariData
            // 
            this.tbCariData.Location = new System.Drawing.Point(102, 37);
            this.tbCariData.Name = "tbCariData";
            this.tbCariData.Size = new System.Drawing.Size(244, 20);
            this.tbCariData.TabIndex = 0;
            this.tbCariData.TextChanged += new System.EventHandler(this.tbCariData_TextChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button4);
            this.groupBox4.Controls.Add(this.button3);
            this.groupBox4.Controls.Add(this.button2);
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.Location = new System.Drawing.Point(525, 373);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(363, 161);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Tombol Action";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.button4.Location = new System.Drawing.Point(36, 122);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(310, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "Hapus";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button3.Location = new System.Drawing.Point(36, 93);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(310, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Ubah";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.button2.Location = new System.Drawing.Point(36, 58);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(310, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Simpan";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(36, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(310, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnExport
            // 
            this.btnExport.BackColor = System.Drawing.Color.Green;
            this.btnExport.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnExport.Location = new System.Drawing.Point(102, 75);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(244, 23);
            this.btnExport.TabIndex = 2;
            this.btnExport.Text = "Export Excel";
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // FormNilai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 551);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormNilai";
            this.Text = "FormNilai";
            this.Load += new System.EventHandler(this.FormNilai_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataNilai)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DataNilai;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbnilai;
        private System.Windows.Forms.ComboBox cbnpm;
        private System.Windows.Forms.ComboBox cbkategori;
        private System.Windows.Forms.ComboBox cbmatkul;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbCariData;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbnama;
        private System.Windows.Forms.Button btnExport;
    }
}