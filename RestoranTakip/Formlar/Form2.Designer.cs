namespace RestoranTakip
{
    partial class Form2
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
            txtSoyad = new TextBox();
            txtAd = new TextBox();
            txtSifre = new TextBox();
            txtEposta = new TextBox();
            txtAdres = new TextBox();
            txtTelefon = new TextBox();
            cbRol = new ComboBox();
            btnKayit = new Button();
            button1 = new Button();
            linkLabel1 = new LinkLabel();
            SuspendLayout();
            // 
            // txtSoyad
            // 
            txtSoyad.BackColor = Color.FromArgb(72, 74, 74);
            txtSoyad.Font = new Font("Segoe UI", 10.2F);
            txtSoyad.ForeColor = Color.White;
            txtSoyad.Location = new Point(70, 338);
            txtSoyad.Margin = new Padding(3, 4, 3, 4);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(286, 30);
            txtSoyad.TabIndex = 2;
            // 
            // txtAd
            // 
            txtAd.BackColor = Color.FromArgb(72, 74, 74);
            txtAd.Font = new Font("Segoe UI", 10.2F);
            txtAd.ForeColor = Color.White;
            txtAd.Location = new Point(71, 277);
            txtAd.Margin = new Padding(3, 4, 3, 4);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(286, 30);
            txtAd.TabIndex = 1;
            // 
            // txtSifre
            // 
            txtSifre.BackColor = Color.FromArgb(72, 74, 74);
            txtSifre.Font = new Font("Segoe UI", 10.2F);
            txtSifre.ForeColor = Color.White;
            txtSifre.Location = new Point(69, 446);
            txtSifre.Margin = new Padding(3, 4, 3, 4);
            txtSifre.Name = "txtSifre";
            txtSifre.PasswordChar = '*';
            txtSifre.Size = new Size(286, 30);
            txtSifre.TabIndex = 4;
            // 
            // txtEposta
            // 
            txtEposta.BackColor = Color.FromArgb(72, 74, 74);
            txtEposta.Font = new Font("Segoe UI", 10.2F);
            txtEposta.ForeColor = Color.White;
            txtEposta.Location = new Point(69, 392);
            txtEposta.Margin = new Padding(3, 4, 3, 4);
            txtEposta.Name = "txtEposta";
            txtEposta.Size = new Size(286, 30);
            txtEposta.TabIndex = 3;
            // 
            // txtAdres
            // 
            txtAdres.BackColor = Color.FromArgb(72, 74, 74);
            txtAdres.Font = new Font("Segoe UI", 10.2F);
            txtAdres.ForeColor = Color.White;
            txtAdres.Location = new Point(68, 566);
            txtAdres.Margin = new Padding(3, 4, 3, 4);
            txtAdres.Name = "txtAdres";
            txtAdres.Size = new Size(286, 30);
            txtAdres.TabIndex = 6;
            // 
            // txtTelefon
            // 
            txtTelefon.BackColor = Color.FromArgb(72, 74, 74);
            txtTelefon.Font = new Font("Segoe UI", 10.2F);
            txtTelefon.ForeColor = Color.White;
            txtTelefon.Location = new Point(70, 509);
            txtTelefon.Margin = new Padding(3, 4, 3, 4);
            txtTelefon.Name = "txtTelefon";
            txtTelefon.Size = new Size(286, 30);
            txtTelefon.TabIndex = 5;
            // 
            // cbRol
            // 
            cbRol.BackColor = Color.FromArgb(72, 74, 74);
            cbRol.ForeColor = Color.White;
            cbRol.FormattingEnabled = true;
            cbRol.Items.AddRange(new object[] { "Musteri", "Calisan", "Yonetici" });
            cbRol.Location = new Point(243, 608);
            cbRol.Margin = new Padding(3, 4, 3, 4);
            cbRol.Name = "cbRol";
            cbRol.Size = new Size(114, 28);
            cbRol.TabIndex = 7;
            // 
            // btnKayit
            // 
            btnKayit.BackColor = Color.Transparent;
            btnKayit.BackgroundImageLayout = ImageLayout.None;
            btnKayit.FlatStyle = FlatStyle.Popup;
            btnKayit.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnKayit.ForeColor = Color.Black;
            btnKayit.Location = new Point(110, 656);
            btnKayit.Margin = new Padding(3, 4, 3, 4);
            btnKayit.Name = "btnKayit";
            btnKayit.Size = new Size(205, 32);
            btnKayit.TabIndex = 8;
            btnKayit.Text = "Kayıt Ol";
            btnKayit.UseVisualStyleBackColor = false;
            btnKayit.Click += btnKayit_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.BackgroundImage = Properties.Resources.pngtree_red_cross_paint_clipart_transparent_background_vector_png_image_7110618;
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Location = new Point(372, -2);
            button1.Name = "button1";
            button1.Size = new Size(43, 39);
            button1.TabIndex = 10;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.BackColor = Color.Transparent;
            linkLabel1.LinkColor = Color.FromArgb(255, 87, 87);
            linkLabel1.Location = new Point(151, 705);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(104, 20);
            linkLabel1.TabIndex = 9;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Zaten Üyeyim!";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.frm2s;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(414, 763);
            Controls.Add(linkLabel1);
            Controls.Add(button1);
            Controls.Add(btnKayit);
            Controls.Add(cbRol);
            Controls.Add(txtTelefon);
            Controls.Add(txtEposta);
            Controls.Add(txtAdres);
            Controls.Add(txtSifre);
            Controls.Add(txtAd);
            Controls.Add(txtSoyad);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            MouseDown += Form2_MouseDown;
            MouseMove += Form2_MouseMove;
            MouseUp += Form2_MouseUp;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtSoyad;
        private TextBox txtAd;
        private TextBox txtSifre;
        private TextBox txtEposta;
        private TextBox txtAdres;
        private TextBox txtTelefon;
        private ComboBox cbRol;
        private Button btnKayit;
        private Button button1;
        private LinkLabel linkLabel1;
    }
}