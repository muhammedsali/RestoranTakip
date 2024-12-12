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
            // Boş alan kontrolü
            if (string.IsNullOrWhiteSpace(txtAd.Text) ||
                string.IsNullOrWhiteSpace(txtSoyad.Text) ||
                string.IsNullOrWhiteSpace(txtEposta.Text) ||
                string.IsNullOrWhiteSpace(txtSifre.Text) ||
                string.IsNullOrWhiteSpace(txtTelefon.Text) ||
                string.IsNullOrWhiteSpace(txtAdres.Text) ||
                cbRol.SelectedItem == null)
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // İşlemi sonlandır
            }

            // Parola kontrolü
            if (!IsValidPassword(txtSifre.Text))
            {
                MessageBox.Show("Parola en az 8 karakter, bir büyük harf, bir küçük harf ve bir sayı içermelidir.",
                                "Geçersiz Parola", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // İşlemi sonlandır
            }

            try
            {
                // Kullanıcı verileri
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
                    SqlCommand command = new SqlCommand("INSERT INTO Kullanicilar (Ad, Soyad, Eposta, Sifre, Telefon, Adres, Rol) VALUES (@Ad, @Soyad, @Eposta, @Sifre, @Telefon, @Adres, @Rol)", connection);
                    command.Parameters.AddWithValue("@Ad", ad);
                    command.Parameters.AddWithValue("@Soyad", soyad);
                    command.Parameters.AddWithValue("@Eposta", eposta);
                    command.Parameters.AddWithValue("@Sifre", sifre);
                    command.Parameters.AddWithValue("@Telefon", telefon);
                    command.Parameters.AddWithValue("@Adres", adres);
                    command.Parameters.AddWithValue("@Rol", rol);

                    connection.Open();
                    int result = command.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Kayıt başarılı!");

                        // Form1'i tekrar göster
                        Form1 form1 = new Form1();
                        form1.StartPosition = FormStartPosition.Manual;
                        form1.Location = this.Location;
                        form1.Show();

                        // Form2'yi kapat
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Kayıt başarısız. Lütfen tekrar deneyin.");
                    }
                }
            }
            catch (Exception ex)
            {
                // Hata mesajı göster
                MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // Parola doğrulama metodu
        private bool IsValidPassword(string password)
        {
            // Parola kriterleri: En az 8 karakter, bir büyük harf, bir küçük harf ve bir sayı
            string pattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).{8,}$";
            return System.Text.RegularExpressions.Regex.IsMatch(password, pattern);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        bool move;
        int mouse_x;
        int mouse_y;

        private void Form2_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            mouse_x = e.X; mouse_y = e.Y;
        }

        private void Form2_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
            {
                this.SetDesktopLocation(MousePosition.X - mouse_x, MousePosition.Y - mouse_y);
            }
        }

        private void Form2_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }


        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

    }
}

