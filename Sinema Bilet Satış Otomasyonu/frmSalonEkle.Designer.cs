namespace Sinema_Bilet_Satış_Otomasyonu
{
    partial class frmSalonEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSalonEkle));
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.salonBilgileriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sinema = new Sinema_Bilet_Satış_Otomasyonu.sinema();
            this.satisBilgileriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.satis_BilgileriTableAdapter = new Sinema_Bilet_Satış_Otomasyonu.sinemaTableAdapters.Satis_BilgileriTableAdapter();
            this.salon_BilgileriTableAdapter = new Sinema_Bilet_Satış_Otomasyonu.sinemaTableAdapters.Salon_BilgileriTableAdapter();
            this.film_BilgileriTableAdapter1 = new Sinema_Bilet_Satış_Otomasyonu.sinemaTableAdapters.Film_BilgileriTableAdapter();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.salonBilgileriBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinema)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.satisBilgileriBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(55, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Salon Adı :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(179, 60);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(194, 22);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.ImageKey = "cinema.png";
            this.button1.ImageList = this.ımageList1;
            this.button1.Location = new System.Drawing.Point(179, 119);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 46);
            this.button1.TabIndex = 2;
            this.button1.Text = "Salon Ekle";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "cinema.png");
            this.ımageList1.Images.SetKeyName(1, "x-button.png");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(431, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Salon Sil :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.ImageIndex = 1;
            this.button2.ImageList = this.ımageList1;
            this.button2.Location = new System.Drawing.Point(536, 106);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 46);
            this.button2.TabIndex = 5;
            this.button2.Text = "Salon Sil\r\n";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(536, 62);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(194, 24);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // salonBilgileriBindingSource
            // 
            this.salonBilgileriBindingSource.DataMember = "Salon_Bilgileri";
            this.salonBilgileriBindingSource.DataSource = this.sinema;
            // 
            // sinema
            // 
            this.sinema.DataSetName = "sinema";
            this.sinema.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // satisBilgileriBindingSource
            // 
            this.satisBilgileriBindingSource.DataMember = "Satis_Bilgileri";
            this.satisBilgileriBindingSource.DataSource = this.sinema;
            // 
            // satis_BilgileriTableAdapter
            // 
            this.satis_BilgileriTableAdapter.ClearBeforeFill = true;
            // 
            // salon_BilgileriTableAdapter
            // 
            this.salon_BilgileriTableAdapter.ClearBeforeFill = true;
            // 
            // film_BilgileriTableAdapter1
            // 
            this.film_BilgileriTableAdapter1.ClearBeforeFill = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Forte", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Ivory;
            this.label4.Location = new System.Drawing.Point(316, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(200, 51);
            this.label4.TabIndex = 10;
            this.label4.Text = "Cinemax";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(384, 157);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 62);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_2);
            // 
            // frmSalonEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(840, 316);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSalonEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmSalonEkle_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmSalonEkle_FormClosed);
            this.Load += new System.EventHandler(this.frmSalonEkle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.salonBilgileriBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinema)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.satisBilgileriBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox1;
        private sinema sinema;
        private System.Windows.Forms.BindingSource satisBilgileriBindingSource;
        private sinemaTableAdapters.Satis_BilgileriTableAdapter satis_BilgileriTableAdapter;
        private System.Windows.Forms.BindingSource salonBilgileriBindingSource;
        private sinemaTableAdapters.Salon_BilgileriTableAdapter salon_BilgileriTableAdapter;
        private sinemaTableAdapters.Film_BilgileriTableAdapter film_BilgileriTableAdapter1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}