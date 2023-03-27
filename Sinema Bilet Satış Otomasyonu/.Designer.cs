namespace Sinema_Bilet_Satış_Otomasyonu
{
    partial class frmAnaSayfa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAnaSayfa));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSalonEkle = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnFilmEkle = new System.Windows.Forms.Button();
            this.btnSeansEkle = new System.Windows.Forms.Button();
            this.btnSeansListe = new System.Windows.Forms.Button();
            this.btnÇıkış = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboFilmAdi = new System.Windows.Forms.ComboBox();
            this.comboÜcret = new System.Windows.Forms.ComboBox();
            this.comboFilmSeansi = new System.Windows.Forms.ComboBox();
            this.comboFilmTarihi = new System.Windows.Forms.ComboBox();
            this.comboSalonAdi = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnBiletSat = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.comboBiletİptal = new System.Windows.Forms.ComboBox();
            this.btnBiletİptal = new System.Windows.Forms.Button();
            this.txtKoltukNo = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnSatislar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.film_BilgileriTableAdapter1 = new Sinema_Bilet_Satış_Otomasyonu.sinemaTableAdapters.Film_BilgileriTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Location = new System.Drawing.Point(115, 181);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(543, 367);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(699, 219);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(229, 267);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Red;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 367);
            this.label1.TabIndex = 6;
            this.label1.Text = "P\r\n\r\n\r\n\r\n\r\nE\r\n\r\n\r\n\r\n\r\nR\r\n\r\n\r\n\r\n\r\nD\r\n\r\n\r\n\r\n\r\nE";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnSalonEkle
            // 
            this.btnSalonEkle.BackColor = System.Drawing.Color.White;
            this.btnSalonEkle.Font = new System.Drawing.Font("Sitka Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalonEkle.ImageIndex = 1;
            this.btnSalonEkle.ImageList = this.ımageList1;
            this.btnSalonEkle.Location = new System.Drawing.Point(115, 12);
            this.btnSalonEkle.Name = "btnSalonEkle";
            this.btnSalonEkle.Size = new System.Drawing.Size(125, 127);
            this.btnSalonEkle.TabIndex = 0;
            this.btnSalonEkle.Text = "SALON EKLE";
            this.btnSalonEkle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalonEkle.UseVisualStyleBackColor = false;
            this.btnSalonEkle.Click += new System.EventHandler(this.button1_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "film-reel.png");
            this.ımageList1.Images.SetKeyName(1, "cinema.png");
            this.ımageList1.Images.SetKeyName(2, "check-list.png");
            this.ımageList1.Images.SetKeyName(3, "popcorn (1).png");
            this.ımageList1.Images.SetKeyName(4, "popcorn.png");
            this.ımageList1.Images.SetKeyName(5, "power.png");
            this.ımageList1.Images.SetKeyName(6, "salary.png");
            // 
            // btnFilmEkle
            // 
            this.btnFilmEkle.BackColor = System.Drawing.Color.White;
            this.btnFilmEkle.Font = new System.Drawing.Font("Sitka Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilmEkle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnFilmEkle.ImageKey = "film-reel.png";
            this.btnFilmEkle.ImageList = this.ımageList1;
            this.btnFilmEkle.Location = new System.Drawing.Point(255, 12);
            this.btnFilmEkle.Name = "btnFilmEkle";
            this.btnFilmEkle.Size = new System.Drawing.Size(125, 127);
            this.btnFilmEkle.TabIndex = 7;
            this.btnFilmEkle.Text = "FİLM EKLE";
            this.btnFilmEkle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnFilmEkle.UseVisualStyleBackColor = false;
            this.btnFilmEkle.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnSeansEkle
            // 
            this.btnSeansEkle.BackColor = System.Drawing.Color.White;
            this.btnSeansEkle.Font = new System.Drawing.Font("Sitka Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeansEkle.ImageKey = "popcorn (1).png";
            this.btnSeansEkle.ImageList = this.ımageList1;
            this.btnSeansEkle.Location = new System.Drawing.Point(395, 12);
            this.btnSeansEkle.Name = "btnSeansEkle";
            this.btnSeansEkle.Size = new System.Drawing.Size(125, 127);
            this.btnSeansEkle.TabIndex = 8;
            this.btnSeansEkle.Text = "SEANS EKLE";
            this.btnSeansEkle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSeansEkle.UseVisualStyleBackColor = false;
            this.btnSeansEkle.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnSeansListe
            // 
            this.btnSeansListe.BackColor = System.Drawing.Color.White;
            this.btnSeansListe.Font = new System.Drawing.Font("Sitka Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeansListe.ImageKey = "check-list.png";
            this.btnSeansListe.ImageList = this.ımageList1;
            this.btnSeansListe.Location = new System.Drawing.Point(533, 12);
            this.btnSeansListe.Name = "btnSeansListe";
            this.btnSeansListe.Size = new System.Drawing.Size(125, 127);
            this.btnSeansListe.TabIndex = 9;
            this.btnSeansListe.Text = "SEANS LİSTE";
            this.btnSeansListe.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSeansListe.UseVisualStyleBackColor = false;
            this.btnSeansListe.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnÇıkış
            // 
            this.btnÇıkış.BackColor = System.Drawing.Color.White;
            this.btnÇıkış.Font = new System.Drawing.Font("Sitka Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnÇıkış.ImageKey = "power.png";
            this.btnÇıkış.ImageList = this.ımageList1;
            this.btnÇıkış.Location = new System.Drawing.Point(819, 12);
            this.btnÇıkış.Name = "btnÇıkış";
            this.btnÇıkış.Size = new System.Drawing.Size(125, 127);
            this.btnÇıkış.TabIndex = 10;
            this.btnÇıkış.Text = "ÇIKIŞ";
            this.btnÇıkış.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnÇıkış.UseVisualStyleBackColor = false;
            this.btnÇıkış.Click += new System.EventHandler(this.button5_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(983, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 16);
            this.label2.TabIndex = 14;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // comboFilmAdi
            // 
            this.comboFilmAdi.FormattingEnabled = true;
            this.comboFilmAdi.Location = new System.Drawing.Point(1124, 61);
            this.comboFilmAdi.Name = "comboFilmAdi";
            this.comboFilmAdi.Size = new System.Drawing.Size(121, 24);
            this.comboFilmAdi.TabIndex = 17;
            this.comboFilmAdi.SelectedIndexChanged += new System.EventHandler(this.comboFilmAdi_SelectedIndexChanged);
            // 
            // comboÜcret
            // 
            this.comboÜcret.FormattingEnabled = true;
            this.comboÜcret.Location = new System.Drawing.Point(1124, 331);
            this.comboÜcret.Name = "comboÜcret";
            this.comboÜcret.Size = new System.Drawing.Size(121, 24);
            this.comboÜcret.TabIndex = 18;
            this.comboÜcret.SelectedIndexChanged += new System.EventHandler(this.comboÜcret_SelectedIndexChanged);
            // 
            // comboFilmSeansi
            // 
            this.comboFilmSeansi.FormattingEnabled = true;
            this.comboFilmSeansi.Location = new System.Drawing.Point(1124, 173);
            this.comboFilmSeansi.Name = "comboFilmSeansi";
            this.comboFilmSeansi.Size = new System.Drawing.Size(121, 24);
            this.comboFilmSeansi.TabIndex = 19;
            this.comboFilmSeansi.SelectedIndexChanged += new System.EventHandler(this.comboFilmSeansi_SelectedIndexChanged);
            // 
            // comboFilmTarihi
            // 
            this.comboFilmTarihi.FormattingEnabled = true;
            this.comboFilmTarihi.Location = new System.Drawing.Point(1124, 134);
            this.comboFilmTarihi.Name = "comboFilmTarihi";
            this.comboFilmTarihi.Size = new System.Drawing.Size(121, 24);
            this.comboFilmTarihi.TabIndex = 20;
            this.comboFilmTarihi.SelectedIndexChanged += new System.EventHandler(this.comboFilmTarihi_SelectedIndexChanged);
            // 
            // comboSalonAdi
            // 
            this.comboSalonAdi.FormattingEnabled = true;
            this.comboSalonAdi.Location = new System.Drawing.Point(1124, 97);
            this.comboSalonAdi.Name = "comboSalonAdi";
            this.comboSalonAdi.Size = new System.Drawing.Size(121, 24);
            this.comboSalonAdi.TabIndex = 21;
            this.comboSalonAdi.SelectedIndexChanged += new System.EventHandler(this.comboSalonAdi_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(1000, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 16);
            this.label4.TabIndex = 22;
            this.label4.Text = "Film Adı";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(1000, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 16);
            this.label5.TabIndex = 22;
            this.label5.Text = "Salon Adı";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(1000, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 16);
            this.label6.TabIndex = 22;
            this.label6.Text = "Film Tarihi";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(1000, 181);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 16);
            this.label7.TabIndex = 22;
            this.label7.Text = "Film Seansı";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(1000, 219);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 16);
            this.label8.TabIndex = 22;
            this.label8.Text = "Koltuk No";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label9.Location = new System.Drawing.Point(1000, 258);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(24, 16);
            this.label9.TabIndex = 22;
            this.label9.Text = "Ad";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label10.Location = new System.Drawing.Point(1000, 296);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 16);
            this.label10.TabIndex = 22;
            this.label10.Text = "Soyad";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label11.Location = new System.Drawing.Point(1000, 334);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(39, 16);
            this.label11.TabIndex = 22;
            this.label11.Text = "Ücret";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // btnBiletSat
            // 
            this.btnBiletSat.Location = new System.Drawing.Point(173, 392);
            this.btnBiletSat.Name = "btnBiletSat";
            this.btnBiletSat.Size = new System.Drawing.Size(75, 39);
            this.btnBiletSat.TabIndex = 23;
            this.btnBiletSat.Text = "Bilet Sat";
            this.btnBiletSat.UseVisualStyleBackColor = true;
            this.btnBiletSat.Click += new System.EventHandler(this.btnBiletSat_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label13.Location = new System.Drawing.Point(1000, 489);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(64, 16);
            this.label13.TabIndex = 26;
            this.label13.Text = "Koltuk No";
            // 
            // comboBiletİptal
            // 
            this.comboBiletİptal.FormattingEnabled = true;
            this.comboBiletİptal.Location = new System.Drawing.Point(1093, 481);
            this.comboBiletİptal.Name = "comboBiletİptal";
            this.comboBiletİptal.Size = new System.Drawing.Size(161, 24);
            this.comboBiletİptal.TabIndex = 27;
            // 
            // btnBiletİptal
            // 
            this.btnBiletİptal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnBiletİptal.ForeColor = System.Drawing.Color.White;
            this.btnBiletİptal.Location = new System.Drawing.Point(184, 64);
            this.btnBiletİptal.Name = "btnBiletİptal";
            this.btnBiletİptal.Size = new System.Drawing.Size(90, 37);
            this.btnBiletİptal.TabIndex = 28;
            this.btnBiletİptal.Text = "Bilet İptal";
            this.btnBiletİptal.UseVisualStyleBackColor = false;
            this.btnBiletİptal.Click += new System.EventHandler(this.btnBiletİptal_Click);
            // 
            // txtKoltukNo
            // 
            this.txtKoltukNo.Enabled = false;
            this.txtKoltukNo.Location = new System.Drawing.Point(1124, 209);
            this.txtKoltukNo.Multiline = true;
            this.txtKoltukNo.Name = "txtKoltukNo";
            this.txtKoltukNo.Size = new System.Drawing.Size(121, 26);
            this.txtKoltukNo.TabIndex = 29;
            this.txtKoltukNo.TextChanged += new System.EventHandler(this.txtKoltukNo_TextChanged);
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(1124, 248);
            this.txtAd.Multiline = true;
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(121, 26);
            this.txtAd.TabIndex = 30;
            this.txtAd.TextChanged += new System.EventHandler(this.txtAd_TextChanged);
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(1124, 286);
            this.txtSoyad.Multiline = true;
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(121, 26);
            this.txtSoyad.TabIndex = 31;
            this.txtSoyad.TextChanged += new System.EventHandler(this.txtSoyad_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label14.Location = new System.Drawing.Point(758, 173);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(112, 25);
            this.label14.TabIndex = 32;
            this.label14.Text = "FİLM AFİŞİ";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Location = new System.Drawing.Point(115, 576);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1165, 85);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label16.Location = new System.Drawing.Point(150, 38);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(192, 25);
            this.label16.TabIndex = 34;
            this.label16.Text = "DOLU KOLTUKLAR";
            this.label16.Click += new System.EventHandler(this.label16_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Red;
            this.label17.Location = new System.Drawing.Point(81, 31);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(34, 32);
            this.label17.TabIndex = 35;
            this.label17.Text = "         \r\n         ";
            this.label17.Click += new System.EventHandler(this.label17_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.Location = new System.Drawing.Point(744, 31);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(180, 25);
            this.label15.TabIndex = 33;
            this.label15.Text = "BOŞ KOLTUKLAR";
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label18.Location = new System.Drawing.Point(672, 24);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(34, 32);
            this.label18.TabIndex = 36;
            this.label18.Text = "         \r\n         ";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.txtMail);
            this.groupBox2.Controls.Add(this.btnBiletSat);
            this.groupBox2.Location = new System.Drawing.Point(971, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(309, 431);
            this.groupBox2.TabIndex = 34;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bilet Satış İşlemleri";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label12.Location = new System.Drawing.Point(29, 368);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(73, 16);
            this.label12.TabIndex = 25;
            this.label12.Text = "Mail adresi";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(153, 360);
            this.txtMail.Multiline = true;
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(121, 24);
            this.txtMail.TabIndex = 24;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnBiletİptal);
            this.groupBox3.Location = new System.Drawing.Point(971, 447);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(309, 123);
            this.groupBox3.TabIndex = 35;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Bilet İptal";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // btnSatislar
            // 
            this.btnSatislar.BackColor = System.Drawing.Color.White;
            this.btnSatislar.Font = new System.Drawing.Font("Sitka Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSatislar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSatislar.ImageKey = "salary.png";
            this.btnSatislar.ImageList = this.ımageList1;
            this.btnSatislar.Location = new System.Drawing.Point(677, 12);
            this.btnSatislar.Name = "btnSatislar";
            this.btnSatislar.Size = new System.Drawing.Size(125, 127);
            this.btnSatislar.TabIndex = 36;
            this.btnSatislar.Text = "SATIŞLAR";
            this.btnSatislar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSatislar.UseVisualStyleBackColor = false;
            this.btnSatislar.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Brown;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1381, 158);
            this.panel2.TabIndex = 37;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(887, 511);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(75, 51);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 39;
            this.pictureBox3.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Forte", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(681, 511);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 51);
            this.label3.TabIndex = 38;
            this.label3.Text = "Cinemax";
            // 
            // film_BilgileriTableAdapter1
            // 
            this.film_BilgileriTableAdapter1.ClearBeforeFill = true;
            // 
            // frmAnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1381, 728);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSatislar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.txtKoltukNo);
            this.Controls.Add(this.comboBiletİptal);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboSalonAdi);
            this.Controls.Add(this.comboFilmTarihi);
            this.Controls.Add(this.comboFilmSeansi);
            this.Controls.Add(this.comboÜcret);
            this.Controls.Add(this.comboFilmAdi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnÇıkış);
            this.Controls.Add(this.btnSeansListe);
            this.Controls.Add(this.btnSeansEkle);
            this.Controls.Add(this.btnFilmEkle);
            this.Controls.Add(this.btnSalonEkle);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.panel2);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAnaSayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmAnaSayfa_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSalonEkle;
        private System.Windows.Forms.Button btnFilmEkle;
        private System.Windows.Forms.Button btnSeansEkle;
        private System.Windows.Forms.Button btnSeansListe;
        private System.Windows.Forms.Button btnÇıkış;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboFilmAdi;
        private System.Windows.Forms.ComboBox comboÜcret;
        private System.Windows.Forms.ComboBox comboFilmSeansi;
        private System.Windows.Forms.ComboBox comboFilmTarihi;
        private System.Windows.Forms.ComboBox comboSalonAdi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnBiletSat;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox comboBiletİptal;
        private System.Windows.Forms.Button btnBiletİptal;
        private System.Windows.Forms.TextBox txtKoltukNo;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private sinemaTableAdapters.Film_BilgileriTableAdapter film_BilgileriTableAdapter1;
        private System.Windows.Forms.Button btnSatislar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtMail;
    }
}

