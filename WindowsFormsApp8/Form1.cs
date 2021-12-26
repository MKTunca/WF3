using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string a1 = Convert.ToString(ad.Text);
            string a2 = Convert.ToString(soyad.Text);
            string birlesme = toplam(a1, a2);
            MessageBox.Show(birlesme);
        }
        public string toplam(string a, string b)
        {
            string sonuc = "";
            sonuc=a+" "+b;
            return sonuc;
        }


    }
}
