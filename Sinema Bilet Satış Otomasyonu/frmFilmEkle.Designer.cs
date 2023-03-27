namespace Sinema_Bilet_Satış_Otomasyonu
{
    partial class FilmEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FilmEkle));
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFilmAdi = new System.Windows.Forms.TextBox();
            this.txtYonetmen = new System.Windows.Forms.TextBox();
            this.txtSüre = new System.Windows.Forms.TextBox();
            this.btnFilmEkle = new System.Windows.Forms.Button();
            this.btnAfisSec = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.txtYapimYili = new System.Windows.Forms.TextBox();
            this.comboFilmTuru = new System.Windows.Forms.ComboBox();
            this.btnFilmSil = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(96, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 16);
            this.label4.TabIndex = 23;
            this.label4.Text = "Film Adı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(96, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 24;
            this.label1.Text = "Film Türü";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(96, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 16);
            this.label2.TabIndex = 25;
            this.label2.Text = "Süre";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(96, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 16);
            this.label3.TabIndex = 26;
            this.label3.Text = "Yönetmen";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(97, 249);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 16);
            this.label5.TabIndex = 27;
            this.label5.Text = "Yapım Yılı";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtFilmAdi
            // 
            this.txtFilmAdi.Location = new System.Drawing.Point(201, 84);
            this.txtFilmAdi.Multiline = true;
            this.txtFilmAdi.Name = "txtFilmAdi";
            this.txtFilmAdi.Size = new System.Drawing.Size(121, 26);
            this.txtFilmAdi.TabIndex = 30;
            // 
            // txtYonetmen
            // 
            this.txtYonetmen.Location = new System.Drawing.Point(201, 116);
            this.txtYonetmen.Multiline = true;
            this.txtYonetmen.Name = "txtYonetmen";
            this.txtYonetmen.Size = new System.Drawing.Size(121, 26);
            this.txtYonetmen.TabIndex = 31;
            // 
            // txtSüre
            // 
            this.txtSüre.Location = new System.Drawing.Point(201, 179);
            this.txtSüre.Multiline = true;
            this.txtSüre.Name = "txtSüre";
            this.txtSüre.Size = new System.Drawing.Size(121, 26);
            this.txtSüre.TabIndex = 32;
            // 
            // btnFilmEkle
            // 
            this.btnFilmEkle.Location = new System.Drawing.Point(229, 302);
            this.btnFilmEkle.Name = "btnFilmEkle";
            this.btnFilmEkle.Size = new System.Drawing.Size(79, 42);
            this.btnFilmEkle.TabIndex = 35;
            this.btnFilmEkle.Text = "Film Ekle";
            this.btnFilmEkle.UseVisualStyleBackColor = true;
            this.btnFilmEkle.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAfisSec
            // 
            this.btnAfisSec.Location = new System.Drawing.Point(396, 302);
            this.btnAfisSec.Name = "btnAfisSec";
            this.btnAfisSec.Size = new System.Drawing.Size(79, 42);
            this.btnAfisSec.TabIndex = 36;
            this.btnAfisSec.Text = "Afiş Seç";
            this.btnAfisSec.UseVisualStyleBackColor = true;
            this.btnAfisSec.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Location = new System.Drawing.Point(357, 87);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(170, 181);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 37;
            this.pictureBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(201, 215);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(121, 22);
            this.dateTimePicker1.TabIndex = 38;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(96, 221);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 16);
            this.label6.TabIndex = 39;
            this.label6.Text = "Tarih";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtYapimYili
            // 
            this.txtYapimYili.Location = new System.Drawing.Point(201, 243);
            this.txtYapimYili.Multiline = true;
            this.txtYapimYili.Name = "txtYapimYili";
            this.txtYapimYili.Size = new System.Drawing.Size(121, 25);
            this.txtYapimYili.TabIndex = 40;
            // 
            // comboFilmTuru
            // 
            this.comboFilmTuru.FormattingEnabled = true;
            this.comboFilmTuru.Location = new System.Drawing.Point(201, 149);
            this.comboFilmTuru.Name = "comboFilmTuru";
            this.comboFilmTuru.Size = new System.Drawing.Size(121, 24);
            this.comboFilmTuru.TabIndex = 41;
            this.comboFilmTuru.SelectedIndexChanged += new System.EventHandler(this.comboFilmTuru_SelectedIndexChanged);
            // 
            // btnFilmSil
            // 
            this.btnFilmSil.Location = new System.Drawing.Point(659, 87);
            this.btnFilmSil.Name = "btnFilmSil";
            this.btnFilmSil.Size = new System.Drawing.Size(301, 23);
            this.btnFilmSil.TabIndex = 42;
            this.btnFilmSil.Text = "Film Sil";
            this.btnFilmSil.UseVisualStyleBackColor = true;
            this.btnFilmSil.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Location = new System.Drawing.Point(659, 126);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(301, 209);
            this.panel1.TabIndex = 43;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(102, 123);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 35);
            this.button1.TabIndex = 1;
            this.button1.Text = "SİL";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(20, 29);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(260, 24);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // FilmEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1153, 510);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnFilmSil);
            this.Controls.Add(this.comboFilmTuru);
            this.Controls.Add(this.txtYapimYili);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnAfisSec);
            this.Controls.Add(this.btnFilmEkle);
            this.Controls.Add(this.txtSüre);
            this.Controls.Add(this.txtYonetmen);
            this.Controls.Add(this.txtFilmAdi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FilmEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FilmEkle_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FilmEkle_FormClosed);
            this.Load += new System.EventHandler(this.frmFilmEkle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFilmAdi;
        private System.Windows.Forms.TextBox txtYonetmen;
        private System.Windows.Forms.TextBox txtSüre;
        private System.Windows.Forms.Button btnFilmEkle;
        private System.Windows.Forms.Button btnAfisSec;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtYapimYili;
        private System.Windows.Forms.ComboBox comboFilmTuru;
        private System.Windows.Forms.Button btnFilmSil;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
    }
}