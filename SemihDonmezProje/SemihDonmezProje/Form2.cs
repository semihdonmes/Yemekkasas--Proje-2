using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Yemekkasası.Sınıf;

namespace SemihDonmezProje
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
 
        private void btnSiparis_Click(object sender, EventArgs e)
        {
            
            List<string> list = new List<string>();
            MessageBox.Show("Siparişiniz alınmıştır, bizi tercih ettiğiniz için teşekkür ederiz.");
            List<Menu> yemekList = new List<Menu>();
            Menu menu = new Menu();
            menu.menuIsim = "Hamburger Menü";
            menu.menuMiktar = 5;
            yemekList.Add(menu);
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
