﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SemihDonmezProje
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            Yemekkasası.Sınıf.Kayit kayit = new Yemekkasası.Sınıf.Kayit();
            Yemekkasası.Sınıf.IGirisKayit oturum = (Yemekkasası.Sınıf.IGirisKayit)kayit;
            lblKayit.Text = oturum.OturumBilgisi();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
