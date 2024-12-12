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
            CalisanlariYukle();
            UrunleriYenidenYukle(); // Mevcut ürünleri yüklemek için
            KullanicilariYenidenYukle();

        }

        private void CalisanlariYukle()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT KullaniciID, Ad, Soyad, Eposta, Telefon FROM Kullanicilar";
                SqlDataAdapter da = new SqlDataAdapter(query, connection);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvCalisanlar.DataSource = dt;
            }
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
                            // Önce ilgili tablolardaki kayıtları sil
                            string deleteSiparislerQuery = "DELETE FROM Siparisler WHERE KullaniciID = @KullaniciID";
                            SqlCommand siparislerCommand = new SqlCommand(deleteSiparislerQuery, connection, transaction);
                            siparislerCommand.Parameters.AddWithValue("@KullaniciID", kullaniciID);
                            siparislerCommand.ExecuteNonQuery();

                            // Ardından kullanıcıyı sil
                            string deleteKullaniciQuery = "DELETE FROM Kullanicilar WHERE KullaniciID = @KullaniciID";
                            SqlCommand kullaniciCommand = new SqlCommand(deleteKullaniciQuery, connection, transaction);
                            kullaniciCommand.Parameters.AddWithValue("@KullaniciID", kullaniciID);
                            kullaniciCommand.ExecuteNonQuery();

                            transaction.Commit();
                            MessageBox.Show("Çalışan başarıyla silindi.");
                            KullanicilariYenidenYukle(); // Kullanıcı listesi güncelleniyor
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
            CalisanlariYenidenYukle(); // Yeni çalışan eklendikten sonra çalışanları yeniden yükleyin
        }

        private void CalisanlariYenidenYukle()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "SELECT KullaniciID, Ad, Soyad, Eposta, Telefon, Adres, Rol FROM Kullanicilar WHERE Rol = 'Calisan'";
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



        //URUNLER



        private void UrunEkleFormu_UrunEklendi(object sender, EventArgs e)
        {
            UrunleriYenidenYukle(); // Yeni ürün eklendikten sonra ürünleri yeniden yükleyin
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
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}");
            }
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
                            // Önce ilgili SiparisUrunler kayıtlarını sil
                            string deleteSiparisUrunlerQuery = "DELETE FROM SiparisUrunler WHERE UrunID = @UrunID";
                            SqlCommand siparisUrunlerCommand = new SqlCommand(deleteSiparisUrunlerQuery, connection, transaction);
                            siparisUrunlerCommand.Parameters.AddWithValue("@UrunID", urunID);
                            siparisUrunlerCommand.ExecuteNonQuery();

                            // Ardından ürünü sil
                            string deleteUrunQuery = "DELETE FROM Urunler WHERE UrunID = @UrunID";
                            SqlCommand urunCommand = new SqlCommand(deleteUrunQuery, connection, transaction);
                            urunCommand.Parameters.AddWithValue("@UrunID", urunID);
                            urunCommand.ExecuteNonQuery();

                            transaction.Commit();
                            MessageBox.Show("Ürün başarıyla silindi.");
                            UrunleriYenidenYukle(); // Ürün listesi güncelleniyor
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

                // Raporu göstermek için yeni bir form oluşturulabilir veya mevcut formda DataGridView kullanılabilir
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

                // Raporu göstermek için yeni bir form oluşturulabilir veya mevcut formda DataGridView kullanılabilir
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



    }
}
