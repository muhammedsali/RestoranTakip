namespace RestoranTakip
{
    partial class Form2
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtSoyad = new TextBox();
            txtAd = new TextBox();
            txtSifre = new TextBox();
            txtEposta = new TextBox();
            txtAdres = new TextBox();
            txtTelefon = new TextBox();
            cbRol = new ComboBox();
            btnKayit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(114, 44);
            label1.Name = "label1";
            label1.Size = new Size(28, 20);
            label1.TabIndex = 0;
            label1.Text = "Ad";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(95, 109);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 0;
            label2.Text = "Soyad";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(86, 164);
            label3.Name = "label3";
            label3.Size = new Size(60, 20);
            label3.TabIndex = 0;
            label3.Text = "E-posta";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(105, 216);
            label4.Name = "label4";
            label4.Size = new Size(39, 20);
            label4.TabIndex = 1;
            label4.Text = "Şifre";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(88, 281);
            label5.Name = "label5";
            label5.Size = new Size(58, 20);
            label5.TabIndex = 2;
            label5.Text = "Telefon";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(97, 335);
            label6.Name = "label6";
            label6.Size = new Size(47, 20);
            label6.TabIndex = 3;
            label6.Text = "Adres";
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(169, 99);
            txtSoyad.Margin = new Padding(3, 4, 3, 4);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(114, 27);
            txtSoyad.TabIndex = 4;
            // 
            // txtAd
            // 
            txtAd.Location = new Point(169, 40);
            txtAd.Margin = new Padding(3, 4, 3, 4);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(114, 27);
            txtAd.TabIndex = 4;
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(169, 216);
            txtSifre.Margin = new Padding(3, 4, 3, 4);
            txtSifre.Name = "txtSifre";
            txtSifre.PasswordChar = '*';
            txtSifre.Size = new Size(114, 27);
            txtSifre.TabIndex = 4;
            // 
            // txtEposta
            // 
            txtEposta.Location = new Point(169, 160);
            txtEposta.Margin = new Padding(3, 4, 3, 4);
            txtEposta.Name = "txtEposta";
            txtEposta.Size = new Size(114, 27);
            txtEposta.TabIndex = 4;
            // 
            // txtAdres
            // 
            txtAdres.Location = new Point(169, 331);
            txtAdres.Margin = new Padding(3, 4, 3, 4);
            txtAdres.Name = "txtAdres";
            txtAdres.Size = new Size(114, 27);
            txtAdres.TabIndex = 4;
            // 
            // txtTelefon
            // 
            txtTelefon.Location = new Point(169, 277);
            txtTelefon.Margin = new Padding(3, 4, 3, 4);
            txtTelefon.Name = "txtTelefon";
            txtTelefon.Size = new Size(114, 27);
            txtTelefon.TabIndex = 4;
            // 
            // cbRol
            // 
            cbRol.FormattingEnabled = true;
            cbRol.Items.AddRange(new object[] { "Musteri", "Calisan", "Yonetici" });
            cbRol.Location = new Point(169, 381);
            cbRol.Margin = new Padding(3, 4, 3, 4);
            cbRol.Name = "cbRol";
            cbRol.Size = new Size(114, 28);
            cbRol.TabIndex = 5;
            // 
            // btnKayit
            // 
            btnKayit.Location = new Point(169, 479);
            btnKayit.Margin = new Padding(3, 4, 3, 4);
            btnKayit.Name = "btnKayit";
            btnKayit.Size = new Size(114, 31);
            btnKayit.TabIndex = 6;
            btnKayit.Text = "Kayıt Ol";
            btnKayit.UseVisualStyleBackColor = true;
            btnKayit.Click += btnKayit_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(453, 624);
            Controls.Add(btnKayit);
            Controls.Add(cbRol);
            Controls.Add(txtTelefon);
            Controls.Add(txtEposta);
            Controls.Add(txtAdres);
            Controls.Add(txtSifre);
            Controls.Add(txtAd);
            Controls.Add(txtSoyad);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtSoyad;
        private TextBox txtAd;
        private TextBox txtSifre;
        private TextBox txtEposta;
        private TextBox txtAdres;
        private TextBox txtTelefon;
        private ComboBox cbRol;
        private Button btnKayit;
    }
}