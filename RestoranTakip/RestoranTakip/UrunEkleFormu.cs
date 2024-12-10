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
    public partial class UrunEkleFormu : Form
    {
         private string connectionString = "Data Source=DESKTOP-4U1EH3V\\SQLEXPRESS;Initial Catalog=RestoranDB;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

        private int? urunID = null;
        public event EventHandler? UrunEklendi;



        public UrunEkleFormu()
        {
            InitializeComponent();
        }
        public UrunEkleFormu(int urunID) : this() { 
            this.urunID = urunID; 
            UrunBilgileriniYukle(); 
        }

        private void UrunBilgileriniYukle()
        {
            if (urunID.HasValue)
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        string query = "SELECT UrunAdi, Kategori, Fiyat, Aciklama, ResimYolu FROM Urunler WHERE UrunID = @UrunID";
                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@UrunID", urunID.Value);

                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                txtUrunAdi.Text = reader["UrunAdi"].ToString();
                                txtKategori.Text = reader["Kategori"].ToString();
                                nudFiyat.Value = Convert.ToDecimal(reader["Fiyat"]);
                                txtAciklama.Text = reader["Aciklama"].ToString();
                                txtResimYolu.Text = reader["ResimYolu"].ToString();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Bir hata oluştu: {ex.Message}");
                }
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            string urunAdi = txtUrunAdi.Text.Trim();
            string kategori = txtKategori.Text.Trim();
            decimal fiyat = nudFiyat.Value;
            string aciklama = txtAciklama.Text.Trim();
            string resimYolu = txtResimYolu.Text.Trim();

            if (string.IsNullOrEmpty(urunAdi) || string.IsNullOrEmpty(kategori) || fiyat <= 0 || string.IsNullOrEmpty(resimYolu))
            {
                MessageBox.Show("Lütfen tüm alanları doğru şekilde doldurun.");
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query;
                    if (urunID.HasValue)
                    {
                        // Ürünü güncelle
                        query = "UPDATE Urunler SET UrunAdi = @UrunAdi, Kategori = @Kategori, Fiyat = @Fiyat, Aciklama = @Aciklama, ResimYolu = @ResimYolu WHERE UrunID = @UrunID";
                    }
                    else
                    {
                        // Yeni ürün ekle
                        query = "INSERT INTO Urunler (UrunAdi, Kategori, Fiyat, Aciklama, ResimYolu) VALUES (@UrunAdi, @Kategori, @Fiyat, @Aciklama, @ResimYolu)";
                    }

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@UrunAdi", urunAdi);
                        command.Parameters.AddWithValue("@Kategori", kategori);
                        command.Parameters.AddWithValue("@Fiyat", fiyat);
                        command.Parameters.AddWithValue("@Aciklama", aciklama);
                        command.Parameters.AddWithValue("@ResimYolu", resimYolu);

                        if (urunID.HasValue)
                        {
                            command.Parameters.AddWithValue("@UrunID", urunID.Value);
                        }

                        connection.Open();
                        command.ExecuteNonQuery();
                        MessageBox.Show(urunID.HasValue ? "Ürün başarıyla güncellendi!" : "Ürün başarıyla eklendi!");
                        UrunEklendi?.Invoke(this, EventArgs.Empty); // Olayı tetikleyin
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}");
            }
        }



        private void btnIptal_Click(object sender, EventArgs e)
        {

        }
    }
}
