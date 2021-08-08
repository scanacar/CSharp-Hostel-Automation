using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Görkem_Pansiyon_v1._0
{
    public partial class FormAnaForm : Form
    {
        public FormAnaForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormAdminGiris fr = new FormAdminGiris();
            fr.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormYeniMusteri fr = new FormYeniMusteri();
            fr.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormOdalar fr = new FormOdalar();
            fr.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormMusteriler fr = new FormMusteriler();
            fr.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Görkem Pansiyon Kayıt Uygulaması\n\n<Can Acar,2021>");
        }

        private void FormAnaForm_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongDateString();
            label2.Text = DateTime.Now.ToLongTimeString();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FormGelirGider fr = new FormGelirGider();
            fr.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FormStoklar fr = new FormStoklar();
            fr.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            FormRadyo fr = new FormRadyo();
            fr.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            FormGazete fr = new FormGazete();
            fr.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            FormSifreGuncelle fr = new FormSifreGuncelle();
            fr.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            FormMesajlar fr = new FormMesajlar();
            fr.Show();
        }
    }
}
