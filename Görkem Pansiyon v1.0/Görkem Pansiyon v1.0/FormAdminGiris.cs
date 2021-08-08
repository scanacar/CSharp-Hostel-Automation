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
    public partial class FormAdminGiris : Form
    {
        public FormAdminGiris()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            baglanti.Open();
            string sql = "SELECT * FROM AdminGiris WHERE Kullanici=@KullaniciAdi AND Sifre=@Sifresi";
            SqlParameter prm1 = new SqlParameter("KullaniciAdi", TxtKullanici.Text);
            SqlParameter prm2 = new SqlParameter("Sifresi", TxtSifre.Text);
            SqlCommand cmd = new SqlCommand(sql, baglanti);
            cmd.Parameters.Add(prm1);
            cmd.Parameters.Add(prm2);

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                FormAnaForm fr = new FormAnaForm();
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Giriş!");
                baglanti.Close();
            }
                
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
