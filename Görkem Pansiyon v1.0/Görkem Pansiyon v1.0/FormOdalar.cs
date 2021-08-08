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
    public partial class FormOdalar : Form
    {
        public FormOdalar()
        {
            InitializeComponent();
        }
        private void BtnDolu_Click(object sender, EventArgs e)
        {

        }

        private void Btn103_Click(object sender, EventArgs e)
        {

        }

        private void Btn106_Click(object sender, EventArgs e)
        {

        }

        private void Btn109_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void FormOdalar_Load(object sender, EventArgs e)
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
                Btn101.BackColor = Color.Red;
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
                Btn102.BackColor = Color.Red;
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
                Btn103.BackColor = Color.Red;
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
                Btn104.BackColor = Color.Red;
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
                Btn105.BackColor = Color.Red;
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
                Btn106.BackColor = Color.Red;
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
                Btn107.BackColor = Color.Red;
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
                Btn108.BackColor = Color.Red;
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
                Btn109.BackColor = Color.Red;
            }
        }
    }
}
