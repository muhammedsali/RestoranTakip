using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace RestoranTakip
{
    public partial class MusteriFormu : Form
    {
        private string connectionString = "Data Source=DESKTOP-4U1EH3V\\SQLEXPRESS;Initial Catalog=RestoranDB;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";
        private DataTable sepetTablosu;

        public MusteriFormu()
        {
            InitializeComponent();
            MenuYukle();
            SepetiOlustur();
        }

        private void MenuYukle()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT ÜrünID, ÜrünAdi, Kategori, Fiyat, Aciklama FROM Urunler";
                SqlDataAdapter da = new SqlDataAdapter(query, connection);
                DataTable dt = new DataTable();
                da.Fill(dt);

                lvMenu.Items.Clear();
                foreach (DataRow row in dt.Rows)
                {
                    ListViewItem item = new ListViewItem(row["UrunID"].ToString());
                    item.SubItems.Add(row["UrunAdi"].ToString());
                    item.SubItems.Add(row["Kategori"].ToString());
                    item.SubItems.Add(row["Fiyat"].ToString());
                    item.SubItems.Add(row["Aciklama"].ToString());
                    lvMenu.Items.Add(item);
                }
            }
        }
        private void SepetiOlustur()
        {
            sepetTablosu = new DataTable();
            sepetTablosu.Columns.Add("UrunID");
            sepetTablosu.Columns.Add("UrunAdi");
            sepetTablosu.Columns.Add("Fiyat", typeof(decimal));
            sepetTablosu.Columns.Add("Miktar", typeof(int));
            sepetTablosu.Columns.Add("Toplam", typeof(decimal), "Fiyat * Miktar");

            dgvSepet.DataSource = sepetTablosu;
        }

        private void btnSepeteEkle_Click(object sender, EventArgs e)
        {

            if (lvMenu.SelectedItems.Count > 0)
            {
                ListViewItem seciliUrun = lvMenu.SelectedItems[0];
                DataRow satir = sepetTablosu.NewRow();
                satir["UrunID"] = seciliUrun.SubItems[0].Text;
                satir["UrunAdi"] = seciliUrun.SubItems[1].Text;
                satir["Fiyat"] = Convert.ToDecimal(seciliUrun.SubItems[3].Text);
                satir["Miktar"] = 1;
                sepetTablosu.Rows.Add(satir);
                SepetToplaminiGuncelle();
            }
            else
            {
                MessageBox.Show("Lütfen sepete eklemek için bir ürün seçin.");
            }
        }

        private void SepetToplaminiGuncelle()
        {
            decimal toplam = 0;
            foreach (DataRow satir in sepetTablosu.Rows)
            {
                toplam += Convert.ToDecimal(satir["Toplam"]);
            }
            lblToplamFiyat.Text = $"Toplam Fiyat: {toplam:C}";
        }

        private void btnSiparisiOnayla_Click(object sender, EventArgs e)
        {
            if (sepetTablosu.Rows.Count == 0)
            {
                MessageBox.Show("Sepetinizde ürün bulunmamaktadır. Lütfen ürün ekleyiniz.");
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();

                try
                {
                    // Sipariş kaydı
                    SqlCommand command = new SqlCommand("INSERT INTO Siparisler (KullaniciID, SiparisDurumu, ToplamFiyat) VALUES (@KullaniciID, @SiparisDurumu, @ToplamFiyat); SELECT SCOPE_IDENTITY();", connection, transaction);
                    command.Parameters.AddWithValue("@KullaniciID", /* Müşteri ID'si */ 1);
                    command.Parameters.AddWithValue("@SiparisDurumu", "Hazirlaniyor");
                    command.Parameters.AddWithValue("@ToplamFiyat", sepetTablosu.Compute("SUM(Toplam)", string.Empty));
                    int siparisID = Convert.ToInt32(command.ExecuteScalar());

                    // Sipariş Ürünleri kaydı
                    foreach (DataRow satir in sepetTablosu.Rows)
                    {
                        SqlCommand detayCommand = new SqlCommand("INSERT INTO SiparisUrunler (SiparisID, UrunID, Miktar) VALUES (@SiparisID, @UrunID, @Miktar)", connection, transaction);
                        detayCommand.Parameters.AddWithValue("@SiparisID", siparisID);
                        detayCommand.Parameters.AddWithValue("@UrunID", satir["UrunID"]);
                        detayCommand.Parameters.AddWithValue("@Miktar", satir["Miktar"]);
                        detayCommand.ExecuteNonQuery();
                    }

                    transaction.Commit();
                    MessageBox.Show("Siparişiniz başarıyla oluşturuldu!");
                    sepetTablosu.Clear();
                    SepetToplaminiGuncelle();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show($"Sipariş oluşturulurken bir hata oluştu: {ex.Message}");
                }
            }
        }
    }
}
