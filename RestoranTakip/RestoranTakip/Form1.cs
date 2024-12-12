using System;
using Microsoft.Data.SqlClient;
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
                MessageBox.Show("Kullan�c� ad� bo� b�rak�lamaz.");
                return;
            }

            if (string.IsNullOrEmpty(sifre))
            {
                MessageBox.Show("�ifre bo� b�rak�lamaz.");
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "SELECT * FROM Kullanicilar WHERE Eposta = @Eposta AND Sifre = @Sifre";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Eposta", kullaniciAdi);
                        command.Parameters.AddWithValue("@Sifre", sifre);

                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                reader.Read();
                                // Veritaban�ndan gelen de�erin DBNull olup olmad���n� kontrol edin
                                string? rol = reader.IsDBNull(reader.GetOrdinal("Rol")) ? null : reader["Rol"].ToString();
                                MessageBox.Show("Giri� ba�ar�l�!");

                                if (rol == "Musteri")
                                {
                                    MusteriFormu musteriFormu = new MusteriFormu();
                                    musteriFormu.Show();
                                }
                                else if (rol == "Calisan")
                                {
                                    CalisanFormu calisanFormu = new CalisanFormu();
                                    calisanFormu.Show();
                                }
                                else if (rol == "Yonetici")
                                {
                                    YoneticiFormu yoneticiFormu = new YoneticiFormu();
                                    yoneticiFormu.Show();
                                }
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Kullan�c� ad� veya �ifre hatal�.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata olu�tu: {ex.Message}");
            }
        }

        private void linkKayit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 form2 = new Form2(); // Mevcut Form1'i g�nderiyoruz
            form2.StartPosition = FormStartPosition.Manual; // Formun konumunu koru
            form2.Location = this.Location; // Ayn� konuma ayarla
            form2.Show();
            this.Hide(); // Form1'i gizle
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        bool move;
        int mouse_x;
        int mouse_y;

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            mouse_x = e.X; mouse_y = e.Y;
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
            {
                this.SetDesktopLocation(MousePosition.X - mouse_x, MousePosition.Y - mouse_y);
            }
        }

        private void txtKullaniciAdi_Enter(object sender, EventArgs e)
        {
            if(txtKullaniciAdi.Text=="Kullan�c� Ad�n�z")
            {
                txtKullaniciAdi.Text = "";
                txtKullaniciAdi.ForeColor = Color.White;
            }
        }

        private void txtKullaniciAdi_Leave(object sender, EventArgs e)
        {
            if (txtKullaniciAdi.Text == "")
            {
                txtKullaniciAdi.Text = "Kullan�c� Ad�n�z";
                txtKullaniciAdi.ForeColor = Color.Silver;

            }
        }
    }
}
