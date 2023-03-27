using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sinema_Bilet_Satış_Otomasyonu
{
    public partial class FilmEkle : Form
    {
        SqlConnection baglanti = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + AppDomain.CurrentDomain.BaseDirectory + "Sinema_Bileti.mdf;Integrated Security=True");

        public FilmEkle()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;
        }
        sinemaTableAdapters.Film_BilgileriTableAdapter film = new sinemaTableAdapters.Film_BilgileriTableAdapter();
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                film.FilmEkleme(txtFilmAdi.Text, txtYonetmen.Text, comboFilmTuru.Text, txtSüre.Text, dateTimePicker1.Text, txtYapimYili.Text,pictureBox1.ImageLocation);
                MessageBox.Show("Film bilgileri eklendi", "Kayıt");

            }
            catch (Exception)
            {

                MessageBox.Show("Bu film önceden eklendi!!!","Uyarı");
            }
            foreach (Control item in Controls) if (item is TextBox) item.Text = "";
            comboFilmTuru.Text = "";
            pictureBox1.Image = null;
            comboBox1.Items.Clear();
            filmEkle();
        }

        private void frmFilmEkle_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void comboFilmTuru_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void FilmEkle_FormClosed(object sender, FormClosedEventArgs e)
        {


        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            panel1.Visible = true;
            filmEkle();
        }
        private void filmEkle()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * from film_bilgileri ",baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                comboBox1.Items.Add(oku["filmadi"].ToString());
            }
            baglanti.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand(" DELETE FROM film_bilgileri where filmadi='"+comboBox1.Text+"' ", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            baglanti.Close();
            comboBox1.Items.Clear();
            filmEkle();
            comboBox1.Text = "";
            panel1.Visible=false;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FilmEkle_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmAnaSayfa frmAnaSayfa = new frmAnaSayfa();
            frmAnaSayfa.Show();
        }
    }
    }

