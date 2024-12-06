namespace MusteriFormu
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
            this.tvKategoriler = new System.Windows.Forms.TreeView();
            this.lvUrunler = new System.Windows.Forms.ListView();
            this.pbUrunResmi = new System.Windows.Forms.PictureBox();
            this.btnSepeteEkle = new System.Windows.Forms.Button();
            this.lblToplamFiyat = new System.Windows.Forms.Label();
            this.btnSiparisiOnayla = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(this.pbUrunResmi)).BeginInit();
            this.SuspendLayout();

            // tvKategoriler
            this.tvKategoriler.Location = new System.Drawing.Point(12, 12);
            this.tvKategoriler.Size = new System.Drawing.Size(200, 400);
            this.tvKategoriler.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvKategoriler_AfterSelect);

            // lvUrunler
            this.lvUrunler.Location = new System.Drawing.Point(220, 12);
            this.lvUrunler.Size = new System.Drawing.Size(400, 400);
            this.lvUrunler.View = System.Windows.Forms.View.Details;
            this.lvUrunler.FullRowSelect = true;
            this.lvUrunler.Columns.Add("Resim", 100);
            this.lvUrunler.Columns.Add("Ürün Adı", 150);
            this.lvUrunler.Columns.Add("Fiyat", 80);
            this.lvUrunler.SelectedIndexChanged += new System.EventHandler(this.lvUrunler_SelectedIndexChanged);

            // pbUrunResmi
            this.pbUrunResmi.Location = new System.Drawing.Point(630, 12);
            this.pbUrunResmi.Size = new System.Drawing.Size(200, 200);

            // btnSepeteEkle
            this.btnSepeteEkle.Location = new System.Drawing.Point(630, 220);
            this.btnSepeteEkle.Size = new System.Drawing.Size(150, 30);
            this.btnSepeteEkle.Text = "Sepete Ekle";
            this.btnSepeteEkle.Click += new System.EventHandler(this.btnSepeteEkle_Click);

            // lblToplamFiyat
            this.lblToplamFiyat.Location = new System.Drawing.Point(12, 420);
            this.lblToplamFiyat.Size = new System.Drawing.Size(200, 30);
            this.lblToplamFiyat.Text = "Toplam Fiyat: 0";

            // btnSiparisiOnayla
            this.btnSiparisiOnayla.Location = new System.Drawing.Point(630, 420);
            this.btnSiparisiOnayla.Size = new System.Drawing.Size(150, 30);
            this.btnSiparisiOnayla.Text = "Siparişi Onayla";
            this.btnSiparisiOnayla.Click += new System.EventHandler(this.btnSiparisiOnayla_Click);

            // MusteriFormu
            this.ClientSize = new System.Drawing.Size(844, 461);
            this.Controls.Add(this.tvKategoriler);
            this.Controls.Add(this.lvUrunler);
            this.Controls.Add(this.pbUrunResmi);
            this.Controls.Add(this.btnSepeteEkle);
            this.Controls.Add(this.lblToplamFiyat);
            this.Controls.Add(this.btnSiparisiOnayla);
            this.Name = "MusteriFormu";
            this.Text = "Müşteri Formu";
            ((System.ComponentModel.ISupportInitialize)(this.pbUrunResmi)).EndInit();
            this.ResumeLayout(false);
        }


        #endregion

        private TreeView tvKategoriler;
        private ListView lvUrunler;
        private PictureBox pbUrunResmi;
        private Label lblToplamFiyat;
        private Button btnSiparisiOnayla;
        private Button btnSepeteEkle;
    }
}
