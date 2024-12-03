namespace RestoranTakip
{
    partial class MusteriFormu
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
            lvMenu = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            btnSepeteEkle = new Button();
            dgvSepet = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            lblToplamFiyat = new Label();
            btnSiparisiOnayla = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvSepet).BeginInit();
            SuspendLayout();
            // 
            // lvMenu
            // 
            lvMenu.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5 });
            lvMenu.Location = new Point(12, 29);
            lvMenu.Name = "lvMenu";
            lvMenu.Size = new Size(517, 319);
            lvMenu.TabIndex = 0;
            lvMenu.UseCompatibleStateImageBehavior = false;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "ÜrünID";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "ÜrünAdı";
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Kategori";
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Fiyat";
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Açıklama";
            // 
            // btnSepeteEkle
            // 
            btnSepeteEkle.Location = new Point(227, 369);
            btnSepeteEkle.Name = "btnSepeteEkle";
            btnSepeteEkle.Size = new Size(89, 47);
            btnSepeteEkle.TabIndex = 1;
            btnSepeteEkle.Text = "Sepete Ekle";
            btnSepeteEkle.UseVisualStyleBackColor = true;
            btnSepeteEkle.Click += btnSepeteEkle_Click;
            // 
            // dgvSepet
            // 
            dgvSepet.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSepet.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            dgvSepet.Location = new Point(25, 437);
            dgvSepet.Name = "dgvSepet";
            dgvSepet.Size = new Size(504, 150);
            dgvSepet.TabIndex = 2;
            // 
            // Column1
            // 
            Column1.HeaderText = "ÜrünID";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "ÜrünAdı";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Fiyat";
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "Miktar";
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.HeaderText = "Toplam";
            Column5.Name = "Column5";
            // 
            // lblToplamFiyat
            // 
            lblToplamFiyat.AutoSize = true;
            lblToplamFiyat.Location = new Point(25, 599);
            lblToplamFiyat.Name = "lblToplamFiyat";
            lblToplamFiyat.Size = new Size(38, 15);
            lblToplamFiyat.TabIndex = 3;
            lblToplamFiyat.Text = "label1";
            // 
            // btnSiparisiOnayla
            // 
            btnSiparisiOnayla.Location = new Point(150, 626);
            btnSiparisiOnayla.Name = "btnSiparisiOnayla";
            btnSiparisiOnayla.Size = new Size(234, 23);
            btnSiparisiOnayla.TabIndex = 4;
            btnSiparisiOnayla.Text = "Siparişi Onayla";
            btnSiparisiOnayla.UseVisualStyleBackColor = true;
            btnSiparisiOnayla.Click += btnSiparisiOnayla_Click;
            // 
            // MusteriFormu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(551, 736);
            Controls.Add(btnSiparisiOnayla);
            Controls.Add(lblToplamFiyat);
            Controls.Add(dgvSepet);
            Controls.Add(btnSepeteEkle);
            Controls.Add(lvMenu);
            Name = "MusteriFormu";
            Text = "MusteriFormu";
            ((System.ComponentModel.ISupportInitialize)dgvSepet).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView lvMenu;
        private Button btnSepeteEkle;
        private DataGridView dgvSepet;
        private Label lblToplamFiyat;
        private Button btnSiparisiOnayla;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
    }
}