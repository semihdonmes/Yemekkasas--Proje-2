﻿namespace SemihDonmezProje
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            panel1 = new Panel();
            lblGiris = new Label();
            button2 = new Button();
            btnGirisYap = new Button();
            label1 = new Label();
            textBox2 = new TextBox();
            label4 = new Label();
            textBox1 = new TextBox();
            pictureBox2 = new PictureBox();
            label3 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.PaleGoldenrod;
            panel1.Controls.Add(lblGiris);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(btnGirisYap);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(0, -3);
            panel1.Name = "panel1";
            panel1.Size = new Size(285, 457);
            panel1.TabIndex = 0;
            // 
            // lblGiris
            // 
            lblGiris.AutoSize = true;
            lblGiris.Location = new Point(39, 283);
            lblGiris.Name = "lblGiris";
            lblGiris.Size = new Size(0, 20);
            lblGiris.TabIndex = 5;
            // 
            // button2
            // 
            button2.Font = new Font("Lucida Sans Unicode", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(69, 388);
            button2.Name = "button2";
            button2.Size = new Size(164, 29);
            button2.TabIndex = 4;
            button2.Text = "Ana Sayfa'ya Dön";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // btnGirisYap
            // 
            btnGirisYap.Font = new Font("Lucida Sans Unicode", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnGirisYap.Location = new Point(101, 324);
            btnGirisYap.Name = "btnGirisYap";
            btnGirisYap.Size = new Size(97, 35);
            btnGirisYap.TabIndex = 0;
            btnGirisYap.Text = "Giriş Yap";
            btnGirisYap.UseVisualStyleBackColor = true;
            btnGirisYap.Click += btnGirisYap_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Sans Unicode", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(1, 47);
            label1.Name = "label1";
            label1.Size = new Size(283, 23);
            label1.TabIndex = 1;
            label1.Text = "Yemekkasası'na Hoşgeldiniz";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(39, 239);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Lucida Sans Unicode", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(39, 215);
            label4.Name = "label4";
            label4.Size = new Size(47, 21);
            label4.TabIndex = 1;
            label4.Text = "Şifre";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(39, 185);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 3;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(114, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(41, 41);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Lucida Sans Unicode", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(39, 161);
            label3.Name = "label3";
            label3.Size = new Size(65, 21);
            label3.TabIndex = 1;
            label3.Text = "Eposta";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lucida Sans Unicode", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(101, 121);
            label2.Name = "label2";
            label2.Size = new Size(54, 22);
            label2.TabIndex = 1;
            label2.Text = "GİRİŞ";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(283, -3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(522, 457);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Name = "Form3";
            Text = "Form3";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button btnGirisYap;
        private PictureBox pictureBox1;
        private TextBox textBox1;
        private Label label2;
        private Label label3;
        private Label label4;
        private PictureBox pictureBox2;
        private TextBox textBox2;
        private Button button1;
        private Button button2;
        private Label lblGiris;
    }
}