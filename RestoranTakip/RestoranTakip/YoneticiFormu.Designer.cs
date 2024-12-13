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
            dgvUrunler = new DataGridView();
            txtArama = new TextBox();
            btnArama = new Button();
            dgvCalisanlar = new DataGridView();
            btnCalisanEkle = new Button();
            btnCalisanSil = new Button();
            btnUrunSil = new Button();
            btnUrunEkle = new Button();
            btnUrunGuncelle = new Button();
            btnGunlukRapor = new Button();
            btnHaftalikRapor = new Button();
            btnAylikRapor = new Button();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            tabPage3 = new TabPage();
            ((System.ComponentModel.ISupportInitialize)dgvUrunler).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCalisanlar).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            SuspendLayout();
            // 
            // dgvUrunler
            // 
            dgvUrunler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUrunler.Location = new Point(3, 3);
            dgvUrunler.Margin = new Padding(3, 4, 3, 4);
            dgvUrunler.Name = "dgvUrunler";
            dgvUrunler.RowHeadersWidth = 51;
            dgvUrunler.Size = new Size(1438, 778);
            dgvUrunler.TabIndex = 3;
            // 
            // txtArama
            // 
            txtArama.Location = new Point(1470, 15);
            txtArama.Name = "txtArama";
            txtArama.Size = new Size(307, 27);
            txtArama.TabIndex = 6;
            txtArama.TextChanged += txtArama_TextChanged;
            // 
            // btnArama
            // 
            btnArama.Location = new Point(1683, 64);
            btnArama.Name = "btnArama";
            btnArama.Size = new Size(94, 29);
            btnArama.TabIndex = 7;
            btnArama.Text = "Ara";
            btnArama.UseVisualStyleBackColor = true;
            btnArama.Click += btnArama_Click;
            // 
            // dgvCalisanlar
            // 
            dgvCalisanlar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCalisanlar.Location = new Point(6, 24);
            dgvCalisanlar.Margin = new Padding(3, 4, 3, 4);
            dgvCalisanlar.Name = "dgvCalisanlar";
            dgvCalisanlar.RowHeadersWidth = 51;
            dgvCalisanlar.Size = new Size(1113, 397);
            dgvCalisanlar.TabIndex = 0;
            // 
            // btnCalisanEkle
            // 
            btnCalisanEkle.Location = new Point(6, 482);
            btnCalisanEkle.Margin = new Padding(3, 4, 3, 4);
            btnCalisanEkle.Name = "btnCalisanEkle";
            btnCalisanEkle.Size = new Size(133, 31);
            btnCalisanEkle.TabIndex = 1;
            btnCalisanEkle.Text = "Çalışan Ekle";
            btnCalisanEkle.UseVisualStyleBackColor = true;
            btnCalisanEkle.Click += btnCalisanEkle_Click;
            // 
            // btnCalisanSil
            // 
            btnCalisanSil.Location = new Point(177, 482);
            btnCalisanSil.Margin = new Padding(3, 4, 3, 4);
            btnCalisanSil.Name = "btnCalisanSil";
            btnCalisanSil.Size = new Size(133, 31);
            btnCalisanSil.TabIndex = 6;
            btnCalisanSil.Text = "Çalışanı Sil";
            btnCalisanSil.Click += btnCalisanSil_Click;
            // 
            // btnUrunSil
            // 
            btnUrunSil.Location = new Point(1461, 685);
            btnUrunSil.Margin = new Padding(3, 4, 3, 4);
            btnUrunSil.Name = "btnUrunSil";
            btnUrunSil.Size = new Size(306, 40);
            btnUrunSil.TabIndex = 5;
            btnUrunSil.Text = "Ürünü Sil";
            btnUrunSil.UseVisualStyleBackColor = true;
            btnUrunSil.Click += btnUrunSil_Click;
            // 
            // btnUrunEkle
            // 
            btnUrunEkle.Location = new Point(1461, 622);
            btnUrunEkle.Margin = new Padding(3, 4, 3, 4);
            btnUrunEkle.Name = "btnUrunEkle";
            btnUrunEkle.Size = new Size(306, 40);
            btnUrunEkle.TabIndex = 4;
            btnUrunEkle.Text = "Ürün Ekle";
            btnUrunEkle.UseVisualStyleBackColor = true;
            btnUrunEkle.Click += btnUrunEkle_Click;
            // 
            // btnUrunGuncelle
            // 
            btnUrunGuncelle.Location = new Point(1461, 741);
            btnUrunGuncelle.Margin = new Padding(3, 4, 3, 4);
            btnUrunGuncelle.Name = "btnUrunGuncelle";
            btnUrunGuncelle.Size = new Size(306, 40);
            btnUrunGuncelle.TabIndex = 5;
            btnUrunGuncelle.Text = "Ürünü Güncelle";
            btnUrunGuncelle.UseVisualStyleBackColor = true;
            btnUrunGuncelle.Click += btnUrunGuncelle_Click;
            // 
            // btnGunlukRapor
            // 
            btnGunlukRapor.Location = new Point(3, 18);
            btnGunlukRapor.Margin = new Padding(3, 4, 3, 4);
            btnGunlukRapor.Name = "btnGunlukRapor";
            btnGunlukRapor.Size = new Size(1116, 31);
            btnGunlukRapor.TabIndex = 4;
            btnGunlukRapor.Text = "Günlük Rapor";
            btnGunlukRapor.UseVisualStyleBackColor = true;
            btnGunlukRapor.Click += btnGunlukRapor_Click;
            // 
            // btnHaftalikRapor
            // 
            btnHaftalikRapor.Location = new Point(3, 69);
            btnHaftalikRapor.Margin = new Padding(3, 4, 3, 4);
            btnHaftalikRapor.Name = "btnHaftalikRapor";
            btnHaftalikRapor.Size = new Size(1116, 31);
            btnHaftalikRapor.TabIndex = 5;
            btnHaftalikRapor.Text = "Haftalık Rapor";
            btnHaftalikRapor.UseVisualStyleBackColor = true;
            btnHaftalikRapor.Click += btnHaftalikRapor_Click;
            // 
            // btnAylikRapor
            // 
            btnAylikRapor.Location = new Point(3, 129);
            btnAylikRapor.Margin = new Padding(3, 4, 3, 4);
            btnAylikRapor.Name = "btnAylikRapor";
            btnAylikRapor.Size = new Size(1116, 31);
            btnAylikRapor.TabIndex = 5;
            btnAylikRapor.Text = "Aylık Rapor";
            btnAylikRapor.UseVisualStyleBackColor = true;
            btnAylikRapor.Click += btnAylikRapor_Click;
            // 
            // tabControl1
            // 
            tabControl1.AccessibleName = "";
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Dock = DockStyle.Top;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1801, 855);
            tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(btnArama);
            tabPage1.Controls.Add(txtArama);
            tabPage1.Controls.Add(dgvUrunler);
            tabPage1.Controls.Add(btnUrunEkle);
            tabPage1.Controls.Add(btnUrunSil);
            tabPage1.Controls.Add(btnUrunGuncelle);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1793, 822);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Ürün Yönetimi";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(dgvCalisanlar);
            tabPage2.Controls.Add(btnCalisanEkle);
            tabPage2.Controls.Add(btnCalisanSil);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1793, 822);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Kullanıcı Yönetimi";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(btnAylikRapor);
            tabPage3.Controls.Add(btnGunlukRapor);
            tabPage3.Controls.Add(btnHaftalikRapor);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(1793, 822);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Raporlar";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // YoneticiFormu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1801, 837);
            Controls.Add(tabControl1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "YoneticiFormu";
            Text = "YoneticiFormu";
            Load += YoneticiFormu_Load;
            ((System.ComponentModel.ISupportInitialize)dgvUrunler).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCalisanlar).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage3.ResumeLayout(false);
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
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private Button btnArama;
        private TextBox txtArama;
    }
}