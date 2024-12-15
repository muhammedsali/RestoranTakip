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
            btnHazirlaniyor = new Button();
            btnYolda = new Button();
            btnTeslimEdildi = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvSiparisler).BeginInit();
            SuspendLayout();
            // 
            // dgvSiparisler
            // 
            dgvSiparisler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSiparisler.Location = new Point(14, 45);
            dgvSiparisler.Margin = new Padding(3, 4, 3, 4);
            dgvSiparisler.Name = "dgvSiparisler";
            dgvSiparisler.RowHeadersWidth = 51;
            dgvSiparisler.Size = new Size(928, 462);
            dgvSiparisler.TabIndex = 0;
            // 
            // btnHazirlaniyor
            // 
            btnHazirlaniyor.Location = new Point(14, 534);
            btnHazirlaniyor.Margin = new Padding(3, 4, 3, 4);
            btnHazirlaniyor.Name = "btnHazirlaniyor";
            btnHazirlaniyor.Size = new Size(113, 31);
            btnHazirlaniyor.TabIndex = 1;
            btnHazirlaniyor.Text = "Hazırlanıyor";
            btnHazirlaniyor.UseVisualStyleBackColor = true;
            btnHazirlaniyor.Click += btnHazirlaniyor_Click;
            // 
            // btnYolda
            // 
            btnYolda.Location = new Point(184, 534);
            btnYolda.Margin = new Padding(3, 4, 3, 4);
            btnYolda.Name = "btnYolda";
            btnYolda.Size = new Size(113, 31);
            btnYolda.TabIndex = 1;
            btnYolda.Text = "Yolda";
            btnYolda.UseVisualStyleBackColor = true;
            btnYolda.Click += btnYolda_Click;
            // 
            // btnTeslimEdildi
            // 
            btnTeslimEdildi.Location = new Point(342, 534);
            btnTeslimEdildi.Margin = new Padding(3, 4, 3, 4);
            btnTeslimEdildi.Name = "btnTeslimEdildi";
            btnTeslimEdildi.Size = new Size(113, 31);
            btnTeslimEdildi.TabIndex = 1;
            btnTeslimEdildi.Text = "Teslim Edildi";
            btnTeslimEdildi.UseVisualStyleBackColor = true;
            btnTeslimEdildi.Click += btnTeslimEdildi_Click;
            // 
            // CalisanFormu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1126, 600);
            Controls.Add(btnTeslimEdildi);
            Controls.Add(btnYolda);
            Controls.Add(btnHazirlaniyor);
            Controls.Add(dgvSiparisler);
            Margin = new Padding(3, 4, 3, 4);
            Name = "CalisanFormu";
            Text = "CalisanFormu";
            FormClosing += CalisanFormu_FormClosing;
            ((System.ComponentModel.ISupportInitialize)dgvSiparisler).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvSiparisler;
        private Button btnHazirlaniyor;
        private Button btnYolda;
        private Button btnTeslimEdildi;
    }
}