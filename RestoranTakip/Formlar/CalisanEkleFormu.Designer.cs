namespace RestoranTakip
{
    partial class CalisanEkleFormu
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
            txtAd = new TextBox();
            txtSoyad = new TextBox();
            txtEposta = new TextBox();
            txtSifre = new TextBox();
            txtTelefon = new TextBox();
            btnKaydet = new Button();
            txtAdres = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // txtAd
            // 
            txtAd.Location = new Point(125, 32);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(184, 27);
            txtAd.TabIndex = 0;
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(125, 83);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(184, 27);
            txtSoyad.TabIndex = 0;
            // 
            // txtEposta
            // 
            txtEposta.Location = new Point(125, 131);
            txtEposta.Name = "txtEposta";
            txtEposta.Size = new Size(184, 27);
            txtEposta.TabIndex = 0;
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(125, 180);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(184, 27);
            txtSifre.TabIndex = 0;
            // 
            // txtTelefon
            // 
            txtTelefon.Location = new Point(125, 228);
            txtTelefon.Name = "txtTelefon";
            txtTelefon.Size = new Size(184, 27);
            txtTelefon.TabIndex = 0;
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(36, 344);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(116, 29);
            btnKaydet.TabIndex = 1;
            btnKaydet.Text = "Kayıt Oluştur";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // txtAdres
            // 
            txtAdres.Location = new Point(125, 270);
            txtAdres.Name = "txtAdres";
            txtAdres.Size = new Size(184, 27);
            txtAdres.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 39);
            label1.Name = "label1";
            label1.Size = new Size(30, 20);
            label1.TabIndex = 2;
            label1.Text = "AD";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 90);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 2;
            label2.Text = "Soyad";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(36, 138);
            label3.Name = "label3";
            label3.Size = new Size(60, 20);
            label3.TabIndex = 2;
            label3.Text = "E-posta";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(36, 187);
            label4.Name = "label4";
            label4.Size = new Size(39, 20);
            label4.TabIndex = 2;
            label4.Text = "Sifre";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(36, 235);
            label5.Name = "label5";
            label5.Size = new Size(58, 20);
            label5.TabIndex = 2;
            label5.Text = "Telefon";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(36, 277);
            label6.Name = "label6";
            label6.Size = new Size(47, 20);
            label6.TabIndex = 2;
            label6.Text = "Adres";
            // 
            // button1
            // 
            button1.Location = new Point(193, 344);
            button1.Name = "button1";
            button1.Size = new Size(116, 29);
            button1.TabIndex = 3;
            button1.Text = "İptal";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // CalisanEkleFormu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(417, 457);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnKaydet);
            Controls.Add(txtAdres);
            Controls.Add(txtTelefon);
            Controls.Add(txtSifre);
            Controls.Add(txtEposta);
            Controls.Add(txtSoyad);
            Controls.Add(txtAd);
            Name = "CalisanEkleFormu";
            Text = "CalisanEkleFormu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtAd;
        private TextBox txtSoyad;
        private TextBox txtEposta;
        private TextBox txtSifre;
        private TextBox txtTelefon;
        private Button btnKaydet;
        private TextBox txtAdres;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button button1;
    }
}