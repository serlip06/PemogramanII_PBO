namespace P5_4_714220023
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
            this.textNama = new System.Windows.Forms.TextBox();
            this.cb_jeniskelamin = new System.Windows.Forms.ComboBox();
            this.dtp_tanggal = new System.Windows.Forms.DateTimePicker();
            this.gb_pilihankelas = new System.Windows.Forms.GroupBox();
            this.cb_Komposer = new System.Windows.Forms.CheckBox();
            this.cb_Vokal = new System.Windows.Forms.CheckBox();
            this.cb_Drum = new System.Windows.Forms.CheckBox();
            this.cb_Piano = new System.Windows.Forms.CheckBox();
            this.cb_Konduktor = new System.Windows.Forms.CheckBox();
            this.cb_Saxophone = new System.Windows.Forms.CheckBox();
            this.cb_Gitar = new System.Windows.Forms.CheckBox();
            this.cb_Biola = new System.Windows.Forms.CheckBox();
            this.gb_jadwal = new System.Windows.Forms.GroupBox();
            this.rb_Minggu = new System.Windows.Forms.RadioButton();
            this.rb_SabtuMinggu = new System.Windows.Forms.RadioButton();
            this.rb_SelasaKamis = new System.Windows.Forms.RadioButton();
            this.rb_SeninRabu = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.gb_pilihankelas.SuspendLayout();
            this.gb_jadwal.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(163, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nama";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(163, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Jenis Kelamin";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(163, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tanggal Lahir";
            // 
            // textNama
            // 
            this.textNama.Location = new System.Drawing.Point(294, 70);
            this.textNama.Name = "textNama";
            this.textNama.Size = new System.Drawing.Size(200, 20);
            this.textNama.TabIndex = 3;
            // 
            // cb_jeniskelamin
            // 
            this.cb_jeniskelamin.FormattingEnabled = true;
            this.cb_jeniskelamin.Items.AddRange(new object[] {
            "Laki-laki ",
            "Perempuan "});
            this.cb_jeniskelamin.Location = new System.Drawing.Point(294, 105);
            this.cb_jeniskelamin.Name = "cb_jeniskelamin";
            this.cb_jeniskelamin.Size = new System.Drawing.Size(121, 21);
            this.cb_jeniskelamin.TabIndex = 6;
            // 
            // dtp_tanggal
            // 
            this.dtp_tanggal.Location = new System.Drawing.Point(294, 142);
            this.dtp_tanggal.Name = "dtp_tanggal";
            this.dtp_tanggal.Size = new System.Drawing.Size(200, 20);
            this.dtp_tanggal.TabIndex = 7;
            // 
            // gb_pilihankelas
            // 
            this.gb_pilihankelas.Controls.Add(this.cb_Komposer);
            this.gb_pilihankelas.Controls.Add(this.cb_Vokal);
            this.gb_pilihankelas.Controls.Add(this.cb_Drum);
            this.gb_pilihankelas.Controls.Add(this.cb_Piano);
            this.gb_pilihankelas.Controls.Add(this.cb_Konduktor);
            this.gb_pilihankelas.Controls.Add(this.cb_Saxophone);
            this.gb_pilihankelas.Controls.Add(this.cb_Gitar);
            this.gb_pilihankelas.Controls.Add(this.cb_Biola);
            this.gb_pilihankelas.Location = new System.Drawing.Point(99, 188);
            this.gb_pilihankelas.Name = "gb_pilihankelas";
            this.gb_pilihankelas.Size = new System.Drawing.Size(238, 150);
            this.gb_pilihankelas.TabIndex = 8;
            this.gb_pilihankelas.TabStop = false;
            this.gb_pilihankelas.Text = "Pilihan Kelas";
            // 
            // cb_Komposer
            // 
            this.cb_Komposer.AutoSize = true;
            this.cb_Komposer.Location = new System.Drawing.Point(128, 103);
            this.cb_Komposer.Name = "cb_Komposer";
            this.cb_Komposer.Size = new System.Drawing.Size(73, 17);
            this.cb_Komposer.TabIndex = 7;
            this.cb_Komposer.Text = "Komposer";
            this.cb_Komposer.UseVisualStyleBackColor = true;
            // 
            // cb_Vokal
            // 
            this.cb_Vokal.AutoSize = true;
            this.cb_Vokal.Location = new System.Drawing.Point(128, 79);
            this.cb_Vokal.Name = "cb_Vokal";
            this.cb_Vokal.Size = new System.Drawing.Size(53, 17);
            this.cb_Vokal.TabIndex = 6;
            this.cb_Vokal.Text = "Vokal";
            this.cb_Vokal.UseVisualStyleBackColor = true;
            // 
            // cb_Drum
            // 
            this.cb_Drum.AutoSize = true;
            this.cb_Drum.Location = new System.Drawing.Point(128, 55);
            this.cb_Drum.Name = "cb_Drum";
            this.cb_Drum.Size = new System.Drawing.Size(51, 17);
            this.cb_Drum.TabIndex = 5;
            this.cb_Drum.Text = "Drum";
            this.cb_Drum.UseVisualStyleBackColor = true;
            // 
            // cb_Piano
            // 
            this.cb_Piano.AutoSize = true;
            this.cb_Piano.Location = new System.Drawing.Point(128, 31);
            this.cb_Piano.Name = "cb_Piano";
            this.cb_Piano.Size = new System.Drawing.Size(53, 17);
            this.cb_Piano.TabIndex = 4;
            this.cb_Piano.Text = "Piano";
            this.cb_Piano.UseVisualStyleBackColor = true;
            // 
            // cb_Konduktor
            // 
            this.cb_Konduktor.AutoSize = true;
            this.cb_Konduktor.Location = new System.Drawing.Point(7, 103);
            this.cb_Konduktor.Name = "cb_Konduktor";
            this.cb_Konduktor.Size = new System.Drawing.Size(75, 17);
            this.cb_Konduktor.TabIndex = 3;
            this.cb_Konduktor.Text = "Konduktor";
            this.cb_Konduktor.UseVisualStyleBackColor = true;
            // 
            // cb_Saxophone
            // 
            this.cb_Saxophone.AutoSize = true;
            this.cb_Saxophone.Location = new System.Drawing.Point(7, 79);
            this.cb_Saxophone.Name = "cb_Saxophone";
            this.cb_Saxophone.Size = new System.Drawing.Size(80, 17);
            this.cb_Saxophone.TabIndex = 2;
            this.cb_Saxophone.Text = "Saxophone";
            this.cb_Saxophone.UseVisualStyleBackColor = true;
            // 
            // cb_Gitar
            // 
            this.cb_Gitar.AutoSize = true;
            this.cb_Gitar.Location = new System.Drawing.Point(7, 55);
            this.cb_Gitar.Name = "cb_Gitar";
            this.cb_Gitar.Size = new System.Drawing.Size(48, 17);
            this.cb_Gitar.TabIndex = 1;
            this.cb_Gitar.Text = "Gitar";
            this.cb_Gitar.UseVisualStyleBackColor = true;
            // 
            // cb_Biola
            // 
            this.cb_Biola.AutoSize = true;
            this.cb_Biola.Location = new System.Drawing.Point(7, 31);
            this.cb_Biola.Name = "cb_Biola";
            this.cb_Biola.Size = new System.Drawing.Size(49, 17);
            this.cb_Biola.TabIndex = 0;
            this.cb_Biola.Text = "Biola";
            this.cb_Biola.UseVisualStyleBackColor = true;
            // 
            // gb_jadwal
            // 
            this.gb_jadwal.Controls.Add(this.rb_Minggu);
            this.gb_jadwal.Controls.Add(this.rb_SabtuMinggu);
            this.gb_jadwal.Controls.Add(this.rb_SelasaKamis);
            this.gb_jadwal.Controls.Add(this.rb_SeninRabu);
            this.gb_jadwal.Location = new System.Drawing.Point(448, 188);
            this.gb_jadwal.Name = "gb_jadwal";
            this.gb_jadwal.Size = new System.Drawing.Size(267, 150);
            this.gb_jadwal.TabIndex = 9;
            this.gb_jadwal.TabStop = false;
            this.gb_jadwal.Text = "Pilihan Jadwal";
            // 
            // rb_Minggu
            // 
            this.rb_Minggu.AutoSize = true;
            this.rb_Minggu.Location = new System.Drawing.Point(19, 112);
            this.rb_Minggu.Name = "rb_Minggu";
            this.rb_Minggu.Size = new System.Drawing.Size(120, 17);
            this.rb_Minggu.TabIndex = 3;
            this.rb_Minggu.TabStop = true;
            this.rb_Minggu.Text = "Minggu,13.00-17.00";
            this.rb_Minggu.UseVisualStyleBackColor = true;
            // 
            // rb_SabtuMinggu
            // 
            this.rb_SabtuMinggu.AutoSize = true;
            this.rb_SabtuMinggu.Location = new System.Drawing.Point(19, 79);
            this.rb_SabtuMinggu.Name = "rb_SabtuMinggu";
            this.rb_SabtuMinggu.Size = new System.Drawing.Size(169, 17);
            this.rb_SabtuMinggu.TabIndex = 2;
            this.rb_SabtuMinggu.TabStop = true;
            this.rb_SabtuMinggu.Text = "Sabtu && Minggu, 09.00 - 11.00";
            this.rb_SabtuMinggu.UseVisualStyleBackColor = true;
            // 
            // rb_SelasaKamis
            // 
            this.rb_SelasaKamis.AutoSize = true;
            this.rb_SelasaKamis.Location = new System.Drawing.Point(19, 55);
            this.rb_SelasaKamis.Name = "rb_SelasaKamis";
            this.rb_SelasaKamis.Size = new System.Drawing.Size(160, 17);
            this.rb_SelasaKamis.TabIndex = 1;
            this.rb_SelasaKamis.TabStop = true;
            this.rb_SelasaKamis.Text = "Selasa && Kamis, 14.00-16.00";
            this.rb_SelasaKamis.UseVisualStyleBackColor = true;
            // 
            // rb_SeninRabu
            // 
            this.rb_SeninRabu.AutoSize = true;
            this.rb_SeninRabu.Location = new System.Drawing.Point(19, 31);
            this.rb_SeninRabu.Name = "rb_SeninRabu";
            this.rb_SeninRabu.Size = new System.Drawing.Size(153, 17);
            this.rb_SeninRabu.TabIndex = 0;
            this.rb_SeninRabu.TabStop = true;
            this.rb_SeninRabu.Text = "Senin && Rabu, 14.00-16.00";
            this.rb_SeninRabu.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button1.Location = new System.Drawing.Point(305, 358);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Tampilkan";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button2.Location = new System.Drawing.Point(448, 358);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Selesai";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label4.Location = new System.Drawing.Point(278, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(201, 24);
            this.label4.TabIndex = 12;
            this.label4.Text = "FORM PENDAFTARAN ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gb_jadwal);
            this.Controls.Add(this.gb_pilihankelas);
            this.Controls.Add(this.dtp_tanggal);
            this.Controls.Add(this.cb_jeniskelamin);
            this.Controls.Add(this.textNama);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "ASTRA MUSIC SCHOOL";
            this.gb_pilihankelas.ResumeLayout(false);
            this.gb_pilihankelas.PerformLayout();
            this.gb_jadwal.ResumeLayout(false);
            this.gb_jadwal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textNama;
        private System.Windows.Forms.ComboBox cb_jeniskelamin;
        private System.Windows.Forms.DateTimePicker dtp_tanggal;
        private System.Windows.Forms.GroupBox gb_pilihankelas;
        private System.Windows.Forms.CheckBox cb_Komposer;
        private System.Windows.Forms.CheckBox cb_Vokal;
        private System.Windows.Forms.CheckBox cb_Drum;
        private System.Windows.Forms.CheckBox cb_Piano;
        private System.Windows.Forms.CheckBox cb_Konduktor;
        private System.Windows.Forms.CheckBox cb_Saxophone;
        private System.Windows.Forms.CheckBox cb_Gitar;
        private System.Windows.Forms.CheckBox cb_Biola;
        private System.Windows.Forms.GroupBox gb_jadwal;
        private System.Windows.Forms.RadioButton rb_Minggu;
        private System.Windows.Forms.RadioButton rb_SabtuMinggu;
        private System.Windows.Forms.RadioButton rb_SelasaKamis;
        private System.Windows.Forms.RadioButton rb_SeninRabu;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
    }
}

