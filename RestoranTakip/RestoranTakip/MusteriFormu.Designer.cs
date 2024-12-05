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
            btnSepeteEkle = new Button();
            dgvSepet = new DataGridView();
            lblToplamFiyat = new Label();
            btnSiparisiOnayla = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvSepet).BeginInit();
            SuspendLayout();
            // 
            // lvMenu
            // 
            lvMenu.Location = new Point(25, 12);
            lvMenu.Name = "lvMenu";
            lvMenu.Size = new Size(517, 319);
            lvMenu.TabIndex = 0;
            lvMenu.UseCompatibleStateImageBehavior = false;
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
            dgvSepet.Location = new Point(25, 437);
            dgvSepet.Name = "dgvSepet";
            dgvSepet.Size = new Size(1016, 126);
            dgvSepet.TabIndex = 2;
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
            ClientSize = new Size(1053, 754);
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
    }
}