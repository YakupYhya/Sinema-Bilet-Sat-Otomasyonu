using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sinema_Bilet_Satış_Otomasyonu
{
    public partial class frmSalonEkle : Form
    {
        public frmSalonEkle()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + AppDomain.CurrentDomain.BaseDirectory + "Sinema_Bileti.mdf;Integrated Security=True");

        sinemaTableAdapters.Salon_BilgileriTableAdapter salon = new sinemaTableAdapters.Salon_BilgileriTableAdapter();
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                salon.SalonEkleme(textBox1.Text);
                MessageBox.Show("Salon Eklendi ", "Kayıt");
            }
            catch (SqlException ex)
            {

                MessageBox.Show("Aynı salonu daha önce eklediniz!!! "," Uyarı");
            }
            textBox1.Text = "";
            comboBox1.Items.Clear();
            ekle();
            
            

        }

        private void frmSalonEkle_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmAnaSayfa frmAnaSayfa = new frmAnaSayfa();
            frmAnaSayfa.Show();
            
            
        }

        private void frmSalonEkle_Load(object sender, EventArgs e)
        {
            ekle();
            // TODO: This line of code loads data into the 'sinema.Salon_Bilgileri' table. You can move, or remove it, as needed.
            this.salon_BilgileriTableAdapter.salonlistesi(this.sinema.Salon_Bilgileri);
            // TODO: This line of code loads data into the 'sinema.Satis_Bilgileri' table. You can move, or remove it, as needed.
            this.satis_BilgileriTableAdapter.SatışListesi(this.sinema.Satis_Bilgileri);

        }
        private void ekle()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from salon_bilgileri ", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                comboBox1.Items.Add(oku["salonadi"].ToString());
            }
            baglanti.Close();
        }

        private void frmSalonEkle_FormClosed(object sender, FormClosedEventArgs e)
        {
            

           
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
         
        }


        private void button2_Click(object sender, EventArgs e)
        {
            sinemaTableAdapters.Salon_BilgileriTableAdapter salon = new sinemaTableAdapters.Salon_BilgileriTableAdapter();
            salon.Salon_Sil(comboBox1.Text);
            comboBox1.Items.Clear();
            ekle();
            comboBox1.Text="";

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_2(object sender, EventArgs e)
        {

        }
    }
}
