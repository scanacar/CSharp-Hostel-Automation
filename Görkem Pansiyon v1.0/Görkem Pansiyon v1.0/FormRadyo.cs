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
    public partial class FormRadyo : Form
    {
        public FormRadyo()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            axWindowsMediaPlayer1.URL = "http://fenomenoriental.listenfenomen.com/fenomenrap/128/icecast.audio";
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            axWindowsMediaPlayer1.URL = "http://nmbshsource.mediatriple.net:7000/stream/20/ ";
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            axWindowsMediaPlayer1.URL = "https://listen.powerapp.com.tr/powerfm/abr/powerfm/128/playlist.m3u8";
        }

        private void FormRadyo_Load(object sender, EventArgs e)
        {

        }
    }
}
