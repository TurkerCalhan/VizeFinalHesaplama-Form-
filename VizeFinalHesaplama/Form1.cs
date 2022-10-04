using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VizeFinalHesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        float vize;
        float final;
        float ortalama;

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            vize =float.Parse(txtVize.Text);
            final =float.Parse(txtFinal.Text);
            float vizeYuzdeKirk = (vize * 40) / 100;
            float finalYuzdeAltmış = (final * 60) / 100;
            ortalama = vizeYuzdeKirk + finalYuzdeAltmış;
            lblOrtalama.Text = ortalama.ToString();
            if(ortalama < 30)
            {
                lblHarf.Text = "F";
            }
            if(ortalama >=30 && ortalama < 50)
            {
                lblHarf.Text = "D";
            }
            if(ortalama>=50 && ortalama <70)
            {
                lblHarf.Text = "C";
            }
            if (ortalama >= 70 && ortalama < 85)
            {
                lblHarf.Text = "B";
            }
            if (ortalama >= 85 )
            {
                lblHarf.Text = "A";
            }
        }
    }
}
