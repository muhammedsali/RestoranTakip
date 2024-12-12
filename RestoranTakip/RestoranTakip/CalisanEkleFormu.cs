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
    public partial class CalisanEkleFormu : Form
    {
        private string connectionString = "Data Source=DESKTOP-4U1EH3V\\SQLEXPRESS;Initial Catalog=RestoranDB;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";

        public event EventHandler? CalisanEklendi;


        public CalisanEkleFormu()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            string ad = txtAd.Text.Trim();
            string soyad = txtSoyad.Text.Trim();
            string eposta = txtEposta.Text.Trim();
            string sifre = txtSifre.Text.Trim();
            string telefon = txtTelefon.Text.Trim();
            string adres = txtAdres.Text.Trim();
            string rol = "Calisan"; // Çalışan rolü

            if (string.IsNullOrEmpty(ad) || string.IsNullOrEmpty(soyad) || string.IsNullOrEmpty(eposta) || string.IsNullOrEmpty(sifre) || string.IsNullOrEmpty(telefon))
            {
                MessageBox.Show("Lütfen tüm alanları doğru şekilde doldurun.");
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "INSERT INTO Kullanicilar (Ad, Soyad, Eposta, Sifre, Telefon, Adres, Rol) VALUES (@Ad, @Soyad, @Eposta, @Sifre, @Telefon, @Adres, @Rol)";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Ad", ad);
                        command.Parameters.AddWithValue("@Soyad", soyad);
                        command.Parameters.AddWithValue("@Eposta", eposta);
                        command.Parameters.AddWithValue("@Sifre", sifre);
                        command.Parameters.AddWithValue("@Telefon", telefon);
                        command.Parameters.AddWithValue("@Adres", adres);
                        command.Parameters.AddWithValue("@Rol", rol);

                        connection.Open();
                        command.ExecuteNonQuery();
                        MessageBox.Show("Çalışan başarıyla eklendi!");
                        CalisanEklendi?.Invoke(this, EventArgs.Empty); // Olayı tetikleyin
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}");
            }
        }
    
    }
}
