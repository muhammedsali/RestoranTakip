namespace RestoranTakip
{
    partial class SepetFormu
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
            dgvSepet = new DataGridView();
            btnSepettenCikar = new Button();
            lblToplamFiyat = new Label();
            btnSiparisiOnayla = new Button();
            odeme1 = new CheckBox();
            checkBox1 = new CheckBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvSepet).BeginInit();
            SuspendLayout();
            // 
            // dgvSepet
            // 
            dgvSepet.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSepet.Location = new Point(38, 12);
            dgvSepet.Name = "dgvSepet";
            dgvSepet.RowHeadersWidth = 51;
            dgvSepet.Size = new Size(677, 329);
            dgvSepet.TabIndex = 0;
            // 
            // btnSepettenCikar
            // 
            btnSepettenCikar.Location = new Point(38, 356);
            btnSepettenCikar.Name = "btnSepettenCikar";
            btnSepettenCikar.Size = new Size(115, 45);
            btnSepettenCikar.TabIndex = 1;
            btnSepettenCikar.Text = "Ürünü Çıkart";
            btnSepettenCikar.UseVisualStyleBackColor = true;
            btnSepettenCikar.Click += btnSepettenCikar_Click;
            // 
            // lblToplamFiyat
            // 
            lblToplamFiyat.AutoSize = true;
            lblToplamFiyat.Location = new Point(844, 195);
            lblToplamFiyat.Name = "lblToplamFiyat";
            lblToplamFiyat.Size = new Size(0, 20);
            lblToplamFiyat.TabIndex = 3;
            // 
            // btnSiparisiOnayla
            // 
            btnSiparisiOnayla.Location = new Point(844, 287);
            btnSiparisiOnayla.Name = "btnSiparisiOnayla";
            btnSiparisiOnayla.Size = new Size(134, 45);
            btnSiparisiOnayla.TabIndex = 4;
            btnSiparisiOnayla.Text = "Siparisi Onayla";
            btnSiparisiOnayla.UseVisualStyleBackColor = true;
            btnSiparisiOnayla.Click += btnSiparisiOnayla_Click;
            // 
            // odeme1
            // 
            odeme1.AutoSize = true;
            odeme1.Location = new Point(844, 84);
            odeme1.Name = "odeme1";
            odeme1.Size = new Size(118, 24);
            odeme1.TabIndex = 5;
            odeme1.Text = "Posla Ödeme";
            odeme1.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(844, 128);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(131, 24);
            checkBox1.TabIndex = 6;
            checkBox1.Text = "Nakitle Odeme";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(844, 51);
            label1.Name = "label1";
            label1.Size = new Size(167, 20);
            label1.TabIndex = 7;
            label1.Text = "Kapıda Odeme Yöntemi";
            // 
            // SepetFormu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1205, 475);
            Controls.Add(label1);
            Controls.Add(checkBox1);
            Controls.Add(odeme1);
            Controls.Add(btnSiparisiOnayla);
            Controls.Add(lblToplamFiyat);
            Controls.Add(btnSepettenCikar);
            Controls.Add(dgvSepet);
            Name = "SepetFormu";
            Text = "SepetFormu";
            ((System.ComponentModel.ISupportInitialize)dgvSepet).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvSepet;
        private Button btnSepettenCikar;
        private Label lblToplamFiyat;
        private Button btnSiparisiOnayla;
        private CheckBox odeme1;
        private CheckBox checkBox1;
        private Label label1;
    }
}