using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U2_Uyg33
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            string kulAdi;
            long sifre;
            try
            {
                kulAdi = txtKulAdi.Text.ToString();
                sifre = long.Parse(txtSifre.Text.ToString());
                MessageBox.Show("Giriş Başarılı.Hoşgeldiniz " +kulAdi);
            }
            catch (Exception)
            {
                MessageBox.Show("Şifreniz Sadece Sayılardan Oluşmalıdır.Tekrar Deneyiniz.");
                txtSifre.Text = "";
            }
            finally
            {
            }


        }
    }
}
