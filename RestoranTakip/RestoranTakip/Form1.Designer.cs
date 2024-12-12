namespace RestoranTakip
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Button btnGiris;
            txtSifre = new TextBox();
            txtKullaniciAdi = new TextBox();
            linkKayit = new LinkLabel();
            button1 = new Button();
            btnGiris = new Button();
            SuspendLayout();
            // 
            // btnGiris
            // 
            btnGiris.AutoSize = true;
            btnGiris.BackColor = Color.FromArgb(255, 87, 87);
            btnGiris.BackgroundImageLayout = ImageLayout.None;
            btnGiris.FlatStyle = FlatStyle.Popup;
            btnGiris.Location = new Point(71, 534);
            btnGiris.Margin = new Padding(3, 4, 3, 4);
            btnGiris.Name = "btnGiris";
            btnGiris.Size = new Size(257, 32);
            btnGiris.TabIndex = 2;
            btnGiris.Text = "Giriş Yap";
            btnGiris.UseVisualStyleBackColor = false;
            btnGiris.Click += btnGiris_Click;
            // 
            // txtSifre
            // 
            txtSifre.BackColor = Color.FromArgb(72, 74, 74);
            txtSifre.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtSifre.ForeColor = Color.White;
            txtSifre.Location = new Point(71, 472);
            txtSifre.Margin = new Padding(3, 4, 3, 4);
            txtSifre.Name = "txtSifre";
            txtSifre.PasswordChar = '*';
            txtSifre.Size = new Size(274, 31);
            txtSifre.TabIndex = 1;
            // 
            // txtKullaniciAdi
            // 
            txtKullaniciAdi.BackColor = Color.FromArgb(72, 74, 74);
            txtKullaniciAdi.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtKullaniciAdi.ForeColor = Color.White;
            txtKullaniciAdi.Location = new Point(71, 398);
            txtKullaniciAdi.Margin = new Padding(3, 4, 3, 4);
            txtKullaniciAdi.Name = "txtKullaniciAdi";
            txtKullaniciAdi.Size = new Size(274, 31);
            txtKullaniciAdi.TabIndex = 1;
            // 
            // linkKayit
            // 
            linkKayit.AutoSize = true;
            linkKayit.BackColor = Color.Transparent;
            linkKayit.Location = new Point(271, 597);
            linkKayit.Name = "linkKayit";
            linkKayit.Size = new Size(53, 20);
            linkKayit.TabIndex = 3;
            linkKayit.TabStop = true;
            linkKayit.Text = "Üye Ol";
            linkKayit.LinkClicked += linkKayit_LinkClicked;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.BackgroundImage = Properties.Resources.pngtree_red_cross_paint_clipart_transparent_background_vector_png_image_7110618;
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Location = new Point(359, 12);
            button1.Name = "button1";
            button1.Size = new Size(43, 39);
            button1.TabIndex = 4;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Login_Page_Mobile_Prototype;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(414, 763);
            Controls.Add(button1);
            Controls.Add(linkKayit);
            Controls.Add(btnGiris);
            Controls.Add(txtKullaniciAdi);
            Controls.Add(txtSifre);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Restoran Takip Giriş Ekranı";
            TopMost = true;
            MouseDown += Form1_MouseDown;
            MouseMove += Form1_MouseMove;
            MouseUp += Form1_MouseUp;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtSifre;
        private TextBox txtKullaniciAdi;
        private Button btnGiris;
        private LinkLabel linkKayit;
        private Button button1;
    }
}
