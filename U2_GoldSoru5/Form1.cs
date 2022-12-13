using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U2_GoldSoru5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int kucukSayi, buyukSayi;

            try
            {
                kucukSayi = Convert.ToInt32(txtEnKucuk.Text);
                buyukSayi = Convert.ToInt32(txtEnBuyuk.Text);

                if (kucukSayi > buyukSayi)
                {
                    MessageBox.Show("Lütfen küçük sayıyı, küçük olarak giriniz. Küçük küçüklüğünü bilsin");
                }
                else
                {
                    for (int i = kucukSayi; i < buyukSayi; i++)
                    {
                        if (i % 2 == 0) //çift sayı ise
                        {
                            listBox1.Items.Add(i);
                        }
                        else if (i % 3 == 0)
                        {
                            listBox2.Items.Add(i);
                        }
                        else
                        {
                            listBox3.Items.Add(i);
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen sayı giriniz.");
            }
        }
    }
}
