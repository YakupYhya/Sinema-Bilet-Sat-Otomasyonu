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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Sinema_Bilet_Satış_Otomasyonu
{
    public partial class SatisListeleme : Form
    {
        public SatisListeleme()
        {

            InitializeComponent();
        }
        sinemaTableAdapters.Satis_BilgileriTableAdapter satislistesi = new sinemaTableAdapters.Satis_BilgileriTableAdapter();
        private void SatısListeleme_Load(object sender, EventArgs e)
        {
           // dataGridView1.DataSource = satislistesi.TariheGoreListele2(dateTimePicker1.Text);
            ToplamUcretHesapla();
        }

        private void ToplamUcretHesapla()
        {
            int ucrettoplami = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                ucrettoplami += Convert.ToInt32(dataGridView1.Rows[i].Cells["ucret"].Value);
            }
            label1.Text = "Toplam Satış = " + ucrettoplami + " TL ";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = satislistesi.SatışListesi2();
            ToplamUcretHesapla();


        }

     

        //private void dateTimePicker1_ValueChanged_1(object sender, EventArgs e)
        //{
        //    tablo.Clear();
        //    SatisListesi("select* from satis_bilgileri where tarih2 like'" + dateTimePicker1.Text + "'");
        //    ToplamUcretHesapla();

        //}
        //SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-9PR031I;Initial Catalog=Sinema_Bileti;Integrated Security=True");
        //DataTable tablo = new DataTable();
        //private void SatisListesi(String sql)
        //{
        //    baglanti.Open();
        //    SqlDataAdapter adtr = new SqlDataAdapter(sql, baglanti);
        //    adtr.Fill(tablo);
        //    dataGridView1.DataSource = tablo;
        //    baglanti.Close();
        //}
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-9PR031I;Initial Catalog=Sinema_Bileti;Integrated Security=True");
        DataTable tablo = new DataTable();
        private void SatisListesi(String sql)
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter(sql, baglanti);
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }
       

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SatisListeleme_FormClosed(object sender, FormClosedEventArgs e)
        {
            
           


        }

        private void SatisListeleme_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmAnaSayfa frmAnaSayfa = new frmAnaSayfa();
            frmAnaSayfa.Show();
        }

        //private void dateTimePicker1_ValueChanged_1(object sender, EventArgs e)
        //{
        //    dataGridView1.DataSource = satislistesi.TariheGoreListele2(dateTimePicker1.Text);
        //    ToplamUcretHesapla();
        //}
    }
}