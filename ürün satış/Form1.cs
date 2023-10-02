using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ürün_satış
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            int fiyat, miktar;

            double sonuc;

            fiyat = Convert.ToInt32(txtFiyat.Text);
            miktar = Convert.ToInt32(txtMiktar.Text);

            sonuc = fiyat * miktar;

            lblTutar.Text = sonuc.ToString();

            

        }
    }
}
