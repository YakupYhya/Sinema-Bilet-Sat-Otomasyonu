using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sinema_Bilet_Satış_Otomasyonu
{
    public partial class frmSeansEkle : Form
    {
        public frmSeansEkle()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + AppDomain.CurrentDomain.BaseDirectory + "Sinema_Bileti.mdf;Integrated Security=True");

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void FilmveSalonGoster(ComboBox combo,string sql,string sql2)
        {
             baglanti.Open();
            SqlCommand komut = new SqlCommand(sql,baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while(read.Read()== true)
            {
                combo.Items.Add(read[sql2].ToString());
            }
            baglanti.Close();
        }
        string seans = "";
        private void RadioButtonSeciliyse()
        {
         if(radioButton2.Checked== true) seans = radioButton2.Text;
            else if (radioButton2.Checked == true) seans = radioButton2.Text;
            else if (radioButton3.Checked == true) seans = radioButton3.Text;
            else if (radioButton4.Checked == true) seans = radioButton4.Text;
            else if (radioButton5.Checked == true) seans = radioButton5.Text;
            else if (radioButton6.Checked == true) seans = radioButton6.Text;
            else if (radioButton7.Checked == true) seans = radioButton7.Text;
            else if (radioButton8.Checked == true) seans = radioButton8.Text;
            else if (radioButton9.Checked == true) seans = radioButton9.Text;
            else if (radioButton10.Checked == true) seans = radioButton10.Text;
            else if (radioButton11.Checked == true) seans = radioButton11.Text;
            else if (radioButton12.Checked == true) seans = radioButton12.Text;
            else if (radioButton13.Checked == true) seans = radioButton13.Text;



        }

        private void button1_Click(object sender, EventArgs e)
        {
            RadioButtonSeciliyse();
            if (seans!="")
            {
             
                filmseansi.SeansEkleme(comboFilm.Text,comboSalon.Text,dateTimePicker1.Text,seans);
                MessageBox.Show("Seans ekleme işlemi yapıldı.","Kayıt");
                Tarihi_Karşılaştır();
            }
            else if(seans == "")
            {
                MessageBox.Show("Seans seçimi yapmadınız!!!", "Uyarı");

            }
            comboSalon.Text = "";
            comboFilm.Text = "";
            dateTimePicker1.Text = DateTime.Now.ToShortDateString();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        sinemaTableAdapters.Seans_BilgileriTableAdapter filmseansi = new sinemaTableAdapters.Seans_BilgileriTableAdapter();
        private void Form1_Load(object sender, EventArgs e)
        {
            FilmveSalonGoster(comboFilm,"select*from film_bilgileri","filmadi");
            FilmveSalonGoster(comboSalon, "select*from salon_bilgileri", "salonadi");

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {


                DateTime bugün = DateTime.Parse(DateTime.Now.ToShortDateString());
                DateTime yeni = DateTime.Parse(dateTimePicker1.Text);
                if (yeni == bugün)
                {
                    foreach (Control item in groupBox1.Controls)
                    {
                        if (DateTime.Parse(DateTime.Now.ToShortTimeString()) > DateTime.Parse(item.Text))
                        {
                        item.Enabled = false; 
                        }
                    }
                    Tarihi_Karşılaştır();
                }
                else if (yeni > bugün)
                {
                    Tarihi_Karşılaştır();
                }
                else if (yeni < bugün)
                {
                    MessageBox.Show("Geriye Dönüt İşlem Yapılamaz!!!!", "uyarı");
                    dateTimePicker1.Text = DateTime.Now.ToShortDateString();
                }
            
        }

        private void Tarihi_Karşılaştır()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select*from seans_bilgileri where salonadi='" + comboSalon.Text + "'and tarih='" + dateTimePicker1.Text + "'", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read() == true)
            {
                foreach (Control item2 in groupBox1.Controls)
                {
                    if (read["Seans"].ToString() == item2.Text)
                    {
                        item2.Enabled = false;
                    }
                }
            }
            baglanti.Close();
        }

        private void comboSalon_SelectedIndexChanged(object sender, EventArgs e)
        {
            dateTimePicker1.Text = DateTime.Now.ToShortDateString();

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void frmSeansEkle_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void comboFilm_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmSeansEkle_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmAnaSayfa frmAnaSayfa = new frmAnaSayfa();
            frmAnaSayfa.Show();
        }
    }
}
