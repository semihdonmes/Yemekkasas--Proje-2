﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Yemekkasası.Sınıf;

namespace SemihDonmezProje
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            
            Yemekkasası.Sınıf.Giris giris = new Yemekkasası.Sınıf.Giris();
            Yemekkasası.Sınıf.IGirisKayit oturum = (Yemekkasası.Sınıf.IGirisKayit)giris;
            lblGiris.Text = oturum.OturumBilgisi();





        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
