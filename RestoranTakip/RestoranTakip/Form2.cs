using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient; // System.Data.SqlClient yerine Microsoft.Data.SqlClient kullanın


namespace RestoranTakip
{
    public partial class Form2 : Form
    {

        // Yeni bağlantı dizesi
        private string connectionString = "Data Source=DESKTOP-4U1EH3V\\SQLEXPRESS;Initial Catalog=RestoranDB;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnKayit_Click(object sender, EventArgs e)
        {

            string ad = txtAd.Text;
            string soyad = txtSoyad.Text;
            string eposta = txtEposta.Text;
            string sifre = txtSifre.Text;
            string telefon = txtTelefon.Text;
            string adres = txtAdres.Text;
            string rol = cbRol.SelectedItem.ToString();

            // Veritabanı bağlantısı
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand("INSERT INTO Kullanıcılar (Ad, Soyad, Eposta, Şifre, Telefon, Adres, Rol) VALUES (@Ad, @Soyad, @Eposta, @Şifre, @Telefon, @Adres, @Rol)", connection);
                command.Parameters.AddWithValue("@Ad", ad);
                command.Parameters.AddWithValue("@Soyad", soyad);
                command.Parameters.AddWithValue("@Eposta", eposta);
                command.Parameters.AddWithValue("@Şifre", sifre);
                command.Parameters.AddWithValue("@Telefon", telefon);
                command.Parameters.AddWithValue("@Adres", adres);
                command.Parameters.AddWithValue("@Rol", rol);

                connection.Open();
                int result = command.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("Kayıt başarılı!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Kayıt başarısız. Lütfen tekrar deneyin.");
                }
            }
        }
    }
}

