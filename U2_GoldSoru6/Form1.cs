using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U2_GoldSoru6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void rbMat_CheckedChanged(object sender, EventArgs e)
        {
            txtNot1.Clear();
            txtNot2.Clear();
            txtNot3.Clear();
            label4.Text = "Matematik ortalaması : ";
        }

        private void rbTurkce_CheckedChanged(object sender, EventArgs e)
        {
            txtNot1.Text = "";
            txtNot2.Text = "";
            txtNot3.Text = "";
            label4.Text = "Türkçe ortalaması : ";
        }

        private void rbNesne_CheckedChanged(object sender, EventArgs e)
        {
            txtNot1.Text = "";
            txtNot2.Text = "";
            txtNot3.Text = "";
            label4.Text = "Nesne ortalaması : ";
        }

        private void rbRobotik_CheckedChanged(object sender, EventArgs e)
        {
            txtNot1.Text = "";
            txtNot2.Text = "";
            txtNot3.Text = "";
            label4.Text = "Robotik ortalaması : ";
        }

        int seneSonu = 0;
        private void btnHesapla_Click(object sender, EventArgs e)
        {
            int not1, not2, not3, ort;
            progressBar1.ForeColor = Color.Red;
            progressBar2.ForeColor = Color.Green;
            progressBar3.ForeColor = Color.Blue;
            progressBar4.ForeColor = Color.Black;

            try
            {
                not1 = Convert.ToInt32(txtNot1.Text);
                not2 = Convert.ToInt32(txtNot2.Text);
                not3 = Convert.ToInt32(txtNot3.Text);

                if (not1 > 100 || not1 < 0 || not2 > 100 || not2 < 0 || not3 > 100 || not3 < 0)
                {
                    MessageBox.Show("Lütfen 0-100 arasında rakam giriniz.");
                }
                else
                {
                    ort = (not1 + not2 + not3) / 3;
                    label5.Text = ort.ToString();

                    if (rbMat.Checked)
                    {
                        progressBar1.Value = ort;
                        seneSonu += ort;
                    }
                    else if (rbTurkce.Checked)
                    {
                        progressBar2.Value = ort;
                        seneSonu += ort;
                    }
                    else if (rbNesne.Checked)
                    {
                        progressBar3.Value = ort;
                        seneSonu += ort;
                    }
                    else if (rbRobotik.Checked)
                    {
                        progressBar4.Value = ort;
                        seneSonu += ort;
                    }

                    progressBar5.ForeColor = Color.Brown;
                    progressBar5.Value = seneSonu / 4;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen sayı giriniz.");
            }
        }
    }
}
