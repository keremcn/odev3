namespace degiskenler
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.kacsaat = new System.Windows.Forms.Button();
            this.sayiyazi = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.kacbasamak = new System.Windows.Forms.Button();
            this.karetoplam = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.asalmi = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.haftagun = new System.Windows.Forms.Button();
            this.yildiz = new System.Windows.Forms.Button();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.seri = new System.Windows.Forms.Button();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.enkucuk = new System.Windows.Forms.Button();
            this.denklem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // kacsaat
            // 
            this.kacsaat.Location = new System.Drawing.Point(142, 255);
            this.kacsaat.Name = "kacsaat";
            this.kacsaat.Size = new System.Drawing.Size(129, 23);
            this.kacsaat.TabIndex = 0;
            this.kacsaat.Text = "kaç saat?";
            this.kacsaat.UseVisualStyleBackColor = true;
            this.kacsaat.Click += new System.EventHandler(this.kacsaat_Click);
            // 
            // sayiyazi
            // 
            this.sayiyazi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.sayiyazi.Location = new System.Drawing.Point(22, 255);
            this.sayiyazi.Name = "sayiyazi";
            this.sayiyazi.Size = new System.Drawing.Size(99, 23);
            this.sayiyazi.TabIndex = 1;
            this.sayiyazi.Text = "sayıdan yazı";
            this.sayiyazi.UseVisualStyleBackColor = true;
            this.sayiyazi.Click += new System.EventHandler(this.sayiyazi_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(142, 212);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(129, 23);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(22, 212);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(99, 23);
            this.textBox2.TabIndex = 3;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(314, 212);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(106, 23);
            this.textBox3.TabIndex = 4;
            // 
            // kacbasamak
            // 
            this.kacbasamak.Location = new System.Drawing.Point(314, 255);
            this.kacbasamak.Name = "kacbasamak";
            this.kacbasamak.Size = new System.Drawing.Size(106, 23);
            this.kacbasamak.TabIndex = 5;
            this.kacbasamak.Text = "kaç basamaklı";
            this.kacbasamak.UseVisualStyleBackColor = true;
            this.kacbasamak.Click += new System.EventHandler(this.kacbasamak_Click);
            // 
            // karetoplam
            // 
            this.karetoplam.Location = new System.Drawing.Point(22, 98);
            this.karetoplam.Name = "karetoplam";
            this.karetoplam.Size = new System.Drawing.Size(249, 87);
            this.karetoplam.TabIndex = 6;
            this.karetoplam.Text = "7 ile bölünenlerin kare toplam 0-100";
            this.karetoplam.UseVisualStyleBackColor = true;
            this.karetoplam.Click += new System.EventHandler(this.karetoplam_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(462, 212);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(118, 23);
            this.textBox4.TabIndex = 7;
            // 
            // asalmi
            // 
            this.asalmi.Location = new System.Drawing.Point(462, 255);
            this.asalmi.Name = "asalmi";
            this.asalmi.Size = new System.Drawing.Size(118, 23);
            this.asalmi.TabIndex = 8;
            this.asalmi.Text = "asal mı?";
            this.asalmi.UseVisualStyleBackColor = true;
            this.asalmi.Click += new System.EventHandler(this.asalmi_Click);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(617, 212);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(127, 23);
            this.textBox5.TabIndex = 9;
            // 
            // haftagun
            // 
            this.haftagun.Location = new System.Drawing.Point(617, 255);
            this.haftagun.Name = "haftagun";
            this.haftagun.Size = new System.Drawing.Size(127, 23);
            this.haftagun.TabIndex = 10;
            this.haftagun.Text = "haftanın günü";
            this.haftagun.UseVisualStyleBackColor = true;
            this.haftagun.Click += new System.EventHandler(this.haftagun_Click);
            // 
            // yildiz
            // 
            this.yildiz.Location = new System.Drawing.Point(779, 255);
            this.yildiz.Name = "yildiz";
            this.yildiz.Size = new System.Drawing.Size(109, 23);
            this.yildiz.TabIndex = 11;
            this.yildiz.Text = "yıldızla";
            this.yildiz.UseVisualStyleBackColor = true;
            this.yildiz.Click += new System.EventHandler(this.yildiz_Click);
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(779, 212);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(109, 23);
            this.textBox6.TabIndex = 12;
            // 
            // seri
            // 
            this.seri.Location = new System.Drawing.Point(314, 98);
            this.seri.Name = "seri";
            this.seri.Size = new System.Drawing.Size(266, 87);
            this.seri.TabIndex = 13;
            this.seri.Text = "3x+1 değerler";
            this.seri.UseVisualStyleBackColor = true;
            this.seri.Click += new System.EventHandler(this.seri_Click);
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(936, 212);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(131, 23);
            this.textBox7.TabIndex = 14;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(936, 162);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(131, 23);
            this.textBox8.TabIndex = 15;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(936, 98);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(131, 23);
            this.textBox9.TabIndex = 16;
            // 
            // enkucuk
            // 
            this.enkucuk.Location = new System.Drawing.Point(936, 255);
            this.enkucuk.Name = "enkucuk";
            this.enkucuk.Size = new System.Drawing.Size(131, 23);
            this.enkucuk.TabIndex = 17;
            this.enkucuk.Text = "en küçük";
            this.enkucuk.UseVisualStyleBackColor = true;
            this.enkucuk.Click += new System.EventHandler(this.enkucuk_Click);
            // 
            // denklem
            // 
            this.denklem.Location = new System.Drawing.Point(617, 98);
            this.denklem.Name = "denklem";
            this.denklem.Size = new System.Drawing.Size(271, 87);
            this.denklem.TabIndex = 18;
            this.denklem.Text = "Denklem değereler";
            this.denklem.UseVisualStyleBackColor = true;
            this.denklem.Click += new System.EventHandler(this.denklem_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1294, 480);
            this.Controls.Add(this.denklem);
            this.Controls.Add(this.enkucuk);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.seri);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.yildiz);
            this.Controls.Add(this.haftagun);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.asalmi);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.karetoplam);
            this.Controls.Add(this.kacbasamak);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.sayiyazi);
            this.Controls.Add(this.kacsaat);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion

        private Button kacsaat;
        private Button sayiyazi;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button kacbasamak;
        private Button karetoplam;
        private TextBox textBox4;
        private Button asalmi;
        private TextBox textBox5;
        private Button haftagun;
        private Button yildiz;
        private TextBox textBox6;
        private Button seri;
        private TextBox textBox7;
        private TextBox textBox8;
        private TextBox textBox9;
        private Button enkucuk;
        private Button denklem;
    }
}