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


    public partial class CalisanFormu : Form
    {
        private string connectionString = "Data Source=DESKTOP-4U1EH3V\\SQLEXPRESS;Initial Catalog=RestoranDB;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";
        public CalisanFormu()
        {
            InitializeComponent();
            SiparisleriYukle();
        }

        private void SiparisleriYukle()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT SiparisID, MusteriAdi, Telefon, Adres, Urunler, ToplamFiyat, Durum FROM Siparisler";
                SqlDataAdapter da = new SqlDataAdapter(query, connection);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvSiparisler.DataSource = dt;
            }
        }


        private void btnHazirlaniyor_Click(object sender, EventArgs e)
        {
            SiparisDurumunuGuncelle("Hazirlaniyor");
        }

        private void btnYolda_Click(object sender, EventArgs e)
        {
            SiparisDurumunuGuncelle("Yolda");
        }

        private void btnTeslimEdildi_Click(object sender, EventArgs e)
        {
            SiparisDurumunuGuncelle("Teslim Edildi");
        }

        private void SiparisDurumunuGuncelle(string yeniDurum)
        {
            if (dgvSiparisler.SelectedRows.Count > 0)
            {
                int siparisID = Convert.ToInt32(dgvSiparisler.SelectedRows[0].Cells["SiparisID"].Value);

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand("UPDATE Siparisler SET Durum = @Durum WHERE SiparisID = @SiparisID", connection);
                    command.Parameters.AddWithValue("@Durum", yeniDurum);
                    command.Parameters.AddWithValue("@SiparisID", siparisID);

                    connection.Open();
                    command.ExecuteNonQuery();
                }

                MessageBox.Show("Sipariş durumu güncellendi!");
                SiparisleriYukle(); // Siparişleri yeniden yükleyin
            }
            else
            {
                MessageBox.Show("Lütfen durumu güncellenecek bir sipariş seçin.");
            }
        }
    }
}
