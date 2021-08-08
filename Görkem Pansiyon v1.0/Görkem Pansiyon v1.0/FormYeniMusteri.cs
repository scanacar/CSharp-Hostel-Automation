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
    public partial class FormYeniMusteri : Form
    {
        public FormYeniMusteri()
        {
            InitializeComponent();
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            TxtOda.Text = "101";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("INSERT INTO Oda101 (Ad, Soyad) values ('" + TxtAd.Text + "','" + TxtSoyad.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormYeniMusteri_Load(object sender, EventArgs e)
        {
            // ODA-101
            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("SELECT * FROM Oda101", baglanti);
            SqlDataReader oku1 = komut1.ExecuteReader();

            while (oku1.Read())
            {   
                Btn101.Text = oku1["Ad"].ToString() + " " + oku1["Soyad"].ToString();
            }
            baglanti.Close();

            if (Btn101.Text != "101")
            {
                Btn101.Text = "101";
                Btn101.BackColor = Color.Red;
                Btn101.Enabled = false;
            }

            // ODA-102
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("SELECT * FROM Oda102", baglanti);
            SqlDataReader oku2 = komut2.ExecuteReader();

            while (oku2.Read())
            {
                Btn102.Text = oku2["Ad"].ToString() + " " + oku2["Soyad"].ToString();
            }
            baglanti.Close();

            if (Btn102.Text != "102")
            {
                Btn102.Text = "102";
                Btn102.BackColor = Color.Red;
                Btn102.Enabled = false;
            }

            // ODA-103
            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("SELECT * FROM Oda103", baglanti);
            SqlDataReader oku3 = komut3.ExecuteReader();

            while (oku3.Read())
            {
                Btn103.Text = oku3["Ad"].ToString() + " " + oku3["Soyad"].ToString();
            }
            baglanti.Close();

            if (Btn103.Text != "103")
            {
                Btn103.Text = "103";
                Btn103.BackColor = Color.Red;
                Btn103.Enabled = false;
            }

            // ODA-104
            baglanti.Open();
            SqlCommand komut4 = new SqlCommand("SELECT * FROM Oda104", baglanti);
            SqlDataReader oku4 = komut4.ExecuteReader();

            while (oku4.Read())
            {
                Btn104.Text = oku4["Ad"].ToString() + " " + oku4["Soyad"].ToString();
            }
            baglanti.Close();

            if (Btn104.Text != "104")
            {
                Btn104.Text = "104";
                Btn104.BackColor = Color.Red;
                Btn104.Enabled = false;
            }

            // ODA-105
            baglanti.Open();
            SqlCommand komut5 = new SqlCommand("SELECT * FROM Oda105", baglanti);
            SqlDataReader oku5 = komut5.ExecuteReader();

            while (oku5.Read())
            {
                Btn105.Text = oku5["Ad"].ToString() + " " + oku5["Soyad"].ToString();
            }
            baglanti.Close();

            if (Btn105.Text != "105")
            {
                Btn105.Text = "105";
                Btn105.BackColor = Color.Red;
                Btn105.Enabled = false;
            }

            // ODA-106
            baglanti.Open();
            SqlCommand komut6 = new SqlCommand("SELECT * FROM Oda106", baglanti);
            SqlDataReader oku6 = komut6.ExecuteReader();

            while (oku6.Read())
            {
                Btn106.Text = oku6["Ad"].ToString() + " " + oku6["Soyad"].ToString();
            }
            baglanti.Close();

            if (Btn106.Text != "106")
            {
                Btn106.Text = "106";
                Btn106.BackColor = Color.Red;
                Btn106.Enabled = false;
            }

            // ODA-107
            baglanti.Open();
            SqlCommand komut7 = new SqlCommand("SELECT * FROM Oda107", baglanti);
            SqlDataReader oku7 = komut7.ExecuteReader();

            while (oku7.Read())
            {
                Btn107.Text = oku7["Ad"].ToString() + " " + oku7["Soyad"].ToString();
            }
            baglanti.Close();

            if (Btn107.Text != "107")
            {
                Btn107.Text = "107";
                Btn107.BackColor = Color.Red;
                Btn107.Enabled = false;
            }

            // ODA-108
            baglanti.Open();
            SqlCommand komut8 = new SqlCommand("SELECT * FROM Oda108", baglanti);
            SqlDataReader oku8 = komut8.ExecuteReader();

            while (oku8.Read())
            {
                Btn108.Text = oku8["Ad"].ToString() + " " + oku8["Soyad"].ToString();
            }
            baglanti.Close();

            if (Btn108.Text != "108")
            {
                Btn108.Text = "108";
                Btn108.BackColor = Color.Red;
                Btn108.Enabled = false;
            }

            // ODA-109
            baglanti.Open();
            SqlCommand komut9 = new SqlCommand("SELECT * FROM Oda109", baglanti);
            SqlDataReader oku9 = komut9.ExecuteReader();

            while (oku9.Read())
            {
                Btn109.Text = oku9["Ad"].ToString() + " " + oku9["Soyad"].ToString();
            }
            baglanti.Close();

            if (Btn109.Text != "109")
            {
                Btn109.Text = "109";
                Btn109.BackColor = Color.Red;
                Btn109.Enabled = false;
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void Btn102_Click(object sender, EventArgs e)
        {
            TxtOda.Text = "102";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("INSERT INTO Oda102 (Ad, Soyad) values ('" + TxtAd.Text + "','" + TxtSoyad.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void Btn103_Click(object sender, EventArgs e)
        {
            TxtOda.Text = "103";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("INSERT INTO Oda103 (Ad, Soyad) values ('" + TxtAd.Text + "','" + TxtSoyad.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void Btn104_Click(object sender, EventArgs e)
        {
            TxtOda.Text = "104";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("INSERT INTO Oda104 (Ad, Soyad) values ('" + TxtAd.Text + "','" + TxtSoyad.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void Btn105_Click(object sender, EventArgs e)
        {
            TxtOda.Text = "105";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("INSERT INTO Oda105 (Ad, Soyad) values ('" + TxtAd.Text + "','" + TxtSoyad.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void Btn106_Click(object sender, EventArgs e)
        {
            TxtOda.Text = "106";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("INSERT INTO Oda106 (Ad, Soyad) values ('" + TxtAd.Text + "','" + TxtSoyad.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void Btn107_Click(object sender, EventArgs e)
        {
            TxtOda.Text = "107";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("INSERT INTO Oda107 (Ad, Soyad) values ('" + TxtAd.Text + "','" + TxtSoyad.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void Btn108_Click(object sender, EventArgs e)
        {
            TxtOda.Text = "108";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("INSERT INTO Oda108 (Ad, Soyad) values ('" + TxtAd.Text + "','" + TxtSoyad.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void Btn109_Click(object sender, EventArgs e)
        {
            TxtOda.Text = "109";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("INSERT INTO Oda109 (Ad, Soyad) values ('" + TxtAd.Text + "','" + TxtSoyad.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void BtnDolu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kırmızı renkli butonlar dolu odaları gösterir.");
        }

        private void BtnBos_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Yeşil renkli butonlar boş odaları gösterir.");
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void TxtTC_TextChanged(object sender, EventArgs e)
        {

        }

        private void DtpCikis_ValueChanged(object sender, EventArgs e)
        {
            int Ucret;
            DateTime KucukTarih = Convert.ToDateTime(DtpGiris.Text);
            DateTime BuyukTarih = Convert.ToDateTime(DtpCikis.Text);

            TimeSpan Sonuc = BuyukTarih - KucukTarih;

            label11.Text = Sonuc.TotalDays.ToString();

            Ucret = Convert.ToInt32(label11.Text) * 50;

            TxtUcret.Text = Ucret.ToString();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("INSERT INTO MusteriEkle (Ad, Soyad, Cinsiyet, Telefon, Mail, TC, OdaNo, Ucret, " +
                "GirisTarihi, CikisTarihi) values('" + TxtAd.Text + "','" + TxtSoyad.Text + "','" + comboBox1.Text + "','" + 
                MaskTxtTel.Text + "','" + TxtMail.Text + "','" + TxtTC.Text + "','" + TxtOda.Text + "','" + 
                TxtUcret.Text + "','" + DtpGiris.Value.ToString("yyyy-MM-dd") + "','" + DtpCikis.Value.ToString("yyyy-MM-dd") + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Müşteri kaydı yapıldı.");
        }
    }
}
