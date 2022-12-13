using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U2_GoldSoru4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();

            int enKucuk, enBuyuk;

            try
            {
                enKucuk = Convert.ToInt32(txtEnKucuk.Text);
                enBuyuk = Convert.ToInt32(txtEnBuyuk.Text);

                if (enKucuk >= enBuyuk)
                {
                    MessageBox.Show("Lütfen Küçük sayıyı, küçük sayı olarak giriniz.");
                }
                else
                {
                    for (int i = enKucuk; i <= enBuyuk; i++)
                    {
                        if (i % 2 == 1)
                        {
                            listBox1.Items.Add(i);
                        }
                        else
                        {
                            listBox2.Items.Add(i);
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
