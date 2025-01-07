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
            dgvSiparisler.Location = new Point(12, 34);
            dgvSiparisler.Name = "dgvSiparisler";
            dgvSiparisler.RowHeadersWidth = 51;
            dgvSiparisler.Size = new Size(812, 346);
            dgvSiparisler.TabIndex = 0;
            // 
            // btnHazirlaniyor
            // 
            btnHazirlaniyor.BackColor = Color.Gold;
            btnHazirlaniyor.Location = new Point(12, 400);
            btnHazirlaniyor.Name = "btnHazirlaniyor";
            btnHazirlaniyor.Size = new Size(99, 23);
            btnHazirlaniyor.TabIndex = 1;
            btnHazirlaniyor.Text = "Hazırlanıyor";
            btnHazirlaniyor.UseVisualStyleBackColor = false;
            btnHazirlaniyor.Click += btnHazirlaniyor_Click;
            // 
            // btnYolda
            // 
            btnYolda.BackColor = Color.Coral;
            btnYolda.Location = new Point(161, 400);
            btnYolda.Name = "btnYolda";
            btnYolda.Size = new Size(99, 23);
            btnYolda.TabIndex = 1;
            btnYolda.Text = "Yolda";
            btnYolda.UseVisualStyleBackColor = false;
            btnYolda.Click += btnYolda_Click;
            // 
            // btnTeslimEdildi
            // 
            btnTeslimEdildi.BackColor = Color.Firebrick;
            btnTeslimEdildi.ForeColor = SystemColors.ButtonFace;
            btnTeslimEdildi.Location = new Point(299, 400);
            btnTeslimEdildi.Name = "btnTeslimEdildi";
            btnTeslimEdildi.Size = new Size(99, 23);
            btnTeslimEdildi.TabIndex = 1;
            btnTeslimEdildi.Text = "Teslim Edildi";
            btnTeslimEdildi.UseVisualStyleBackColor = false;
            btnTeslimEdildi.Click += btnTeslimEdildi_Click;
            // 
            // CalisanFormu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCoral;
            ClientSize = new Size(985, 450);
            Controls.Add(btnTeslimEdildi);
            Controls.Add(btnYolda);
            Controls.Add(btnHazirlaniyor);
            Controls.Add(dgvSiparisler);
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