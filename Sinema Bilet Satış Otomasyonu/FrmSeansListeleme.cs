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
    public partial class FrmSeansListeleme : Form
    {
        public FrmSeansListeleme()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + AppDomain.CurrentDomain.BaseDirectory + "Sinema_Bileti.mdf;Integrated Security=True");
        DataTable tablo = new DataTable();
        private void SeansListesi(String sql)
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter(sql,baglanti);
            adtr.Fill(tablo);
            dataGridView1.DataSource= tablo;
            baglanti.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FrmSatisListeleme_Load(object sender, EventArgs e)
        {
            tablo.Clear();
         SeansListesi("select* from seans_bilgileri where tarih like'"+dateTimePicker1.Text+"'");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            tablo.Clear();
            SeansListesi("select* from seans_bilgileri");

        }

       

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            tablo.Clear();
            SeansListesi("select* from seans_bilgileri where tarih like'" + dateTimePicker1.Text + "'");
        }

        private void FrmSeansListeleme_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmAnaSayfa frmAnaSayfa = new frmAnaSayfa();
            frmAnaSayfa.Show();
        }
    }
}
