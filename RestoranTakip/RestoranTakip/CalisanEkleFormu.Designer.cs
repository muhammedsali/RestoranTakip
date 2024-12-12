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
            SuspendLayout();
            // 
            // txtAd
            // 
            txtAd.Location = new Point(125, 32);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(125, 27);
            txtAd.TabIndex = 0;
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(125, 83);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(125, 27);
            txtSoyad.TabIndex = 0;
            // 
            // txtEposta
            // 
            txtEposta.Location = new Point(125, 131);
            txtEposta.Name = "txtEposta";
            txtEposta.Size = new Size(125, 27);
            txtEposta.TabIndex = 0;
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(125, 180);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(125, 27);
            txtSifre.TabIndex = 0;
            // 
            // txtTelefon
            // 
            txtTelefon.Location = new Point(125, 228);
            txtTelefon.Name = "txtTelefon";
            txtTelefon.Size = new Size(125, 27);
            txtTelefon.TabIndex = 0;
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(74, 344);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(94, 29);
            btnKaydet.TabIndex = 1;
            btnKaydet.Text = "button1";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // txtAdres
            // 
            txtAdres.Location = new Point(125, 270);
            txtAdres.Name = "txtAdres";
            txtAdres.Size = new Size(125, 27);
            txtAdres.TabIndex = 0;
            // 
            // CalisanEkleFormu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}