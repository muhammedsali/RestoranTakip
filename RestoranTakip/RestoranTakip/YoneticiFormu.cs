﻿using Microsoft.Data.SqlClient;
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

        private void UrunleriYukle()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT UrunID, UrunAdi, Kategori, Fiyat, Aciklama FROM Urunler";
                SqlDataAdapter da = new SqlDataAdapter(query, connection);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvUrunler.DataSource = dt;
            }
        }

        private void btnCalisanEkle_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Çalışan bilgilerini girme formu oluştur
                string ad = "Yeni Ad"; // Burada çalışan bilgilerini al
                string soyad = "Yeni Soyad";
                string eposta = "email@example.com";
                string telefon = "123456789";

                string query = "INSERT INTO Calisanlar (Ad, Soyad, Eposta, Telefon) VALUES (@Ad, @Soyad, @Eposta, @Telefon)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Ad", ad);
                command.Parameters.AddWithValue("@Soyad", soyad);
                command.Parameters.AddWithValue("@Eposta", eposta);
                command.Parameters.AddWithValue("@Telefon", telefon);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();

                MessageBox.Show("Çalışan başarıyla eklendi.");
                CalisanlariYukle(); // Çalışan listesini güncelle
            }
        }

        private void btnCalisanSil_Click(object sender, EventArgs e)
        {
            if (dgvCalisanlar.SelectedRows.Count > 0)
            {
                int calisanID = Convert.ToInt32(dgvCalisanlar.SelectedRows[0].Cells["CalisanID"].Value);

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "DELETE FROM Calisanlar WHERE CalisanID = @CalisanID";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@CalisanID", calisanID);

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();

                    MessageBox.Show("Çalışan başarıyla silindi.");
                    CalisanlariYukle(); // Çalışan listesini güncelle
                }
            }
            else
            {
                MessageBox.Show("Lütfen silmek için bir çalışan seçin.");
            }
        }
        private void btnUrunEkle_Click(object sender, EventArgs e)
        {
            UrunEkleFormu urunEkleFormu = new UrunEkleFormu();
            urunEkleFormu.UrunEklendi += UrunEkleFormu_UrunEklendi;
            urunEkleFormu.Show();
        }


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


        private void btnGunlukRapor_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Siparisler WHERE CONVERT(date, SiparisTarihi) = CONVERT(date, GETDATE())";
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
                CONVERT(VARCHAR, SiparisTarihi, 111) AS Tarih, 
                COUNT(*) AS SiparisSayisi, 
                SUM(ToplamFiyat) AS ToplamTutar
            FROM 
                Siparisler
            WHERE 
                SiparisTarihi >= DATEADD(DAY, -7, GETDATE())
            GROUP BY 
                CONVERT(VARCHAR, SiparisTarihi, 111)
            ORDER BY 
                Tarih";

                SqlDataAdapter da = new SqlDataAdapter(query, connection);
                DataTable dt = new DataTable();
                da.Fill(dt);

                // Örneğin, sonuçları bir MessageBox'ta görüntüleyebilirsiniz:
                string rapor = "Tarih\tSipariş Sayısı\tToplam Tutar\n";
                foreach (DataRow row in dt.Rows)
                {
                    rapor += $"{row["Tarih"]}\t{row["SiparisSayisi"]}\t{row["ToplamTutar"]:C}\n";
                }
                MessageBox.Show(rapor, "Haftalık Sipariş Raporu");
            }
        }


        private void btnAylikRapor_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"
            SELECT 
                CONVERT(VARCHAR, DATEPART(YEAR, SiparisTarihi)) + '-' + 
                RIGHT('0' + CONVERT(VARCHAR, DATEPART(MONTH, SiparisTarihi)), 2) AS Ay, 
                COUNT(*) AS SiparisSayisi, 
                SUM(ToplamFiyat) AS ToplamTutar
            FROM 
                Siparisler
            WHERE 
                SiparisTarihi >= DATEADD(MONTH, -1, GETDATE())
            GROUP BY 
                CONVERT(VARCHAR, DATEPART(YEAR, SiparisTarihi)) + '-' + 
                RIGHT('0' + CONVERT(VARCHAR, DATEPART(MONTH, SiparisTarihi)), 2)
            ORDER BY 
                Ay";

                SqlDataAdapter da = new SqlDataAdapter(query, connection);
                DataTable dt = new DataTable();
                da.Fill(dt);

                // Örneğin, sonuçları bir MessageBox'ta görüntüleyebilirsiniz:
                string rapor = "Ay\tSipariş Sayısı\tToplam Tutar\n";
                foreach (DataRow row in dt.Rows)
                {
                    rapor += $"{row["Ay"]}\t{row["SiparisSayisi"]}\t{row["ToplamTutar"]:C}\n";
                }
                MessageBox.Show(rapor, "Aylık Sipariş Raporu");
            }
        }

    }
}