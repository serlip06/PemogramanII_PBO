namespace P6_4_714220023
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.txtTempat = new System.Windows.Forms.TextBox();
            this.dtp_tanggal = new System.Windows.Forms.DateTimePicker();
            this.txtAgama = new System.Windows.Forms.TextBox();
            this.txtHP = new System.Windows.Forms.TextBox();
            this.txtAlamat = new System.Windows.Forms.TextBox();
            this.txtSekolah = new System.Windows.Forms.TextBox();
            this.epWarning = new System.Windows.Forms.ErrorProvider(this.components);
            this.epWrong = new System.Windows.Forms.ErrorProvider(this.components);
            this.epCorrect = new System.Windows.Forms.ErrorProvider(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cb_Matematika = new System.Windows.Forms.CheckBox();
            this.cb_Biologi = new System.Windows.Forms.CheckBox();
            this.cb_fisika = new System.Windows.Forms.CheckBox();
            this.cb_Kimia = new System.Windows.Forms.CheckBox();
            this.cb_Indonesia = new System.Windows.Forms.CheckBox();
            this.rb_SeninRabu = new System.Windows.Forms.RadioButton();
            this.rb_SelasaKamis = new System.Windows.Forms.RadioButton();
            this.rb_JumatSabtu = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.epWarning)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epWrong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCorrect)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(174, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(412, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "FORMULIR PENDAFTARAN LES AKADEMIK ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nama ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tempat";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(76, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Agama";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(76, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "No.HP";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(76, 243);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Alamat";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(74, 286);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Asal Sekolah ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(74, 148);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Tanggal lahir";
            // 
            // txtNama
            // 
            this.txtNama.Location = new System.Drawing.Point(229, 74);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(100, 20);
            this.txtNama.TabIndex = 8;
            this.txtNama.Leave += new System.EventHandler(this.txtNama_Leave);
            // 
            // txtTempat
            // 
            this.txtTempat.Location = new System.Drawing.Point(229, 105);
            this.txtTempat.Name = "txtTempat";
            this.txtTempat.Size = new System.Drawing.Size(100, 20);
            this.txtTempat.TabIndex = 9;
            this.txtTempat.Leave += new System.EventHandler(this.txtTempat_Leave);
            // 
            // dtp_tanggal
            // 
            this.dtp_tanggal.Location = new System.Drawing.Point(229, 141);
            this.dtp_tanggal.Name = "dtp_tanggal";
            this.dtp_tanggal.Size = new System.Drawing.Size(200, 20);
            this.dtp_tanggal.TabIndex = 10;
            // 
            // txtAgama
            // 
            this.txtAgama.Location = new System.Drawing.Point(229, 172);
            this.txtAgama.Name = "txtAgama";
            this.txtAgama.Size = new System.Drawing.Size(100, 20);
            this.txtAgama.TabIndex = 11;
            this.txtAgama.Leave += new System.EventHandler(this.txtAgama_Leave);
            // 
            // txtHP
            // 
            this.txtHP.Location = new System.Drawing.Point(229, 203);
            this.txtHP.Name = "txtHP";
            this.txtHP.Size = new System.Drawing.Size(100, 20);
            this.txtHP.TabIndex = 12;
            this.txtHP.Leave += new System.EventHandler(this.txtHP_Leave);
            // 
            // txtAlamat
            // 
            this.txtAlamat.Location = new System.Drawing.Point(229, 243);
            this.txtAlamat.Name = "txtAlamat";
            this.txtAlamat.Size = new System.Drawing.Size(100, 20);
            this.txtAlamat.TabIndex = 13;
            this.txtAlamat.Leave += new System.EventHandler(this.txtAlamat_Leave);
            // 
            // txtSekolah
            // 
            this.txtSekolah.Location = new System.Drawing.Point(229, 279);
            this.txtSekolah.Name = "txtSekolah";
            this.txtSekolah.Size = new System.Drawing.Size(100, 20);
            this.txtSekolah.TabIndex = 14;
            this.txtSekolah.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            this.txtSekolah.Leave += new System.EventHandler(this.txtSekolah_Leave);
            // 
            // epWarning
            // 
            this.epWarning.ContainerControl = this;
            this.epWarning.Icon = ((System.Drawing.Icon)(resources.GetObject("epWarning.Icon")));
            // 
            // epWrong
            // 
            this.epWrong.ContainerControl = this;
            this.epWrong.Icon = ((System.Drawing.Icon)(resources.GetObject("epWrong.Icon")));
            // 
            // epCorrect
            // 
            this.epCorrect.ContainerControl = this;
            this.epCorrect.Icon = ((System.Drawing.Icon)(resources.GetObject("epCorrect.Icon")));
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(643, 358);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "submit ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cb_Indonesia);
            this.groupBox1.Controls.Add(this.cb_Kimia);
            this.groupBox1.Controls.Add(this.cb_fisika);
            this.groupBox1.Controls.Add(this.cb_Biologi);
            this.groupBox1.Controls.Add(this.cb_Matematika);
            this.groupBox1.Location = new System.Drawing.Point(531, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mata_Pelajaran";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rb_JumatSabtu);
            this.groupBox2.Controls.Add(this.rb_SelasaKamis);
            this.groupBox2.Controls.Add(this.rb_SeninRabu);
            this.groupBox2.Location = new System.Drawing.Point(531, 203);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Jadwal";
            // 
            // cb_Matematika
            // 
            this.cb_Matematika.AutoSize = true;
            this.cb_Matematika.Location = new System.Drawing.Point(7, 20);
            this.cb_Matematika.Name = "cb_Matematika";
            this.cb_Matematika.Size = new System.Drawing.Size(81, 17);
            this.cb_Matematika.TabIndex = 0;
            this.cb_Matematika.Text = "Matematika";
            this.cb_Matematika.UseVisualStyleBackColor = true;
            // 
            // cb_Biologi
            // 
            this.cb_Biologi.AutoSize = true;
            this.cb_Biologi.Location = new System.Drawing.Point(7, 44);
            this.cb_Biologi.Name = "cb_Biologi";
            this.cb_Biologi.Size = new System.Drawing.Size(57, 17);
            this.cb_Biologi.TabIndex = 1;
            this.cb_Biologi.Text = "Biologi";
            this.cb_Biologi.UseVisualStyleBackColor = true;
            // 
            // cb_fisika
            // 
            this.cb_fisika.AutoSize = true;
            this.cb_fisika.Location = new System.Drawing.Point(7, 68);
            this.cb_fisika.Name = "cb_fisika";
            this.cb_fisika.Size = new System.Drawing.Size(53, 17);
            this.cb_fisika.TabIndex = 2;
            this.cb_fisika.Text = "Fisika";
            this.cb_fisika.UseVisualStyleBackColor = true;
            // 
            // cb_Kimia
            // 
            this.cb_Kimia.AutoSize = true;
            this.cb_Kimia.Location = new System.Drawing.Point(112, 20);
            this.cb_Kimia.Name = "cb_Kimia";
            this.cb_Kimia.Size = new System.Drawing.Size(51, 17);
            this.cb_Kimia.TabIndex = 3;
            this.cb_Kimia.Text = "Kimia";
            this.cb_Kimia.UseVisualStyleBackColor = true;
            // 
            // cb_Indonesia
            // 
            this.cb_Indonesia.AutoSize = true;
            this.cb_Indonesia.Location = new System.Drawing.Point(112, 44);
            this.cb_Indonesia.Name = "cb_Indonesia";
            this.cb_Indonesia.Size = new System.Drawing.Size(72, 17);
            this.cb_Indonesia.TabIndex = 4;
            this.cb_Indonesia.Text = "Indonesia";
            this.cb_Indonesia.UseVisualStyleBackColor = true;
            // 
            // rb_SeninRabu
            // 
            this.rb_SeninRabu.AutoSize = true;
            this.rb_SeninRabu.Location = new System.Drawing.Point(7, 20);
            this.rb_SeninRabu.Name = "rb_SeninRabu";
            this.rb_SeninRabu.Size = new System.Drawing.Size(150, 17);
            this.rb_SeninRabu.TabIndex = 0;
            this.rb_SeninRabu.TabStop = true;
            this.rb_SeninRabu.Text = "Senin && Rabu 14.00-17.00";
            this.rb_SeninRabu.UseVisualStyleBackColor = true;
            // 
            // rb_SelasaKamis
            // 
            this.rb_SelasaKamis.AutoSize = true;
            this.rb_SelasaKamis.Location = new System.Drawing.Point(7, 44);
            this.rb_SelasaKamis.Name = "rb_SelasaKamis";
            this.rb_SelasaKamis.Size = new System.Drawing.Size(154, 17);
            this.rb_SelasaKamis.TabIndex = 1;
            this.rb_SelasaKamis.TabStop = true;
            this.rb_SelasaKamis.Text = "Selasa &&Kamis 15.00-19.00";
            this.rb_SelasaKamis.UseVisualStyleBackColor = true;
            // 
            // rb_JumatSabtu
            // 
            this.rb_JumatSabtu.AutoSize = true;
            this.rb_JumatSabtu.Location = new System.Drawing.Point(7, 68);
            this.rb_JumatSabtu.Name = "rb_JumatSabtu";
            this.rb_JumatSabtu.Size = new System.Drawing.Size(153, 17);
            this.rb_JumatSabtu.TabIndex = 2;
            this.rb_JumatSabtu.TabStop = true;
            this.rb_JumatSabtu.Text = "Jumat && Sabtu 09.00-12.00";
            this.rb_JumatSabtu.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtSekolah);
            this.Controls.Add(this.txtAlamat);
            this.Controls.Add(this.txtHP);
            this.Controls.Add(this.txtAgama);
            this.Controls.Add(this.dtp_tanggal);
            this.Controls.Add(this.txtTempat);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.epWarning)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epWrong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCorrect)).EndInit();
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.TextBox txtTempat;
        private System.Windows.Forms.DateTimePicker dtp_tanggal;
        private System.Windows.Forms.TextBox txtAgama;
        private System.Windows.Forms.TextBox txtHP;
        private System.Windows.Forms.TextBox txtAlamat;
        private System.Windows.Forms.TextBox txtSekolah;
        private System.Windows.Forms.ErrorProvider epWarning;
        private System.Windows.Forms.ErrorProvider epWrong;
        private System.Windows.Forms.ErrorProvider epCorrect;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rb_JumatSabtu;
        private System.Windows.Forms.RadioButton rb_SelasaKamis;
        private System.Windows.Forms.RadioButton rb_SeninRabu;
        private System.Windows.Forms.CheckBox cb_Indonesia;
        private System.Windows.Forms.CheckBox cb_Kimia;
        private System.Windows.Forms.CheckBox cb_fisika;
        private System.Windows.Forms.CheckBox cb_Biologi;
        private System.Windows.Forms.CheckBox cb_Matematika;
    }
}

