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
    public partial class FormMusteriler : Form
    {
        public FormMusteriler()
        {
            InitializeComponent();
        }
        private void verileriGoster()
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT * FROM MusteriEkle", baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while(oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["MusteriId"].ToString();
                ekle.SubItems.Add(oku["Ad"].ToString());
                ekle.SubItems.Add(oku["Soyad"].ToString());
                ekle.SubItems.Add(oku["Cinsiyet"].ToString());
                ekle.SubItems.Add(oku["Telefon"].ToString());
                ekle.SubItems.Add(oku["Mail"].ToString());
                ekle.SubItems.Add(oku["TC"].ToString());
                ekle.SubItems.Add(oku["OdaNo"].ToString());
                ekle.SubItems.Add(oku["Ucret"].ToString());
                ekle.SubItems.Add(oku["GirisTarihi"].ToString());
                ekle.SubItems.Add(oku["CikisTarihi"].ToString());

                listView1.Items.Add(ekle);
            }

            baglanti.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            verileriGoster();
        }

        private void FormMusteriler_Load(object sender, EventArgs e)
        {

        }

        private void TxtSoyad_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtAd_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void MaskTxtTel_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void TxtMail_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtTC_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtOda_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        int id = 0;
        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            TxtAd.Text = listView1.SelectedItems[0].SubItems[1].Text;
            TxtSoyad.Text = listView1.SelectedItems[0].SubItems[2].Text;
            comboBox1.Text = listView1.SelectedItems[0].SubItems[3].Text;
            MaskTxtTel.Text = listView1.SelectedItems[0].SubItems[4].Text;
            TxtMail.Text = listView1.SelectedItems[0].SubItems[5].Text;
            TxtTC.Text = listView1.SelectedItems[0].SubItems[6].Text;
            TxtOda.Text = listView1.SelectedItems[0].SubItems[7].Text;
            TxtUcret.Text = listView1.SelectedItems[0].SubItems[8].Text;
            DtpGiris.Text = listView1.SelectedItems[0].SubItems[9].Text;
            DtpCikis.Text = listView1.SelectedItems[0].SubItems[10].Text;
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {   
            if (TxtOda.Text == "101")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("DELETE FROM Oda101", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verileriGoster();
            }

            else if (TxtOda.Text == "102")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("DELETE FROM Oda102", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verileriGoster();
            }

            else if (TxtOda.Text == "103")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("DELETE FROM Oda103", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verileriGoster();
            }

            else if (TxtOda.Text == "104")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("DELETE FROM Oda104", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verileriGoster();
            }

            else if (TxtOda.Text == "105")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("DELETE FROM Oda105", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verileriGoster();
            }

            else if (TxtOda.Text == "106")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("DELETE FROM Oda106", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verileriGoster();
            }

            else if (TxtOda.Text == "107")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("DELETE FROM Oda107", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verileriGoster();
            }

            else if (TxtOda.Text == "108")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("DELETE FROM Oda108", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verileriGoster();
            }

            else            
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("DELETE FROM Oda109", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verileriGoster();
            }
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            TxtAd.Clear();
            TxtSoyad.Clear();
            comboBox1.Text = "";
            MaskTxtTel.Clear();
            TxtMail.Clear();
            TxtTC.Clear();
            TxtOda.Clear();
            TxtUcret.Clear();
            DtpGiris.Text = "";
            DtpCikis.Text = "";

        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("UPDATE MusteriEkle SET Ad='"+TxtAd.Text+"', " +
                "Soyad='"+TxtSoyad.Text+"', Cinsiyet='"+comboBox1.Text+"', Telefon='" + MaskTxtTel.Text + "', " +
                "Mail='" + TxtMail.Text + "', TC='" + TxtTC.Text + "', OdaNo='" + TxtOda.Text + "', Ucret='" + TxtUcret.Text + "', " +
                "GirisTarihi='" + DtpGiris.Value.ToString("yyyy-MM-dd") + "', CikisTarihi='" + DtpCikis.Value.ToString("yyyy-MM-dd") +
                "' where MusteriId =" +id+"",baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            verileriGoster();
        }

        private void BtnAra_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT * FROM MusteriEkle where Ad like '%" + TxtArama.Text + "%'", baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["MusteriId"].ToString();
                ekle.SubItems.Add(oku["Ad"].ToString());
                ekle.SubItems.Add(oku["Soyad"].ToString());
                ekle.SubItems.Add(oku["Cinsiyet"].ToString());
                ekle.SubItems.Add(oku["Telefon"].ToString());
                ekle.SubItems.Add(oku["Mail"].ToString());
                ekle.SubItems.Add(oku["TC"].ToString());
                ekle.SubItems.Add(oku["OdaNo"].ToString());
                ekle.SubItems.Add(oku["Ucret"].ToString());
                ekle.SubItems.Add(oku["GirisTarihi"].ToString());
                ekle.SubItems.Add(oku["CikisTarihi"].ToString());

                listView1.Items.Add(ekle);
            }

            baglanti.Close();
        }
    }
}