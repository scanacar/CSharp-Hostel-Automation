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
    public partial class FormStoklar : Form
    {
        public FormStoklar()
        {
            InitializeComponent();
        }
        private void FormStoklar_Load(object sender, EventArgs e)
        {
            veriler();
            veriler2();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO Stoklar(Gida, Icecek, Atistirmalik) values( '" +TxtGidalar.Text+ "','" + TxtIcecekler.Text + "','" + TxtAtistirmalik.Text + "')", baglanti);
            cmd.ExecuteNonQuery();
            baglanti.Close();
            veriler();
        }

        private void veriler()
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Stoklar", baglanti);
            SqlDataReader read = cmd.ExecuteReader();
            while (read.Read())
            {
                ListViewItem add = new ListViewItem();
                add.Text = read["Gida"].ToString();
                add.SubItems.Add(read["Icecek"].ToString());
                add.SubItems.Add(read["Atistirmalik"].ToString());
                listView1.Items.Add(add);
            }
            baglanti.Close();
        }

        private void veriler2()
        {
            listView2.Items.Clear();
            baglanti.Open();
            SqlCommand cmd2 = new SqlCommand("SELECT * FROM Faturalar", baglanti);
            SqlDataReader read2 = cmd2.ExecuteReader();
            while (read2.Read())
            {
                ListViewItem add2 = new ListViewItem();
                add2.Text = read2["Elektrik"].ToString();
                add2.SubItems.Add(read2["Su"].ToString());
                add2.SubItems.Add(read2["Internet"].ToString());
                listView2.Items.Add(add2);
            }
            baglanti.Close();
        }
 
        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnKaydet2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand cmd2 = new SqlCommand("INSERT INTO Faturalar(Elektrik, Su, Internet) values( '" + TxtElektrik.Text + "','" + TxtSu.Text + "','" + TxtInt.Text + "')", baglanti);
            cmd2.ExecuteNonQuery();
            baglanti.Close();
            veriler2();
        }
    }
}
