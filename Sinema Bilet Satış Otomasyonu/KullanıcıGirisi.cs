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
    public partial class KullanıcıGirisi : Form
    {
        SqlConnection baglanti = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + AppDomain.CurrentDomain.BaseDirectory + "Sinema_Bileti.mdf;Integrated Security=True");
        public KullanıcıGirisi()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void KullanıcıGirisi_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select* from Kullanici_Girisi where KullaniciAdi='"+textBox1.Text+"'",baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            if (oku.Read())
            {
                if (oku["Sifre"].ToString() == textBox2.Text)
                {
                    MessageBox.Show("Giriş Başarılı...","uyarı");
                    frmAnaSayfa frmAnaSayfa = new frmAnaSayfa();    
                    frmAnaSayfa.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Giriş hatalı tekrar deneyeiniz!!!");
                }

                                
            }
            else
            {
                MessageBox.Show("Giriş hatalı tekrar deneyeiniz!!!");

            }

            baglanti.Close();
            
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
