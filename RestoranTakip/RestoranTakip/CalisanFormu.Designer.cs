namespace RestoranTakip
{
    partial class CalisanFormu
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
            dgvSiparisler = new DataGridView();
            SiparisID = new DataGridViewTextBoxColumn();
            MusteriAdi = new DataGridViewTextBoxColumn();
            Telefon = new DataGridViewTextBoxColumn();
            Adres = new DataGridViewTextBoxColumn();
            Urunler = new DataGridViewTextBoxColumn();
            ToplamFiyat = new DataGridViewTextBoxColumn();
            Durum = new DataGridViewTextBoxColumn();
            btnHazirlaniyor = new Button();
            btnYolda = new Button();
            btnTeslimEdildi = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvSiparisler).BeginInit();
            SuspendLayout();
            // 
            // dgvSiparisler
            // 
            dgvSiparisler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSiparisler.Columns.AddRange(new DataGridViewColumn[] { SiparisID, MusteriAdi, Telefon, Adres, Urunler, ToplamFiyat, Durum });
            dgvSiparisler.Location = new Point(12, 34);
            dgvSiparisler.Name = "dgvSiparisler";
            dgvSiparisler.Size = new Size(776, 150);
            dgvSiparisler.TabIndex = 0;
            // 
            // SiparisID
            // 
            SiparisID.HeaderText = "SiparisID";
            SiparisID.Name = "SiparisID";
            // 
            // MusteriAdi
            // 
            MusteriAdi.HeaderText = "Müşteri Adı";
            MusteriAdi.Name = "MusteriAdi";
            // 
            // Telefon
            // 
            Telefon.HeaderText = "Telefon";
            Telefon.Name = "Telefon";
            // 
            // Adres
            // 
            Adres.HeaderText = "Adres";
            Adres.Name = "Adres";
            // 
            // Urunler
            // 
            Urunler.HeaderText = "Ürünler";
            Urunler.Name = "Urunler";
            // 
            // ToplamFiyat
            // 
            ToplamFiyat.HeaderText = "Toplam Fiyat";
            ToplamFiyat.Name = "ToplamFiyat";
            // 
            // Durum
            // 
            Durum.HeaderText = "Durum";
            Durum.Name = "Durum";
            // 
            // btnHazirlaniyor
            // 
            btnHazirlaniyor.Location = new Point(42, 225);
            btnHazirlaniyor.Name = "btnHazirlaniyor";
            btnHazirlaniyor.Size = new Size(99, 23);
            btnHazirlaniyor.TabIndex = 1;
            btnHazirlaniyor.Text = "Hazırlanıyor";
            btnHazirlaniyor.UseVisualStyleBackColor = true;
            btnHazirlaniyor.Click += btnHazirlaniyor_Click;
            // 
            // btnYolda
            // 
            btnYolda.Location = new Point(191, 225);
            btnYolda.Name = "btnYolda";
            btnYolda.Size = new Size(99, 23);
            btnYolda.TabIndex = 1;
            btnYolda.Text = "Yolda";
            btnYolda.UseVisualStyleBackColor = true;
            btnYolda.Click += btnYolda_Click;
            // 
            // btnTeslimEdildi
            // 
            btnTeslimEdildi.Location = new Point(329, 225);
            btnTeslimEdildi.Name = "btnTeslimEdildi";
            btnTeslimEdildi.Size = new Size(99, 23);
            btnTeslimEdildi.TabIndex = 1;
            btnTeslimEdildi.Text = "Teslim Edildi";
            btnTeslimEdildi.UseVisualStyleBackColor = true;
            btnTeslimEdildi.Click += btnTeslimEdildi_Click;
            // 
            // CalisanFormu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnTeslimEdildi);
            Controls.Add(btnYolda);
            Controls.Add(btnHazirlaniyor);
            Controls.Add(dgvSiparisler);
            Name = "CalisanFormu";
            Text = "CalisanFormu";
            ((System.ComponentModel.ISupportInitialize)dgvSiparisler).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvSiparisler;
        private DataGridViewTextBoxColumn SiparisID;
        private DataGridViewTextBoxColumn MusteriAdi;
        private DataGridViewTextBoxColumn Telefon;
        private DataGridViewTextBoxColumn Adres;
        private DataGridViewTextBoxColumn Urunler;
        private DataGridViewTextBoxColumn ToplamFiyat;
        private DataGridViewTextBoxColumn Durum;
        private Button btnHazirlaniyor;
        private Button btnYolda;
        private Button btnTeslimEdildi;
    }
}