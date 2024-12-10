namespace RestoranTakip
{
    partial class UrunEkleFormu
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
            lblUrunAdi = new Label();
            lblKategori = new Label();
            lblFiyat = new Label();
            lblResimYolu = new Label();
            txtUrunAdi = new TextBox();
            txtKategori = new TextBox();
            txtResimYolu = new TextBox();
            btnKaydet = new Button();
            btnIptal = new Button();
            nudFiyat = new NumericUpDown();
            txtAciklama = new Label();
            ((System.ComponentModel.ISupportInitialize)nudFiyat).BeginInit();
            SuspendLayout();
            // 
            // lblUrunAdi
            // 
            lblUrunAdi.AutoSize = true;
            lblUrunAdi.Location = new Point(91, 58);
            lblUrunAdi.Name = "lblUrunAdi";
            lblUrunAdi.Size = new Size(67, 20);
            lblUrunAdi.TabIndex = 0;
            lblUrunAdi.Text = "Ürün Adı";
            // 
            // lblKategori
            // 
            lblKategori.AutoSize = true;
            lblKategori.Location = new Point(91, 106);
            lblKategori.Name = "lblKategori";
            lblKategori.Size = new Size(66, 20);
            lblKategori.TabIndex = 0;
            lblKategori.Text = "Kategori";
            // 
            // lblFiyat
            // 
            lblFiyat.AutoSize = true;
            lblFiyat.Location = new Point(91, 152);
            lblFiyat.Name = "lblFiyat";
            lblFiyat.Size = new Size(40, 20);
            lblFiyat.TabIndex = 0;
            lblFiyat.Text = "Fiyat";
            // 
            // lblResimYolu
            // 
            lblResimYolu.AutoSize = true;
            lblResimYolu.Location = new Point(91, 197);
            lblResimYolu.Name = "lblResimYolu";
            lblResimYolu.Size = new Size(81, 20);
            lblResimYolu.TabIndex = 0;
            lblResimYolu.Text = "Resim Yolu";
            // 
            // txtUrunAdi
            // 
            txtUrunAdi.Location = new Point(179, 51);
            txtUrunAdi.Name = "txtUrunAdi";
            txtUrunAdi.Size = new Size(273, 27);
            txtUrunAdi.TabIndex = 1;
            // 
            // txtKategori
            // 
            txtKategori.Location = new Point(179, 99);
            txtKategori.Name = "txtKategori";
            txtKategori.Size = new Size(273, 27);
            txtKategori.TabIndex = 1;
            // 
            // txtResimYolu
            // 
            txtResimYolu.Location = new Point(179, 190);
            txtResimYolu.Name = "txtResimYolu";
            txtResimYolu.Size = new Size(273, 27);
            txtResimYolu.TabIndex = 1;
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(179, 258);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(94, 29);
            btnKaydet.TabIndex = 2;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // btnIptal
            // 
            btnIptal.Location = new Point(358, 258);
            btnIptal.Name = "btnIptal";
            btnIptal.Size = new Size(94, 29);
            btnIptal.TabIndex = 2;
            btnIptal.Text = "İptal";
            btnIptal.UseVisualStyleBackColor = true;
            btnIptal.Click += btnIptal_Click;
            // 
            // nudFiyat
            // 
            nudFiyat.Location = new Point(179, 145);
            nudFiyat.Name = "nudFiyat";
            nudFiyat.Size = new Size(150, 27);
            nudFiyat.TabIndex = 3;
            // 
            // txtAciklama
            // 
            txtAciklama.AutoSize = true;
            txtAciklama.Location = new Point(77, 322);
            txtAciklama.Name = "txtAciklama";
            txtAciklama.Size = new Size(70, 20);
            txtAciklama.TabIndex = 0;
            txtAciklama.Text = "Açıklama";
            // 
            // UrunEkleFormu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(562, 375);
            Controls.Add(nudFiyat);
            Controls.Add(btnIptal);
            Controls.Add(btnKaydet);
            Controls.Add(txtResimYolu);
            Controls.Add(txtKategori);
            Controls.Add(txtUrunAdi);
            Controls.Add(txtAciklama);
            Controls.Add(lblResimYolu);
            Controls.Add(lblFiyat);
            Controls.Add(lblKategori);
            Controls.Add(lblUrunAdi);
            Name = "UrunEkleFormu";
            Text = "UrunEkleFormu";
            ((System.ComponentModel.ISupportInitialize)nudFiyat).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUrunAdi;
        private Label lblKategori;
        private Label lblFiyat;
        private Label lblResimYolu;
        private TextBox txtUrunAdi;
        private TextBox txtKategori;
        private TextBox txtResimYolu;
        private Button btnKaydet;
        private Button btnIptal;
        private NumericUpDown nudFiyat;
        private Label txtAciklama;
    }
}