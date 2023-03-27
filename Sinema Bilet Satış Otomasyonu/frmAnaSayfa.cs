using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sinema_Bilet_Satış_Otomasyonu
{
    public partial class frmAnaSayfa : Form
    {
        public frmAnaSayfa()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + AppDomain.CurrentDomain.BaseDirectory + "Sinema_Bileti.mdf;Integrated Security=True");
        int sayac = 0;
        private void FilmveSalonGetir(ComboBox combo,string sql,string sql2) 
        {
         baglanti.Open();
            SqlCommand komut = new SqlCommand(sql,baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                combo.Items.Add(read[sql2].ToString());
            }
            baglanti.Close();
        }
        private void FilmAfişiGoster()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select* from film_bilgileri where filmadi='"+comboFilmAdi.SelectedItem+"'",baglanti);
            SqlDataReader read= komut.ExecuteReader();
            while (read.Read())
            {
                pictureBox1.ImageLocation = read["resim"].ToString();
            }
            baglanti.Close();
        }
        private void YenidenRenklendir()
        {
            foreach (Control item in panel1.Controls)
            {
                if(item is Button)
                {
                    item.BackColor = Color.White;
                }
            }
        }
        private void Combo_Dolu_Koltuklar()
        {
            comboBiletİptal.Items.Clear();
            comboBiletİptal.Text = "";
            foreach (Control item in panel1.Controls)
            {
                if (item is Button)
                {
                    if (item.BackColor==Color.Red)
                    {
                        comboBiletİptal.Items.Add(item.Text);
                    }
                }
            }
        }
        private void Veritabani_Dolu_Koltuklar()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from satis_bilgileri where filmadi='" + comboFilmAdi.SelectedItem + "'and salonadi='" + comboSalonAdi.Text + "'and tarih='" + comboFilmTarihi.SelectedItem + "'and saat='" + comboFilmSeansi.SelectedItem + "'", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                foreach (Control item in panel1.Controls)
                {
                    if (item is Button)
                    {


                        if (read["koltukno"].ToString() == item.Text)
                        {
                            item.BackColor = Color.Red;

                        }
                    }
                }
            }
            baglanti.Close();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Boş_Koltuklar();
            FilmveSalonGetir(comboFilmAdi, "select* from film_bilgileri", "filmadi");
            FilmveSalonGetir(comboSalonAdi, "select* from salon_bilgileri", "salonadi");
            
        }

        private void Boş_Koltuklar()
        {

            sayac = 1;
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    Button btn = new Button();
                    btn.Size = new Size(30, 30);
                    btn.BackColor = Color.White;
                   // btn.Image = System.Drawing.Image.FromFile(@"C:\\Users\\MONSTER\\Desktop\\Sinema iconları\\koltuk.png");
                    btn.Location = new Point(j * 30 + 20, i * 30 + 30);
                    btn.Name = sayac.ToString();
                    btn.Text = sayac.ToString();
                    if (j == 4)
                    {
                        continue;
                    }
                    sayac++;
                    this.panel1.Controls.Add(btn);
                    btn.Click += Btn_Click;

                }

            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Button b =(Button)sender;
            if (b.BackColor==Color.White)
            {
                txtKoltukNo.Text = b.Text;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmSalonEkle ekle = new frmSalonEkle();
            ekle.Show();
            this.Hide();
            
        }
        private void button2_Click(object sender, EventArgs e)
        {
            FilmEkle ekle = new FilmEkle();
            ekle.Show();
            this.Hide();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmSeansEkle frmSeansEkle = new frmSeansEkle();
            frmSeansEkle.Show();
            this.Hide();


        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmSeansListeleme frmSatisListeleme = new FrmSeansListeleme();
            frmSatisListeleme.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            SatisListeleme satisListeleme = new SatisListeleme();
            satisListeleme.Show();
            this.Hide();
        }

        private void comboFilmAdi_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboFilmSeansi.Items.Clear();
            comboFilmTarihi.Items.Clear();
            comboSalonAdi.Text = "";
            comboFilmSeansi.Text = "";
            comboFilmTarihi.Text = "";
            foreach (Control item in groupBox1.Controls) if (item is TextBox) item.Text = "";
            FilmAfişiGoster();
            YenidenRenklendir();
            Combo_Dolu_Koltuklar();
        }

        
        private void frmAnaSayfa_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        sinemaTableAdapters.Satis_BilgileriTableAdapter satis =     new sinemaTableAdapters.Satis_BilgileriTableAdapter();
        private void btnBiletSat_Click(object sender, EventArgs e)
        {
            if (txtKoltukNo.Text!="")
            {
                try
                {
                    satis.Satış_Yap(txtKoltukNo.Text, comboSalonAdi.Text, comboFilmAdi.Text, comboFilmTarihi.Text, comboFilmSeansi.Text, txtAd.Text, txtSoyad.Text, comboÜcret.Text, DateTime.Now.ToString());
                    foreach (Control item in groupBox1.Controls) if (item is TextBox) item.Text = "";
                    YenidenRenklendir();
                    Veritabani_Dolu_Koltuklar();
                    Combo_Dolu_Koltuklar();
                    
                }
                catch (Exception hata)
                {
                    MessageBox.Show("Hata oluştu!!!"+hata.Message, "Uyarı");
                } 
            }
            else
            {
                MessageBox.Show("Koltuk seçimi yapmadınız!!!", "Uyarı");

            }
            try
            {
                SmtpClient smtpserver = new SmtpClient();
                MailMessage mail = new MailMessage();
                String tarih = DateTime.Now.ToLongDateString();
                String ben = "info.8290.info@gmail.com";
                String smtpstvr = "smtp.gmail.com";
                String kime = (txtMail.Text);
                String konu = ("Cinemax Fiş");
                String yaz = ("Merhaba,\n" + "Sayın," +txtAd.Text + "\n" + "Bizden " + tarih + " tarihinde bilet satın almışsınız, bilet bilgileriniz aşağıdaki gibidir." + "\n" + "Koltuk no : " + txtKoltukNo.Text + "\n Bilet ücreti: " + comboÜcret.Text+ "\n İyi günler dileriz :)...");
                var client = new SmtpClient()
                {
                    Host = "smtp.gmail.com",
                    Port = 587,
                    Credentials = new NetworkCredential("info.8290.info@gmail.com", "txeacnummdoakjpm"),
                    EnableSsl = true,

                };
                var mailmessage = new MailMessage(ben, kime, konu, yaz);

                client.Send(mailmessage);
                DialogResult bilgi = new DialogResult();
                bilgi = MessageBox.Show("Bilet satın alma işleminiz onaylandı.\n Fiş mail adresinize gönderilmiştir.", "BİLGİ");

            }

            catch (Exception Hata)
            {
                MessageBox.Show("Mesaj gönderme hatası: " + Hata.Message, "UYARI");


            }
            txtMail.Text = "";
            txtAd.Text = "";
            txtSoyad.Text = "";
            comboÜcret.Text = "";
        }


        private void comboFilmTarihi_SelectedIndexChanged(object sender, EventArgs e)
        {
            Film_Seansi_Getir();

        }
        private void Film_Tarihi_Getir()
        {
            comboFilmTarihi.Text = "";
            comboFilmSeansi.Text = "";
            comboFilmTarihi.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select* from seans_bilgileri where filmadi= '"+comboFilmAdi.SelectedItem+"' and salonadi= '"+comboSalonAdi.SelectedItem+"'",baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
              if (DateTime.Parse( read["tarih"].ToString())>= DateTime.Parse(DateTime.Now.ToShortDateString()))
                {
                    if (!comboFilmTarihi.Items.Contains(read["tarih"].ToString()))
                    {
                        comboFilmTarihi.Items.Add(read["tarih"].ToString());

                    }

                }
            }
            baglanti.Close();
        }
        private void comboSalonAdi_SelectedIndexChanged(object sender, EventArgs e)
        {
            Film_Tarihi_Getir();
        }
        private void Film_Seansi_Getir()
        {
            comboFilmSeansi.Text = "";
            comboFilmSeansi.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select* from seans_bilgileri where filmadi= '" + comboFilmAdi.SelectedItem + "' and salonadi= '" + comboSalonAdi.SelectedItem + "' and tarih= '"+comboFilmTarihi.SelectedItem+"'", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                if (DateTime.Parse(read["tarih"].ToString()) == DateTime.Parse(DateTime.Now.ToShortDateString()))
                {
                    if (!comboFilmTarihi.Items.Contains(read["tarih"].ToString()))
                    {
                        if (DateTime.Parse( read["seans"].ToString())>DateTime.Parse(DateTime.Now.ToShortTimeString()))
                        {
                            comboFilmSeansi.Items.Add(read["seans"].ToString());

                        }

                    }

                }
                else if (DateTime.Parse(read["tarih"].ToString()) > DateTime.Parse(DateTime.Now.ToShortDateString()))
                {

                    comboFilmSeansi.Items.Add(read["seans"].ToString());

                }
            }
            baglanti.Close();
        }
        private void comboFilmSeansi_SelectedIndexChanged(object sender, EventArgs e)
        {
            YenidenRenklendir();
            Veritabani_Dolu_Koltuklar();
            Combo_Dolu_Koltuklar();

        }

        private void btnBiletİptal_Click(object sender, EventArgs e)
        {
            if (comboBiletİptal.Text != "")
            {
                try
                {
                    satis.Satış_İptal(comboFilmAdi.Text, comboSalonAdi.Text, comboFilmTarihi.Text, comboFilmSeansi.Text, comboBiletİptal.Text);
                    YenidenRenklendir();
                    Veritabani_Dolu_Koltuklar();
                    Combo_Dolu_Koltuklar();
                }
                catch (Exception hata )
                {
                    MessageBox.Show("Hata oluştu !!!"+hata.Message, "Uyarı");

                }

            }
            else
            {
                MessageBox.Show("Koltuk seçimi yapmadınız !!!","Uyarı");
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboÜcret_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtSoyad_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtKoltukNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void txtAd_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}
