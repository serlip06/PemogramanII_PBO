namespace P7_1_714220023
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
            this.txtNama = new System.Windows.Forms.TextBox();
            this.txtProdi = new System.Windows.Forms.TextBox();
            this.txtKelas = new System.Windows.Forms.TextBox();
            this.btnOke = new System.Windows.Forms.Button();
            this.btnTutup = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.rbSenin = new System.Windows.Forms.RadioButton();
            this.rbMinggu = new System.Windows.Forms.RadioButton();
            this.cbKuliah = new System.Windows.Forms.CheckBox();
            this.cbTraveling = new System.Windows.Forms.CheckBox();
            this.cbTidur = new System.Windows.Forms.CheckBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nama";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Prodi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kelas";
            // 
            // txtNama
            // 
            this.txtNama.Location = new System.Drawing.Point(103, 63);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(156, 20);
            this.txtNama.TabIndex = 3;
            // 
            // txtProdi
            // 
            this.txtProdi.Location = new System.Drawing.Point(103, 104);
            this.txtProdi.Name = "txtProdi";
            this.txtProdi.Size = new System.Drawing.Size(156, 20);
            this.txtProdi.TabIndex = 4;
            // 
            // txtKelas
            // 
            this.txtKelas.Location = new System.Drawing.Point(103, 143);
            this.txtKelas.Name = "txtKelas";
            this.txtKelas.Size = new System.Drawing.Size(156, 20);
            this.txtKelas.TabIndex = 5;
            // 
            // btnOke
            // 
            this.btnOke.Location = new System.Drawing.Point(85, 169);
            this.btnOke.Name = "btnOke";
            this.btnOke.Size = new System.Drawing.Size(75, 23);
            this.btnOke.TabIndex = 6;
            this.btnOke.Text = "Oke";
            this.btnOke.UseVisualStyleBackColor = true;
            this.btnOke.Click += new System.EventHandler(this.btnOke_Click);
            // 
            // btnTutup
            // 
            this.btnTutup.Location = new System.Drawing.Point(184, 169);
            this.btnTutup.Name = "btnTutup";
            this.btnTutup.Size = new System.Drawing.Size(91, 23);
            this.btnTutup.TabIndex = 7;
            this.btnTutup.Text = "Tutup Pesan";
            this.btnTutup.UseVisualStyleBackColor = true;
            this.btnTutup.Click += new System.EventHandler(this.btnTutup_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(80, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 27);
            this.label4.TabIndex = 8;
            this.label4.Text = "List Kegiatan";
            // 
            // rbSenin
            // 
            this.rbSenin.AutoSize = true;
            this.rbSenin.Location = new System.Drawing.Point(71, 263);
            this.rbSenin.Name = "rbSenin";
            this.rbSenin.Size = new System.Drawing.Size(55, 17);
            this.rbSenin.TabIndex = 9;
            this.rbSenin.TabStop = true;
            this.rbSenin.Text = "Senin ";
            this.rbSenin.UseVisualStyleBackColor = true;
            this.rbSenin.CheckedChanged += new System.EventHandler(this.rbSenin_CheckedChanged);
            // 
            // rbMinggu
            // 
            this.rbMinggu.AutoSize = true;
            this.rbMinggu.Location = new System.Drawing.Point(71, 287);
            this.rbMinggu.Name = "rbMinggu";
            this.rbMinggu.Size = new System.Drawing.Size(60, 17);
            this.rbMinggu.TabIndex = 10;
            this.rbMinggu.TabStop = true;
            this.rbMinggu.Text = "Minggu";
            this.rbMinggu.UseVisualStyleBackColor = true;
            this.rbMinggu.CheckedChanged += new System.EventHandler(this.rbMinggu_CheckedChanged);
            // 
            // cbKuliah
            // 
            this.cbKuliah.AutoSize = true;
            this.cbKuliah.Location = new System.Drawing.Point(71, 325);
            this.cbKuliah.Name = "cbKuliah";
            this.cbKuliah.Size = new System.Drawing.Size(55, 17);
            this.cbKuliah.TabIndex = 11;
            this.cbKuliah.Text = "Kuliah";
            this.cbKuliah.UseVisualStyleBackColor = true;
            // 
            // cbTraveling
            // 
            this.cbTraveling.AutoSize = true;
            this.cbTraveling.Location = new System.Drawing.Point(71, 349);
            this.cbTraveling.Name = "cbTraveling";
            this.cbTraveling.Size = new System.Drawing.Size(70, 17);
            this.cbTraveling.TabIndex = 12;
            this.cbTraveling.Text = "Traveling";
            this.cbTraveling.UseVisualStyleBackColor = true;
            // 
            // cbTidur
            // 
            this.cbTidur.AutoSize = true;
            this.cbTidur.Location = new System.Drawing.Point(71, 372);
            this.cbTidur.Name = "cbTidur";
            this.cbTidur.Size = new System.Drawing.Size(50, 17);
            this.cbTidur.TabIndex = 13;
            this.cbTidur.Text = "Tidur";
            this.cbTidur.UseVisualStyleBackColor = true;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(85, 412);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 14;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(184, 412);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 15;
            this.btnReset.Text = "Reset Form";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 448);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.cbTidur);
            this.Controls.Add(this.cbTraveling);
            this.Controls.Add(this.cbKuliah);
            this.Controls.Add(this.rbMinggu);
            this.Controls.Add(this.rbSenin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnTutup);
            this.Controls.Add(this.btnOke);
            this.Controls.Add(this.txtKelas);
            this.Controls.Add(this.txtProdi);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.TextBox txtProdi;
        private System.Windows.Forms.TextBox txtKelas;
        private System.Windows.Forms.Button btnOke;
        private System.Windows.Forms.Button btnTutup;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rbSenin;
        private System.Windows.Forms.RadioButton rbMinggu;
        private System.Windows.Forms.CheckBox cbKuliah;
        private System.Windows.Forms.CheckBox cbTraveling;
        private System.Windows.Forms.CheckBox cbTidur;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnReset;
    }
}

