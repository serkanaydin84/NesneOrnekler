
namespace U2_GoldSoru5
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.txtEnBuyuk = new System.Windows.Forms.TextBox();
            this.txtEnKucuk = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(184, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "2 ile Bölünebilenler";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 117);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 54);
            this.button1.TabIndex = 15;
            this.button1.Text = "2-3-5 ile Bölünebilme Hesapla";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(187, 34);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(85, 134);
            this.listBox1.TabIndex = 13;
            // 
            // txtEnBuyuk
            // 
            this.txtEnBuyuk.Location = new System.Drawing.Point(100, 64);
            this.txtEnBuyuk.Name = "txtEnBuyuk";
            this.txtEnBuyuk.Size = new System.Drawing.Size(55, 20);
            this.txtEnBuyuk.TabIndex = 12;
            // 
            // txtEnKucuk
            // 
            this.txtEnKucuk.Location = new System.Drawing.Point(101, 31);
            this.txtEnKucuk.Name = "txtEnKucuk";
            this.txtEnKucuk.Size = new System.Drawing.Size(55, 20);
            this.txtEnKucuk.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "En Büyük Sayı: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "En Küçük Sayı: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(285, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "3 ile Bölünebilenler";
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(288, 34);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(85, 134);
            this.listBox2.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(386, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "5 ile Bölünebilenler";
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.Location = new System.Drawing.Point(389, 34);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(85, 134);
            this.listBox3.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 195);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.txtEnBuyuk);
            this.Controls.Add(this.txtEnKucuk);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "GoldSoru5 / 2-3-5 ile Bölünebilenler";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox txtEnBuyuk;
        private System.Windows.Forms.TextBox txtEnKucuk;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox listBox3;
    }
}

