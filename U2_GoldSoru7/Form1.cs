using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U2_GoldSoru7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random random = new Random();
            for (int i = 1; i <= 20; i++)
            {
                listBox1.Items.Add(random.Next(1, 100));
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int kucuk, buyuk;
            int buyukIndeks = 0;

            kucuk = Convert.ToInt32(listBox1.Items[0]);
            buyuk = Convert.ToInt32(listBox1.Items[0]);
            int sayi;
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                sayi = Convert.ToInt32(listBox1.Items[i]);
                if (buyuk < sayi)
                {
                    buyuk = sayi;
                    buyukIndeks = i;
                }

                if (kucuk > sayi)
                {
                    kucuk = sayi;
                }
            }

            lblBuyuk.Text = buyuk.ToString();
            lblKucuk.Text = kucuk.ToString();
            listBox1.SelectedIndex = buyukIndeks;
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Random random = new Random();
            for (int i = 1; i <= 20; i++)
            {
                listBox1.Items.Add(random.Next(1, 100));
            }
        }
    }
}
