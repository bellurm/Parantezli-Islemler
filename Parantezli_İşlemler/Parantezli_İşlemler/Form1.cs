using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Insta_karisik_islemler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int topla;
        int cikar;
        int carp;
        int bol;

        private void ilk_toplama_Click(object sender, EventArgs e)
        {
            int t_s1, t_s2;
            t_s1 = Convert.ToInt32(textBox1.Text);
            t_s2 = Convert.ToInt32(textBox2.Text);
            topla = t_s1 + t_s2;
            textBox_ilk.Text = topla.ToString();
        }

        private void ilk_cikarma_Click(object sender, EventArgs e)
        {
            int cikar_s1, cikar_s2;
            cikar_s1 = Convert.ToInt32(textBox1.Text);
            cikar_s2 = Convert.ToInt32(textBox2.Text);
            cikar = cikar_s1 - cikar_s2;
            textBox_ilk.Text = cikar.ToString();
        }

        private void ilk_carpma_Click(object sender, EventArgs e)
        {
            int carp_s1, carp_s2;
            carp_s1 = Convert.ToInt32(textBox1.Text);
            carp_s2 = Convert.ToInt32(textBox2.Text);
            carp = carp_s1 * carp_s2;
            textBox_ilk.Text = carp.ToString();
        }

        private void ilk_bolme_Click(object sender, EventArgs e)
        {
            int b_s1, b_s2;
            b_s1 = Convert.ToInt32(textBox1.Text);
            b_s2 = Convert.ToInt32(textBox2.Text);
            bol = b_s1 / b_s2;
            textBox_ilk.Text = bol.ToString();
        }
        private void ikinci_toplama_Click(object sender, EventArgs e)
        {
            int i_t_s1, i_t_s2;
            i_t_s1 = Convert.ToInt32(textBox4.Text);
            i_t_s2 = Convert.ToInt32(textBox5.Text);
            topla = i_t_s1 + i_t_s2;
            textBox_ikinci.Text = topla.ToString();
        }
        private void ikinci_cikarma_Click(object sender, EventArgs e)
        {
            int i_cikar_s1, i_cikar_s2;
            i_cikar_s1 = Convert.ToInt32(textBox4.Text);
            i_cikar_s2 = Convert.ToInt32(textBox5.Text);
            cikar = i_cikar_s1 - i_cikar_s2;
            textBox_ikinci.Text = cikar.ToString();
        }
        private void ikinci_carpma_Click(object sender, EventArgs e)
        {
            int i_carp_s1, i_carp_s2;
            i_carp_s1 = Convert.ToInt32(textBox4.Text);
            i_carp_s2 = Convert.ToInt32(textBox5.Text);
            carp = i_carp_s1 * i_carp_s2;
            textBox_ikinci.Text = carp.ToString();
        }
        private void ikinci_bolme_Click(object sender, EventArgs e)
        {
            int i_b_s1, i_b_s2;
            i_b_s1 = Convert.ToInt32(textBox4.Text);
            i_b_s2 = Convert.ToInt32(textBox5.Text);
            bol = i_b_s1 / i_b_s2;
            textBox_ikinci.Text = bol.ToString();
        }
        private void orta_toplama_Click(object sender, EventArgs e)
        {
            double s1, s2, topla, cikar;
            s1 = Convert.ToDouble(textBox_ilk.Text);
            s2 = Convert.ToDouble(textBox_ikinci.Text);
            topla = s1 + s2;
            textBox_sonuc.Text = topla.ToString();
            islem_lbl.Visible = true;
            islem_lbl.Text = "+";
            if (s1 < 0)
            {
                cikar = s2 - s1;
            }
            
        }
        private void orta_cikarma_Click(object sender, EventArgs e)
        {
            double s1, s2, cikar, cikar2;
            s1 = Convert.ToDouble(textBox_ilk.Text);
            s2 = Convert.ToDouble(textBox_ikinci.Text);
            cikar = s1 + s2;
            textBox_sonuc.Text = cikar.ToString();
            islem_lbl.Visible = true;
            islem_lbl.Text = "-";
        }
        private void orta_carpma_Click(object sender, EventArgs e)
        {
            double s1, s2, carp;
            s1 = Convert.ToDouble(textBox_ilk.Text);
            s2 = Convert.ToDouble(textBox_ikinci.Text);
            carp = s1 * s2;
            textBox_sonuc.Text = carp.ToString();
            islem_lbl.Visible = true;
            islem_lbl.Text = "x";
        }

        private void orta_bolme_Click(object sender, EventArgs e)
        {
            double s1, s2, bol;
            s1 = Convert.ToDouble(textBox_ilk.Text);
            s2 = Convert.ToDouble(textBox_ikinci.Text);
            bol = s1 / s2;
            textBox_sonuc.Text = bol.ToString();
            islem_lbl.Visible = true;
            islem_lbl.Text = "/";
        }
    }
}
