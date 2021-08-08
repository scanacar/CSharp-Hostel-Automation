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
    public partial class FormSifreGuncelle : Form
    {
        public FormSifreGuncelle()
        {
            InitializeComponent();
        }
        private void FormSifreGuncelle_Load(object sender, EventArgs e)
        {

        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("UPDATE AdminGiris SET Kullanici='" + TxtKullanici.Text + "', Sifre='" + TxtSifre.Text + "' ", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }
    }
}
