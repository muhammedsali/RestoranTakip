using System;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace RestoranTakip
{
    public partial class CalisanFormu : Form
    {
        private string connectionString = "Data Source=DESKTOP-4U1EH3V\\SQLEXPRESS;Initial Catalog=RestoranDB;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

        public CalisanFormu()
        {
            InitializeComponent();
            SiparisleriYukle();
        }

     
        private void SiparisleriYukle()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"
                    SELECT 
                        s.SiparisID, 
                        k.Ad + ' ' + k.Soyad AS MusteriAdi, 
                        k.Telefon, 
                        k.Adres, 
                        STRING_AGG(u.UrunAdi, ', ') AS Urunler, 
                        s.ToplamFiyat, 
                        s.SiparisDurumu 
                    FROM 
                        Siparisler s
                    JOIN 
                        Kullanicilar k ON s.KullaniciID = k.KullaniciID
                    JOIN 
                        SiparisUrunler su ON s.SiparisID = su.SiparisID
                    JOIN 
                        Urunler u ON su.UrunID = u.UrunID
                    GROUP BY 
                        s.SiparisID, k.Ad, k.Soyad, k.Telefon, k.Adres, s.ToplamFiyat, s.SiparisDurumu
                    ORDER BY 
                        s.SiparisID";

                SqlDataAdapter da = new SqlDataAdapter(query, connection);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvSiparisler.DataSource = dt;
            }
        }

        // Sipariş durumunu güncelleme metodu
        private void SiparisDurumunuGuncelle(string yeniDurum, string mesaj)
        {
            if (dgvSiparisler.SelectedRows.Count > 0)
            {
                int siparisID = Convert.ToInt32(dgvSiparisler.SelectedRows[0].Cells["SiparisID"].Value);

                // Mevcut durumu kontrol et
                string? mevcutDurum = dgvSiparisler.SelectedRows[0].Cells["SiparisDurumu"].Value?.ToString();
                if (string.IsNullOrEmpty(mevcutDurum))
                {
                    MessageBox.Show("Siparişin mevcut durumu alınamadı.");
                    return;
                }

                // Durumlar arası geçiş kontrolü
                if (!DurumGecisKontrolu(mevcutDurum, yeniDurum))
                {
                    MessageBox.Show("Bir önceki adıma geçemezsiniz!");
                    return;
                }

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand("UPDATE Siparisler SET SiparisDurumu = @Durum WHERE SiparisID = @SiparisID", connection);
                    command.Parameters.AddWithValue("@Durum", yeniDurum);
                    command.Parameters.AddWithValue("@SiparisID", siparisID);

                    connection.Open();
                    command.ExecuteNonQuery();
                }

                MessageBox.Show(mesaj);
                SiparisleriYukle(); 
            }
            else
            {
                MessageBox.Show("Lütfen durumu güncellenecek bir sipariş seçin.");
            }
        }

       
        private bool DurumGecisKontrolu(string mevcutDurum, string yeniDurum)
        {
            
            string[] durumlar = { "Hazırlanıyor", "Yolda", "Teslim Edildi" };

            int mevcutIndex = Array.IndexOf(durumlar, mevcutDurum);
            int yeniIndex = Array.IndexOf(durumlar, yeniDurum);

            return yeniIndex > mevcutIndex; // Sadece ileriye geçişe izin ver
        }

     
        private void btnHazirlaniyor_Click(object sender, EventArgs e)
        {
            SiparisDurumunuGuncelle("Hazırlanıyor", "Sipariş hazırlanıyor olarak güncellendi.");
        }

     
        private void btnYolda_Click(object sender, EventArgs e)
        {
            SiparisDurumunuGuncelle("Yolda", "Sipariş yola çıktı olarak güncellendi.");
        }

  
        private void btnTeslimEdildi_Click(object sender, EventArgs e)
        {
            SiparisDurumunuGuncelle("Teslim Edildi", "Sipariş teslim edildi olarak güncellendi.");
        }

        private void CalisanFormu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
