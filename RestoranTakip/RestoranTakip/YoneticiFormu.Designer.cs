namespace RestoranTakip
{
    partial class YoneticiFormu
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
            dgvCalisanlar = new DataGridView();
            btnCalisanEkle = new Button();
            btnCalisanSil = new Button();
            btnUrunSil = new Button();
            btnUrunEkle = new Button();
            dgvUrunler = new DataGridView();
            btnUrunGuncelle = new Button();
            btnGunlukRapor = new Button();
            btnHaftalikRapor = new Button();
            btnAylikRapor = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCalisanlar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvUrunler).BeginInit();
            SuspendLayout();
            // 
            // dgvCalisanlar
            // 
            dgvCalisanlar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCalisanlar.Location = new Point(21, 12);
            dgvCalisanlar.Name = "dgvCalisanlar";
            dgvCalisanlar.Size = new Size(737, 150);
            dgvCalisanlar.TabIndex = 0;
            // 
            // btnCalisanEkle
            // 
            btnCalisanEkle.Location = new Point(21, 182);
            btnCalisanEkle.Name = "btnCalisanEkle";
            btnCalisanEkle.Size = new Size(98, 23);
            btnCalisanEkle.TabIndex = 1;
            btnCalisanEkle.Text = "Çalışan Ekle";
            btnCalisanEkle.UseVisualStyleBackColor = true;
            btnCalisanEkle.Click += btnCalisanEkle_Click;
            // 
            // btnCalisanSil
            // 
            btnCalisanSil.Location = new Point(141, 182);
            btnCalisanSil.Name = "btnCalisanSil";
            btnCalisanSil.Size = new Size(98, 23);
            btnCalisanSil.TabIndex = 2;
            btnCalisanSil.Text = "Çalışanı Sil";
            btnCalisanSil.UseVisualStyleBackColor = true;
            btnCalisanSil.Click += btnCalisanSil_Click;
            // 
            // btnUrunSil
            // 
            btnUrunSil.Location = new Point(141, 424);
            btnUrunSil.Name = "btnUrunSil";
            btnUrunSil.Size = new Size(98, 23);
            btnUrunSil.TabIndex = 5;
            btnUrunSil.Text = "Ürünü Sil";
            btnUrunSil.UseVisualStyleBackColor = true;
            btnUrunSil.Click += btnUrunSil_Click;
            // 
            // btnUrunEkle
            // 
            btnUrunEkle.Location = new Point(21, 424);
            btnUrunEkle.Name = "btnUrunEkle";
            btnUrunEkle.Size = new Size(98, 23);
            btnUrunEkle.TabIndex = 4;
            btnUrunEkle.Text = "Ürün Ekle";
            btnUrunEkle.UseVisualStyleBackColor = true;
            btnUrunEkle.Click += btnUrunEkle_Click;
            // 
            // dgvUrunler
            // 
            dgvUrunler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUrunler.Location = new Point(21, 254);
            dgvUrunler.Name = "dgvUrunler";
            dgvUrunler.Size = new Size(737, 150);
            dgvUrunler.TabIndex = 3;
            // 
            // btnUrunGuncelle
            // 
            btnUrunGuncelle.Location = new Point(276, 424);
            btnUrunGuncelle.Name = "btnUrunGuncelle";
            btnUrunGuncelle.Size = new Size(98, 23);
            btnUrunGuncelle.TabIndex = 5;
            btnUrunGuncelle.Text = "Ürünü Güncelle";
            btnUrunGuncelle.UseVisualStyleBackColor = true;
            btnUrunGuncelle.Click += btnUrunGuncelle_Click;
            // 
            // btnGunlukRapor
            // 
            btnGunlukRapor.Location = new Point(405, 612);
            btnGunlukRapor.Name = "btnGunlukRapor";
            btnGunlukRapor.Size = new Size(98, 23);
            btnGunlukRapor.TabIndex = 4;
            btnGunlukRapor.Text = "Günlük Rapor";
            btnGunlukRapor.UseVisualStyleBackColor = true;
            btnGunlukRapor.Click += btnGunlukRapor_Click;
            // 
            // btnHaftalikRapor
            // 
            btnHaftalikRapor.Location = new Point(525, 612);
            btnHaftalikRapor.Name = "btnHaftalikRapor";
            btnHaftalikRapor.Size = new Size(98, 23);
            btnHaftalikRapor.TabIndex = 5;
            btnHaftalikRapor.Text = "Haftalık Rapor";
            btnHaftalikRapor.UseVisualStyleBackColor = true;
            btnHaftalikRapor.Click += btnHaftalikRapor_Click;
            // 
            // btnAylikRapor
            // 
            btnAylikRapor.Location = new Point(660, 612);
            btnAylikRapor.Name = "btnAylikRapor";
            btnAylikRapor.Size = new Size(98, 23);
            btnAylikRapor.TabIndex = 5;
            btnAylikRapor.Text = "Aylık Rapor";
            btnAylikRapor.UseVisualStyleBackColor = true;
            btnAylikRapor.Click += btnAylikRapor_Click;
            // 
            // YoneticiFormu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(777, 693);
            Controls.Add(btnAylikRapor);
            Controls.Add(btnHaftalikRapor);
            Controls.Add(btnUrunGuncelle);
            Controls.Add(btnGunlukRapor);
            Controls.Add(btnUrunSil);
            Controls.Add(btnUrunEkle);
            Controls.Add(dgvUrunler);
            Controls.Add(btnCalisanSil);
            Controls.Add(btnCalisanEkle);
            Controls.Add(dgvCalisanlar);
            Name = "YoneticiFormu";
            Text = "YoneticiFormu";
            ((System.ComponentModel.ISupportInitialize)dgvCalisanlar).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvUrunler).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvCalisanlar;
        private Button btnCalisanEkle;
        private Button btnCalisanSil;
        private Button btnUrunSil;
        private Button btnUrunEkle;
        private DataGridView dgvUrunler;
        private Button btnUrunGuncelle;
        private Button btnGunlukRapor;
        private Button btnHaftalikRapor;
        private Button btnAylikRapor;
    }
}