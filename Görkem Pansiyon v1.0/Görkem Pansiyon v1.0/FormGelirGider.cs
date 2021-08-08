using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Görkem_Pansiyon_v1._0
{
    public partial class FormGelirGider : Form
    {
        public FormGelirGider()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int personel;
            personel = Convert.ToInt16(textBox1.Text);
            LblPersonelMaas.Text = (personel * 1500).ToString();

            int sonuc;
            sonuc = Convert.ToInt32(LblKasaToplam.Text) - Convert.ToInt32(LblPersonelMaas.Text) -
                Convert.ToInt32(LblAlinanTutar.Text) - Convert.ToInt32(LblFatura.Text);

            LblSonuc.Text = sonuc.ToString();
        }

        private void FormGelirGider_Load(object sender, EventArgs e)
        {
            // Kasadaki Toplam Tutar
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("SELECT SUM(Ucret) AS toplam FROM MusteriEkle", baglanti);
            SqlDataReader read = cmd.ExecuteReader();

            while (read.Read())
            {
                LblKasaToplam.Text = read["toplam"].ToString();
            }
            baglanti.Close();

            // Gıda
            baglanti.Open();
            SqlCommand cmd2 = new SqlCommand("SELECT SUM(Gida) AS toplam1 FROM Stoklar", baglanti);
            SqlDataReader read2 = cmd2.ExecuteReader();

            while (read2.Read())
            {
                LblGida.Text = read2["toplam1"].ToString();
            }
            baglanti.Close();


            // İçecek
            baglanti.Open();
            SqlCommand cmd3 = new SqlCommand("SELECT SUM(Icecek) AS toplam2 FROM Stoklar", baglanti);
            SqlDataReader read3 = cmd3.ExecuteReader();

            while (read3.Read())
            {
                LblIcecek.Text = read3["toplam2"].ToString();
            }
            baglanti.Close();

            // Atıştırmalık
            baglanti.Open();
            SqlCommand cmd4 = new SqlCommand("SELECT SUM(Atistirmalik) AS toplam3 FROM Stoklar", baglanti);
            SqlDataReader read4 = cmd4.ExecuteReader();

            while (read4.Read())
            {
                LblAtistirmalik.Text = read4["toplam3"].ToString();
            }
            baglanti.Close();


            LblAlinanTutar.Text = (Convert.ToInt32(LblGida.Text) + Convert.ToInt32(LblIcecek.Text) +
                Convert.ToInt32(LblAtistirmalik.Text)).ToString();


            // Elektrik
            baglanti.Open();
            SqlCommand cmd5 = new SqlCommand("SELECT SUM(Elektrik) AS toplam4 FROM Faturalar", baglanti);
            SqlDataReader read5 = cmd5.ExecuteReader();

            while (read5.Read())
            {
                LblElektrik.Text = read5["toplam4"].ToString();
            }
            baglanti.Close();

            // Su
            baglanti.Open();
            SqlCommand cmd6 = new SqlCommand("SELECT SUM(Su) AS toplam5 FROM Faturalar", baglanti);
            SqlDataReader read6 = cmd6.ExecuteReader();

            while (read6.Read())
            {
                LblSu.Text = read6["toplam5"].ToString();
            }
            baglanti.Close();

            // Internet
            baglanti.Open();
            SqlCommand cmd7 = new SqlCommand("SELECT SUM(Internet) AS toplam6 FROM Faturalar", baglanti);
            SqlDataReader read7 = cmd7.ExecuteReader();

            while (read7.Read())
            {
                LblInt.Text = read7["toplam6"].ToString();
            }
            baglanti.Close();


            LblFatura.Text = (Convert.ToInt32(LblElektrik.Text) + Convert.ToInt32(LblSu.Text) +
                Convert.ToInt32(LblInt.Text)).ToString();
        }

        private void LblAtistirmalik_Click(object sender, EventArgs e)
        {

        }

        private void LblIcecek_Click(object sender, EventArgs e)
        {

        }
    }
}
