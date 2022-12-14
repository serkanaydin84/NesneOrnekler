using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U2_GoldSoru9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int sayi;   // PC nin aklından tuttuğu sayı
        private int skor;   // bizim kalan puanımız ya da hakkımızı tutan değişken

        private void btnBasla_Click(object sender, EventArgs e)
        {
            skor = 100;
            lblSkor.Text = skor.ToString();
            btnTahminEt.Enabled = true;

            Random random = new Random();
            sayi = random.Next(101);

            MessageBox.Show("Aklımdan Bir Sayı Tuttum.\n\nBulamaz ki, bulamaz ki");
        }

        private void btnTahminEt_Click(object sender, EventArgs e)
        {
            int tahmin = 0;
            try
            {
                tahmin = Convert.ToInt32(txtTahmin.Text);

                if (tahmin < sayi)
                {
                    MessageBox.Show("Yukarı");
                    skor = skor - 10;
                }
                else if (tahmin > sayi)
                {
                    MessageBox.Show("Aşağı");
                    skor = skor - 10;
                }
                else
                {
                    MessageBox.Show("Tebrikler...");
                }

                if (skor == 0)
                {
                    MessageBox.Show("Saçlarım lüle lüle hadi sana güle güle!!!\n\nGAME OVER");
                    btnTahminEt.Enabled = false;
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Lütfen sayı giriniz.");
            }
            
            lblSkor.Text = skor.ToString();
            txtTahmin.Clear();
            txtTahmin.Focus();
        }
    }
}
