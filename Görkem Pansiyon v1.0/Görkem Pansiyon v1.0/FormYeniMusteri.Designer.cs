
namespace Görkem_Pansiyon_v1._0
{
    partial class FormYeniMusteri
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.MaskTxtTel = new System.Windows.Forms.MaskedTextBox();
            this.DtpCikis = new System.Windows.Forms.DateTimePicker();
            this.DtpGiris = new System.Windows.Forms.DateTimePicker();
            this.TxtUcret = new System.Windows.Forms.TextBox();
            this.TxtOda = new System.Windows.Forms.TextBox();
            this.TxtTC = new System.Windows.Forms.TextBox();
            this.TxtMail = new System.Windows.Forms.TextBox();
            this.TxtSoyad = new System.Windows.Forms.TextBox();
            this.TxtAd = new System.Windows.Forms.TextBox();
            this.BtnKaydet = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnBos = new System.Windows.Forms.Button();
            this.BtnDolu = new System.Windows.Forms.Button();
            this.Btn109 = new System.Windows.Forms.Button();
            this.Btn108 = new System.Windows.Forms.Button();
            this.Btn107 = new System.Windows.Forms.Button();
            this.Btn106 = new System.Windows.Forms.Button();
            this.Btn105 = new System.Windows.Forms.Button();
            this.Btn104 = new System.Windows.Forms.Button();
            this.Btn103 = new System.Windows.Forms.Button();
            this.Btn102 = new System.Windows.Forms.Button();
            this.Btn101 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.MaskTxtTel);
            this.groupBox1.Controls.Add(this.DtpCikis);
            this.groupBox1.Controls.Add(this.DtpGiris);
            this.groupBox1.Controls.Add(this.TxtUcret);
            this.groupBox1.Controls.Add(this.TxtOda);
            this.groupBox1.Controls.Add(this.TxtTC);
            this.groupBox1.Controls.Add(this.TxtMail);
            this.groupBox1.Controls.Add(this.TxtSoyad);
            this.groupBox1.Controls.Add(this.TxtAd);
            this.groupBox1.Controls.Add(this.BtnKaydet);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe Print", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(16, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(653, 571);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Müşteri Bilgileri";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(595, 509);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(24, 28);
            this.label11.TabIndex = 21;
            this.label11.Text = "0";
            this.label11.Visible = false;
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Erkek",
            "Kadın"});
            this.comboBox1.Location = new System.Drawing.Point(192, 122);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(294, 34);
            this.comboBox1.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(106, 122);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 28);
            this.label10.TabIndex = 19;
            this.label10.Text = "Cinsiyet:";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // MaskTxtTel
            // 
            this.MaskTxtTel.Location = new System.Drawing.Point(192, 165);
            this.MaskTxtTel.Mask = "(999) 000-0000";
            this.MaskTxtTel.Name = "MaskTxtTel";
            this.MaskTxtTel.Size = new System.Drawing.Size(294, 34);
            this.MaskTxtTel.TabIndex = 18;
            // 
            // DtpCikis
            // 
            this.DtpCikis.Location = new System.Drawing.Point(192, 418);
            this.DtpCikis.Name = "DtpCikis";
            this.DtpCikis.Size = new System.Drawing.Size(294, 34);
            this.DtpCikis.TabIndex = 17;
            this.DtpCikis.ValueChanged += new System.EventHandler(this.DtpCikis_ValueChanged);
            // 
            // DtpGiris
            // 
            this.DtpGiris.Location = new System.Drawing.Point(192, 375);
            this.DtpGiris.Name = "DtpGiris";
            this.DtpGiris.Size = new System.Drawing.Size(294, 34);
            this.DtpGiris.TabIndex = 16;
            // 
            // TxtUcret
            // 
            this.TxtUcret.Location = new System.Drawing.Point(192, 334);
            this.TxtUcret.Name = "TxtUcret";
            this.TxtUcret.Size = new System.Drawing.Size(294, 34);
            this.TxtUcret.TabIndex = 15;
            // 
            // TxtOda
            // 
            this.TxtOda.Enabled = false;
            this.TxtOda.Location = new System.Drawing.Point(192, 292);
            this.TxtOda.Name = "TxtOda";
            this.TxtOda.Size = new System.Drawing.Size(294, 34);
            this.TxtOda.TabIndex = 14;
            // 
            // TxtTC
            // 
            this.TxtTC.Location = new System.Drawing.Point(192, 248);
            this.TxtTC.MaxLength = 11;
            this.TxtTC.Name = "TxtTC";
            this.TxtTC.Size = new System.Drawing.Size(294, 34);
            this.TxtTC.TabIndex = 13;
            this.TxtTC.TextChanged += new System.EventHandler(this.TxtTC_TextChanged);
            // 
            // TxtMail
            // 
            this.TxtMail.Location = new System.Drawing.Point(192, 205);
            this.TxtMail.Name = "TxtMail";
            this.TxtMail.Size = new System.Drawing.Size(294, 34);
            this.TxtMail.TabIndex = 12;
            // 
            // TxtSoyad
            // 
            this.TxtSoyad.Location = new System.Drawing.Point(192, 82);
            this.TxtSoyad.Name = "TxtSoyad";
            this.TxtSoyad.Size = new System.Drawing.Size(294, 34);
            this.TxtSoyad.TabIndex = 11;
            // 
            // TxtAd
            // 
            this.TxtAd.Location = new System.Drawing.Point(192, 42);
            this.TxtAd.Name = "TxtAd";
            this.TxtAd.Size = new System.Drawing.Size(294, 34);
            this.TxtAd.TabIndex = 10;
            this.TxtAd.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnKaydet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnKaydet.Location = new System.Drawing.Point(273, 482);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(129, 41);
            this.BtnKaydet.TabIndex = 9;
            this.BtnKaydet.Text = "Kaydet";
            this.BtnKaydet.UseVisualStyleBackColor = false;
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(126, 337);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 28);
            this.label9.TabIndex = 8;
            this.label9.Text = "Ücret:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(78, 424);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 28);
            this.label8.TabIndex = 7;
            this.label8.Text = "Çıkış Tarihi:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(78, 381);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 28);
            this.label7.TabIndex = 6;
            this.label7.Text = "Giriş Tarihi:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(108, 295);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 28);
            this.label6.TabIndex = 5;
            this.label6.Text = "Oda No:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(61, 251);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 28);
            this.label5.TabIndex = 4;
            this.label5.Text = "TC Kimlik No:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(135, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 28);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mail:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(111, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "Telefon:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(121, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soyad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(146, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnBos);
            this.groupBox2.Controls.Add(this.BtnDolu);
            this.groupBox2.Controls.Add(this.Btn109);
            this.groupBox2.Controls.Add(this.Btn108);
            this.groupBox2.Controls.Add(this.Btn107);
            this.groupBox2.Controls.Add(this.Btn106);
            this.groupBox2.Controls.Add(this.Btn105);
            this.groupBox2.Controls.Add(this.Btn104);
            this.groupBox2.Controls.Add(this.Btn103);
            this.groupBox2.Controls.Add(this.Btn102);
            this.groupBox2.Controls.Add(this.Btn101);
            this.groupBox2.Font = new System.Drawing.Font("Segoe Print", 10.86792F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(682, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(446, 571);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Odalar";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // BtnBos
            // 
            this.BtnBos.BackColor = System.Drawing.Color.LimeGreen;
            this.BtnBos.Location = new System.Drawing.Point(172, 482);
            this.BtnBos.Name = "BtnBos";
            this.BtnBos.Size = new System.Drawing.Size(96, 55);
            this.BtnBos.TabIndex = 10;
            this.BtnBos.Text = "Boş";
            this.BtnBos.UseVisualStyleBackColor = false;
            this.BtnBos.Click += new System.EventHandler(this.BtnBos_Click);
            // 
            // BtnDolu
            // 
            this.BtnDolu.BackColor = System.Drawing.Color.Red;
            this.BtnDolu.Location = new System.Drawing.Point(301, 482);
            this.BtnDolu.Name = "BtnDolu";
            this.BtnDolu.Size = new System.Drawing.Size(96, 55);
            this.BtnDolu.TabIndex = 9;
            this.BtnDolu.Text = "Dolu";
            this.BtnDolu.UseVisualStyleBackColor = false;
            this.BtnDolu.Click += new System.EventHandler(this.BtnDolu_Click);
            // 
            // Btn109
            // 
            this.Btn109.BackColor = System.Drawing.Color.LimeGreen;
            this.Btn109.Location = new System.Drawing.Point(301, 354);
            this.Btn109.Name = "Btn109";
            this.Btn109.Size = new System.Drawing.Size(96, 55);
            this.Btn109.TabIndex = 8;
            this.Btn109.Text = "109";
            this.Btn109.UseVisualStyleBackColor = false;
            this.Btn109.Click += new System.EventHandler(this.Btn109_Click);
            // 
            // Btn108
            // 
            this.Btn108.BackColor = System.Drawing.Color.LimeGreen;
            this.Btn108.Location = new System.Drawing.Point(172, 354);
            this.Btn108.Name = "Btn108";
            this.Btn108.Size = new System.Drawing.Size(96, 55);
            this.Btn108.TabIndex = 7;
            this.Btn108.Text = "108";
            this.Btn108.UseVisualStyleBackColor = false;
            this.Btn108.Click += new System.EventHandler(this.Btn108_Click);
            // 
            // Btn107
            // 
            this.Btn107.BackColor = System.Drawing.Color.LimeGreen;
            this.Btn107.Location = new System.Drawing.Point(41, 354);
            this.Btn107.Name = "Btn107";
            this.Btn107.Size = new System.Drawing.Size(96, 55);
            this.Btn107.TabIndex = 6;
            this.Btn107.Text = "107";
            this.Btn107.UseVisualStyleBackColor = false;
            this.Btn107.Click += new System.EventHandler(this.Btn107_Click);
            // 
            // Btn106
            // 
            this.Btn106.BackColor = System.Drawing.Color.LimeGreen;
            this.Btn106.Location = new System.Drawing.Point(301, 205);
            this.Btn106.Name = "Btn106";
            this.Btn106.Size = new System.Drawing.Size(96, 55);
            this.Btn106.TabIndex = 5;
            this.Btn106.Text = "106";
            this.Btn106.UseVisualStyleBackColor = false;
            this.Btn106.Click += new System.EventHandler(this.Btn106_Click);
            // 
            // Btn105
            // 
            this.Btn105.BackColor = System.Drawing.Color.LimeGreen;
            this.Btn105.Location = new System.Drawing.Point(172, 205);
            this.Btn105.Name = "Btn105";
            this.Btn105.Size = new System.Drawing.Size(96, 55);
            this.Btn105.TabIndex = 4;
            this.Btn105.Text = "105";
            this.Btn105.UseVisualStyleBackColor = false;
            this.Btn105.Click += new System.EventHandler(this.Btn105_Click);
            // 
            // Btn104
            // 
            this.Btn104.BackColor = System.Drawing.Color.LimeGreen;
            this.Btn104.Location = new System.Drawing.Point(41, 205);
            this.Btn104.Name = "Btn104";
            this.Btn104.Size = new System.Drawing.Size(96, 55);
            this.Btn104.TabIndex = 3;
            this.Btn104.Text = "104";
            this.Btn104.UseVisualStyleBackColor = false;
            this.Btn104.Click += new System.EventHandler(this.Btn104_Click);
            // 
            // Btn103
            // 
            this.Btn103.BackColor = System.Drawing.Color.LimeGreen;
            this.Btn103.Location = new System.Drawing.Point(301, 58);
            this.Btn103.Name = "Btn103";
            this.Btn103.Size = new System.Drawing.Size(96, 55);
            this.Btn103.TabIndex = 2;
            this.Btn103.Text = "103";
            this.Btn103.UseVisualStyleBackColor = false;
            this.Btn103.Click += new System.EventHandler(this.Btn103_Click);
            // 
            // Btn102
            // 
            this.Btn102.BackColor = System.Drawing.Color.LimeGreen;
            this.Btn102.Location = new System.Drawing.Point(172, 58);
            this.Btn102.Name = "Btn102";
            this.Btn102.Size = new System.Drawing.Size(96, 55);
            this.Btn102.TabIndex = 1;
            this.Btn102.Text = "102";
            this.Btn102.UseVisualStyleBackColor = false;
            this.Btn102.Click += new System.EventHandler(this.Btn102_Click);
            // 
            // Btn101
            // 
            this.Btn101.BackColor = System.Drawing.Color.LimeGreen;
            this.Btn101.Location = new System.Drawing.Point(41, 58);
            this.Btn101.Name = "Btn101";
            this.Btn101.Size = new System.Drawing.Size(96, 55);
            this.Btn101.TabIndex = 0;
            this.Btn101.Text = "101";
            this.Btn101.UseVisualStyleBackColor = false;
            this.Btn101.Click += new System.EventHandler(this.button2_Click);
            // 
            // FormYeniMusteri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1145, 592);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormYeniMusteri";
            this.Text = "Yeni Müşteri Ekle";
            this.Load += new System.EventHandler(this.FormYeniMusteri_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox MaskTxtTel;
        private System.Windows.Forms.DateTimePicker DtpCikis;
        private System.Windows.Forms.DateTimePicker DtpGiris;
        private System.Windows.Forms.TextBox TxtUcret;
        private System.Windows.Forms.TextBox TxtOda;
        private System.Windows.Forms.TextBox TxtTC;
        private System.Windows.Forms.TextBox TxtMail;
        private System.Windows.Forms.TextBox TxtSoyad;
        private System.Windows.Forms.TextBox TxtAd;
        private System.Windows.Forms.Button BtnKaydet;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Btn101;
        private System.Windows.Forms.Button BtnBos;
        private System.Windows.Forms.Button BtnDolu;
        private System.Windows.Forms.Button Btn109;
        private System.Windows.Forms.Button Btn108;
        private System.Windows.Forms.Button Btn107;
        private System.Windows.Forms.Button Btn106;
        private System.Windows.Forms.Button Btn105;
        private System.Windows.Forms.Button Btn104;
        private System.Windows.Forms.Button Btn103;
        private System.Windows.Forms.Button Btn102;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label11;
    }
}