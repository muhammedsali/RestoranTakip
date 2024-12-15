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
            Siparisler = new Button();
            flpUrunler = new FlowLayoutPanel();
            Sepet = new Button();
            lblToplamFiyat = new Label();
            flpUrunler1 = new FlowLayoutPanel();
            label3 = new Label();
            flpUrunler2 = new FlowLayoutPanel();
            label1 = new Label();
            label2 = new Label();
            Filtre = new TextBox();
            SuspendLayout();
            // 
            // Siparisler
            // 
            Siparisler.Location = new Point(1130, 30);
            Siparisler.Name = "Siparisler";
            Siparisler.Size = new Size(108, 29);
            Siparisler.TabIndex = 8;
            Siparisler.Text = "Siparislerim";
            Siparisler.UseVisualStyleBackColor = true;
            Siparisler.Click += siparis_Click;
            // 
            // flpUrunler
            // 
            flpUrunler.Location = new Point(23, 81);
            flpUrunler.Name = "flpUrunler";
            flpUrunler.Size = new Size(1215, 250);
            flpUrunler.TabIndex = 11;
            // 
            // Sepet
            // 
            Sepet.Location = new Point(1006, 31);
            Sepet.Name = "Sepet";
            Sepet.Size = new Size(94, 29);
            Sepet.TabIndex = 12;
            Sepet.Text = "Sepetim";
            Sepet.UseVisualStyleBackColor = true;
            Sepet.Click += Sepet_Click;
            // 
            // lblToplamFiyat
            // 
            lblToplamFiyat.AutoSize = true;
            lblToplamFiyat.Location = new Point(234, 30);
            lblToplamFiyat.Name = "lblToplamFiyat";
            lblToplamFiyat.Size = new Size(0, 20);
            lblToplamFiyat.TabIndex = 15;
            // 
            // flpUrunler1
            // 
            flpUrunler1.Location = new Point(23, 373);
            flpUrunler1.Name = "flpUrunler1";
            flpUrunler1.Size = new Size(1215, 250);
            flpUrunler1.TabIndex = 18;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.Location = new Point(23, 626);
            label3.Name = "label3";
            label3.Size = new Size(90, 28);
            label3.TabIndex = 22;
            label3.Text = "Tatlılar";
            // 
            // flpUrunler2
            // 
            flpUrunler2.Location = new Point(23, 657);
            flpUrunler2.Name = "flpUrunler2";
            flpUrunler2.Size = new Size(1215, 250);
            flpUrunler2.TabIndex = 19;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(23, 50);
            label1.Name = "label1";
            label1.Size = new Size(109, 28);
            label1.TabIndex = 20;
            label1.Text = "FastFood";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(24, 334);
            label2.Name = "label2";
            label2.Size = new Size(114, 28);
            label2.TabIndex = 21;
            label2.Text = "İçecekler";
            // 
            // Filtre
            // 
            Filtre.Location = new Point(842, 33);
            Filtre.Name = "Filtre";
            Filtre.Size = new Size(125, 27);
            Filtre.TabIndex = 9;
            Filtre.Text = "Filtre";
            // 
            // MusteriFormu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1418, 1055);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(flpUrunler2);
            Controls.Add(flpUrunler1);
            Controls.Add(lblToplamFiyat);
            Controls.Add(Sepet);
            Controls.Add(flpUrunler);
            Controls.Add(Filtre);
            Controls.Add(Siparisler);
            Margin = new Padding(3, 4, 3, 4);
            Name = "MusteriFormu";
            Text = "MusteriFormu";
            FormClosing += MusteriFormu_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button Siparisler;
        private FlowLayoutPanel flpUrunler;
        private Button Sepet;
        private Label lblToplamFiyat;
        private FlowLayoutPanel flpUrunler1;
        private FlowLayoutPanel flpUrunler2;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox Filtre;
    }
}