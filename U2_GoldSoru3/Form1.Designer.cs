
namespace U2_GoldSoru3
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
            this.btnHesapla = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNot1 = new System.Windows.Forms.TextBox();
            this.txtNot2 = new System.Windows.Forms.TextBox();
            this.txtNot3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbRobotik = new System.Windows.Forms.RadioButton();
            this.rbNesne = new System.Windows.Forms.RadioButton();
            this.rbTurkce = new System.Windows.Forms.RadioButton();
            this.rbMat = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnHesapla
            // 
            this.btnHesapla.BackColor = System.Drawing.Color.LimeGreen;
            this.btnHesapla.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHesapla.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnHesapla.Location = new System.Drawing.Point(9, 124);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(220, 32);
            this.btnHesapla.TabIndex = 0;
            this.btnHesapla.Text = "Ortalama Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = false;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Yazılı 1: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(6, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Yazılı 2: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(6, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Yazılı 3: ";
            // 
            // txtNot1
            // 
            this.txtNot1.Location = new System.Drawing.Point(76, 13);
            this.txtNot1.Name = "txtNot1";
            this.txtNot1.Size = new System.Drawing.Size(153, 20);
            this.txtNot1.TabIndex = 4;
            // 
            // txtNot2
            // 
            this.txtNot2.Location = new System.Drawing.Point(76, 39);
            this.txtNot2.Name = "txtNot2";
            this.txtNot2.Size = new System.Drawing.Size(153, 20);
            this.txtNot2.TabIndex = 5;
            // 
            // txtNot3
            // 
            this.txtNot3.Location = new System.Drawing.Point(76, 65);
            this.txtNot3.Name = "txtNot3";
            this.txtNot3.Size = new System.Drawing.Size(153, 20);
            this.txtNot3.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(6, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Labe4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(171, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "label5";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbRobotik);
            this.groupBox1.Controls.Add(this.rbNesne);
            this.groupBox1.Controls.Add(this.rbTurkce);
            this.groupBox1.Controls.Add(this.rbMat);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(158, 162);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dersler";
            // 
            // rbRobotik
            // 
            this.rbRobotik.AutoSize = true;
            this.rbRobotik.Location = new System.Drawing.Point(6, 91);
            this.rbRobotik.Name = "rbRobotik";
            this.rbRobotik.Size = new System.Drawing.Size(106, 17);
            this.rbRobotik.TabIndex = 3;
            this.rbRobotik.TabStop = true;
            this.rbRobotik.Text = "Robotik Kodlama";
            this.rbRobotik.UseVisualStyleBackColor = true;
            this.rbRobotik.CheckedChanged += new System.EventHandler(this.rbRobotik_CheckedChanged);
            // 
            // rbNesne
            // 
            this.rbNesne.AutoSize = true;
            this.rbNesne.Location = new System.Drawing.Point(6, 68);
            this.rbNesne.Name = "rbNesne";
            this.rbNesne.Size = new System.Drawing.Size(122, 17);
            this.rbNesne.TabIndex = 2;
            this.rbNesne.TabStop = true;
            this.rbNesne.Text = "Nesne Tabanlı Prog.";
            this.rbNesne.UseVisualStyleBackColor = true;
            this.rbNesne.CheckedChanged += new System.EventHandler(this.rbNesne_CheckedChanged);
            // 
            // rbTurkce
            // 
            this.rbTurkce.AutoSize = true;
            this.rbTurkce.Location = new System.Drawing.Point(6, 42);
            this.rbTurkce.Name = "rbTurkce";
            this.rbTurkce.Size = new System.Drawing.Size(59, 17);
            this.rbTurkce.TabIndex = 1;
            this.rbTurkce.TabStop = true;
            this.rbTurkce.Text = "Türkçe";
            this.rbTurkce.UseVisualStyleBackColor = true;
            this.rbTurkce.CheckedChanged += new System.EventHandler(this.rbTurkce_CheckedChanged);
            // 
            // rbMat
            // 
            this.rbMat.AutoSize = true;
            this.rbMat.Location = new System.Drawing.Point(6, 19);
            this.rbMat.Name = "rbMat";
            this.rbMat.Size = new System.Drawing.Size(74, 17);
            this.rbMat.TabIndex = 0;
            this.rbMat.TabStop = true;
            this.rbMat.Text = "Matematik";
            this.rbMat.UseVisualStyleBackColor = true;
            this.rbMat.CheckedChanged += new System.EventHandler(this.rbMat_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btnHesapla);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtNot3);
            this.groupBox2.Controls.Add(this.txtNot1);
            this.groupBox2.Controls.Add(this.txtNot2);
            this.groupBox2.Location = new System.Drawing.Point(176, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(235, 162);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hesaplama";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 193);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Gold Soru3 / Not Hesaplama v1.0";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNot1;
        private System.Windows.Forms.TextBox txtNot2;
        private System.Windows.Forms.TextBox txtNot3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbRobotik;
        private System.Windows.Forms.RadioButton rbNesne;
        private System.Windows.Forms.RadioButton rbTurkce;
        private System.Windows.Forms.RadioButton rbMat;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

