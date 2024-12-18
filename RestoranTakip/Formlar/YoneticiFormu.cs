using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestoranTakip
{
    public partial class YoneticiFormu : Form
    {

        private string connectionString = "Data Source=DESKTOP-4U1EH3V\\SQLEXPRESS;Initial Catalog=RestoranDB;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";


        public YoneticiFormu()
        {
            InitializeComponent();
            KullanicilariYenidenYukle();
            UrunleriYenidenYukle();

        }

        private void btnCalisanSil_Click(object sender, EventArgs e)
        {
            if (dgvCalisanlar.SelectedRows.Count > 0)
            {
                int kullaniciID = Convert.ToInt32(dgvCalisanlar.SelectedRows[0].Cells["KullaniciID"].Value);
                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        SqlTransaction transaction = connection.BeginTransaction();
                        try
                        {
                            string deleteSiparislerQuery = "DELETE FROM Siparisler WHERE KullaniciID = @KullaniciID";
                            SqlCommand siparislerCommand = new SqlCommand(deleteSiparislerQuery, connection, transaction);
                            siparislerCommand.Parameters.AddWithValue("@KullaniciID", kullaniciID);
                            siparislerCommand.ExecuteNonQuery();

                            string deleteKullaniciQuery = "DELETE FROM Kullanicilar WHERE KullaniciID = @KullaniciID";
                            SqlCommand kullaniciCommand = new SqlCommand(deleteKullaniciQuery, connection, transaction);
                            kullaniciCommand.Parameters.AddWithValue("@KullaniciID", kullaniciID);
                            kullaniciCommand.ExecuteNonQuery();

                            transaction.Commit();
                            MessageBox.Show("Çalışan başarıyla silindi.");
                            KullanicilariYenidenYukle();
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();
                            MessageBox.Show($"Bir hata oluştu: {ex.Message}");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Bir hata oluştu: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Lütfen silmek için bir çalışan seçin.");
            }
        }

        private void KullanicilariYenidenYukle()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "SELECT KullaniciID, Ad, Soyad, Eposta, Rol FROM Kullanicilar WHERE Rol = 'Calisan'";
                    SqlDataAdapter da = new SqlDataAdapter(query, connection);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgvCalisanlar.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}");
            }
        }

        private void btnCalisanEkle_Click(object sender, EventArgs e)
        {
            CalisanEkleFormu calisanEkleFormu = new CalisanEkleFormu();
            calisanEkleFormu.CalisanEklendi += CalisanEkleFormu_CalisanEklendi;
            calisanEkleFormu.Show();
        }

        private void CalisanEkleFormu_CalisanEklendi(object? sender, EventArgs e)
        {
            KullanicilariYenidenYukle(); 
        }


        //URUNLER


        private void YoneticiFormu_Load(object sender, EventArgs e)
        {
            // DataBindingComplete olayını ekleyin
            this.dgvUrunler.DataBindingComplete += new DataGridViewBindingCompleteEventHandler(this.dgvUrunler_DataBindingComplete);

            UrunleriYenidenYukle();
        }

        private void dgvUrunler_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            string bosResimYolu = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resimler", "deneme.jpg");

            if (!File.Exists(bosResimYolu))
            {
                MessageBox.Show($"Varsayılan resim dosyası bulunamadı: {bosResimYolu}");
                return;
            }

            foreach (DataGridViewRow row in dgvUrunler.Rows)
            {
                row.Height = 125;
                row.Cells["Resim"].Value = Image.FromFile(bosResimYolu);
            }

            DataGridViewCellStyle cellStyle = new DataGridViewCellStyle();
            cellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            cellStyle.NullValue = null;
            cellStyle.WrapMode = DataGridViewTriState.True;
            dgvUrunler.Columns["Resim"].DefaultCellStyle = cellStyle;
            dgvUrunler.AutoResizeColumns();
            dgvUrunler.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void UrunleriYenidenYukle()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "SELECT UrunID, UrunAdi, Kategori, Fiyat, Aciklama, ResimYolu FROM Urunler";
                    SqlDataAdapter da = new SqlDataAdapter(query, connection);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgvUrunler.DataSource = dt;

                    if (!dgvUrunler.Columns.Contains("Resim"))
                    {
                        DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
                        imageColumn.HeaderText = "Ürün Resmi";
                        imageColumn.Name = "Resim";
                        imageColumn.Width = 125; 
                        imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom; 
                        dgvUrunler.Columns.Add(imageColumn);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}");
            }
        }

        private void btnArama_Click(object sender, EventArgs e)
        {
            UrunAra(txtArama.Text.Trim());
            string aramaMetni = txtArama.Text.Trim();

            if (!string.IsNullOrEmpty(aramaMetni))
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "SELECT UrunID, UrunAdi, Kategori, Fiyat, Aciklama,ResimYolu FROM Urunler WHERE UrunAdi LIKE @AramaMetni";
                    SqlDataAdapter da = new SqlDataAdapter(query, connection);
                    da.SelectCommand.Parameters.AddWithValue("@AramaMetni", "%" + aramaMetni + "%");

                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgvUrunler.DataSource = dt;
                }
            }
            else
            {
                UrunleriYenidenYukle();
            }
        }

        private void txtArama_TextChanged(object sender, EventArgs e)
        {
            UrunAra(txtArama.Text.Trim());
        }

        private void UrunAra(string aramaMetni)
        {
            if (!string.IsNullOrEmpty(aramaMetni))
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "SELECT UrunID, UrunAdi, Kategori, Fiyat, Aciklama,ResimYolu FROM Urunler WHERE UrunAdi LIKE @AramaMetni";
                    SqlDataAdapter da = new SqlDataAdapter(query, connection);
                    da.SelectCommand.Parameters.AddWithValue("@AramaMetni", "%" + aramaMetni + "%");

                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgvUrunler.DataSource = dt;
                }
            }
            else
            {
                UrunleriYenidenYukle();
            }
        }

        private void UrunEkleFormu_UrunEklendi(object sender, EventArgs e)
        {
            UrunleriYenidenYukle();
        }


        private void btnUrunEkle_Click(object sender, EventArgs e)
        {
            UrunEkleFormu urunEkleFormu = new UrunEkleFormu();
            urunEkleFormu.UrunEklendi += UrunEkleFormu_UrunEklendi;
            urunEkleFormu.Show();
        }

        private void btnUrunSil_Click(object sender, EventArgs e)
        {
            if (dgvUrunler.SelectedRows.Count > 0)
            {
                int urunID = Convert.ToInt32(dgvUrunler.SelectedRows[0].Cells["UrunID"].Value);
                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        SqlTransaction transaction = connection.BeginTransaction();
                        try
                        {
                            string deleteSiparisUrunlerQuery = "DELETE FROM SiparisUrunler WHERE UrunID = @UrunID";
                            SqlCommand siparisUrunlerCommand = new SqlCommand(deleteSiparisUrunlerQuery, connection, transaction);
                            siparisUrunlerCommand.Parameters.AddWithValue("@UrunID", urunID);
                            siparisUrunlerCommand.ExecuteNonQuery();

                            string deleteUrunQuery = "DELETE FROM Urunler WHERE UrunID = @UrunID";
                            SqlCommand urunCommand = new SqlCommand(deleteUrunQuery, connection, transaction);
                            urunCommand.Parameters.AddWithValue("@UrunID", urunID);
                            urunCommand.ExecuteNonQuery();

                            transaction.Commit();
                            MessageBox.Show("Ürün başarıyla silindi.");
                            UrunleriYenidenYukle();
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();
                            MessageBox.Show($"Bir hata oluştu: {ex.Message}");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Bir hata oluştu: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Lütfen silmek için bir ürün seçin.");
            }
        }

        private void btnUrunGuncelle_Click(object sender, EventArgs e)
        {
            if (dgvUrunler.SelectedRows.Count > 0)
            {
                int urunID = Convert.ToInt32(dgvUrunler.SelectedRows[0].Cells["UrunID"].Value);
                UrunEkleFormu urunEkleFormu = new UrunEkleFormu(urunID);
                urunEkleFormu.UrunEklendi += UrunEkleFormu_UrunEklendi;
                urunEkleFormu.Show();
            }
            else
            {
                MessageBox.Show("Lütfen güncellemek için bir ürün seçin.");
            }
        }


        //RAPORLAR

        private void btnGunlukRapor_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Siparisler WHERE  CONVERT(date, SiparisTarihi) = CONVERT(date, GETDATE())";
                SqlDataAdapter da = new SqlDataAdapter(query, connection);
                DataTable dt = new DataTable();
                da.Fill(dt);

                // Raporu göstermek için yeni bir form oluşturulabilir veya mevcut formda DataGridView kullanılabilir
                DataGridView raporGoruntuleme = new DataGridView();
                raporGoruntuleme.DataSource = dt;
                raporGoruntuleme.Dock = DockStyle.Fill;

                Form raporFormu = new Form();
                raporFormu.Text = "Günlük Rapor";
                raporFormu.Size = new Size(800, 600);
                raporFormu.Controls.Add(raporGoruntuleme);
                raporFormu.Show();
            }
        }
        private void btnHaftalikRapor_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"
        SELECT 
            CONVERT(VARCHAR, s.SiparisTarihi, 111) AS Tarih, 
            COUNT(*) AS SiparisSayisi, 
            SUM(ToplamFiyat) AS ToplamTutar,
            STRING_AGG(u.UrunAdi, CHAR(13) + CHAR(10)) AS SatilanUrunler,
            STRING_AGG(CAST(su.Miktar AS VARCHAR), CHAR(13) + CHAR(10)) AS SatilanMiktarlar,
            STRING_AGG(k.Ad + ' ' + k.Soyad, CHAR(13) + CHAR(10)) AS SiparisVerenler
        FROM 
            Siparisler s
        JOIN 
            SiparisUrunler su ON s.SiparisID = su.SiparisID
        JOIN 
            Urunler u ON su.UrunID = u.UrunID
        JOIN 
            Kullanicilar k ON s.KullaniciID = k.KullaniciID
        WHERE 
            s.SiparisTarihi >= DATEADD(DAY, -7, GETDATE())
        GROUP BY 
            CONVERT(VARCHAR, s.SiparisTarihi, 111)
        ORDER BY 
            Tarih";

                SqlDataAdapter da = new SqlDataAdapter(query, connection);
                DataTable dt = new DataTable();
                da.Fill(dt);

                DataGridView raporGoruntuleme = new DataGridView();
                raporGoruntuleme.DataSource = dt;
                raporGoruntuleme.Dock = DockStyle.Fill;

                Form raporFormu = new Form();
                raporFormu.Text = "Haftalık Rapor";
                raporFormu.Size = new Size(800, 600);
                raporFormu.Controls.Add(raporGoruntuleme);
                raporFormu.Show();
            }
        }
        private void btnAylikRapor_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"
        SELECT 
            CONVERT(VARCHAR, DATEPART(YEAR, s.SiparisTarihi)) + '-' + 
            RIGHT('0' + CONVERT(VARCHAR, DATEPART(MONTH, s.SiparisTarihi)), 2) AS Ay, 
            COUNT(*) AS SiparisSayisi, 
            SUM(ToplamFiyat) AS ToplamTutar,
            STRING_AGG(u.UrunAdi, CHAR(13) + CHAR(10)) AS SatilanUrunler,
            STRING_AGG(CAST(su.Miktar AS VARCHAR), CHAR(13) + CHAR(10)) AS SatilanMiktarlar,
            STRING_AGG(k.Ad + ' ' + k.Soyad, CHAR(13) + CHAR(10)) AS SiparisVerenler
        FROM 
            Siparisler s
        JOIN 
            SiparisUrunler su ON s.SiparisID = su.SiparisID
        JOIN 
            Urunler u ON su.UrunID = u.UrunID
        JOIN 
            Kullanicilar k ON s.KullaniciID = k.KullaniciID
        WHERE 
            s.SiparisTarihi >= DATEADD(MONTH, -1, GETDATE())
        GROUP BY 
            CONVERT(VARCHAR, DATEPART(YEAR, s.SiparisTarihi)) + '-' + 
            RIGHT('0' + CONVERT(VARCHAR, DATEPART(MONTH, s.SiparisTarihi)), 2)
        ORDER BY 
            Ay";

                SqlDataAdapter da = new SqlDataAdapter(query, connection);
                DataTable dt = new DataTable();
                da.Fill(dt);

                DataGridView raporGoruntuleme = new DataGridView();
                raporGoruntuleme.DataSource = dt;
                raporGoruntuleme.Dock = DockStyle.Fill;

                Form raporFormu = new Form();
                raporFormu.Text = "Aylık Rapor";
                raporFormu.Size = new Size(800, 600);
                raporFormu.Controls.Add(raporGoruntuleme);
                raporFormu.Show();
            }
        }

        private void YoneticiFormu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
