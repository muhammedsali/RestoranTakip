using System;
using Microsoft.Data.SqlClient; // Doðru namespace kullanýmý
using System.Windows.Forms;

namespace RestoranTakip
{
    public partial class Form1 : Form
    {
        private string connectionString = "Data Source=DESKTOP-4U1EH3V\\SQLEXPRESS;Initial Catalog=RestoranDB;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

        public Form1()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = txtKullaniciAdi.Text.Trim();
            string sifre = txtSifre.Text.Trim();

            if (string.IsNullOrEmpty(kullaniciAdi))
            {
                MessageBox.Show("Kullanýcý adý boþ býrakýlamaz.");
                return;
            }

            if (string.IsNullOrEmpty(sifre))
            {
                MessageBox.Show("Þifre boþ býrakýlamaz.");
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "SELECT * FROM Kullanýcýlar WHERE Eposta = @Eposta AND Þifre = @Þifre";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Eposta", kullaniciAdi);
                        command.Parameters.AddWithValue("@Þifre", sifre);

                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                reader.Read();
                                string rol = reader["Rol"].ToString();
                                MessageBox.Show("Giriþ baþarýlý!");

                                if (rol == "Müþteri")
                                {
                                    MusteriFormu musteriFormu = new MusteriFormu();
                                    musteriFormu.Show();
                                }
                                else if (rol == "Çalýþan")
                                {
                                    CalisanFormu calisanFormu = new CalisanFormu();
                                    calisanFormu.Show();
                                }
                                else if (rol == "Yönetici")
                                {
                                    YoneticiFormu yoneticiFormu = new YoneticiFormu();
                                    yoneticiFormu.Show();
                                }
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Kullanýcý adý veya þifre hatalý.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluþtu: {ex.Message}");
            }
        }

        private void linkKayit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 kayitFormu = new Form2();
            kayitFormu.Show();
        }
    }
}
