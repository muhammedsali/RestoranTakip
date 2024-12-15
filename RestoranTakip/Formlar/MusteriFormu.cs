using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
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
            MusteriFormu_Load();
            SepetiOlustur();
        }

        private void MusteriFormu_Load()
        {
            flpUrunler.Controls.Clear();
            flpUrunler1.Controls.Clear();
            flpUrunler2.Controls.Clear();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT UrunID, UrunAdi, Kategori, Fiyat, Aciklama, ResimYolu FROM Urunler";
                SqlDataAdapter da = new SqlDataAdapter(query, connection);
                DataTable dt = new DataTable();
                da.Fill(dt);



                foreach (DataRow row in dt.Rows)
                {
                    string kategori = row["Kategori"].ToString();
                    string dosyaYolu = Path.Combine(Application.StartupPath, row["ResimYolu"].ToString());


                    Panel urunPanel = new Panel
                    {
                        Size = new Size(150, 220),
                        BorderStyle = BorderStyle.FixedSingle
                    };

                    PictureBox pb = new PictureBox
                    {
                        Size = new Size(140, 160),
                        ImageLocation = row["ResimYolu"].ToString(),
                        SizeMode = PictureBoxSizeMode.StretchImage
                    };
                    pb.ImageLocation = dosyaYolu;

                    Label lblAd = new Label
                    {
                        Text = row["UrunAdi"].ToString(),
                        AutoSize = false,
                        TextAlign = ContentAlignment.MiddleCenter,
                        Dock = DockStyle.Bottom,
                        Height = 20,

                    };

                    Button btnEkle = new Button
                    {
                        Text = "Sepete Ekle",
                        Dock = DockStyle.Bottom,
                        Margin = new Padding(0, 0, 15, 0),
                        Tag = row,
                        Height = 30

                    };

                    btnEkle.Click += (s, e) => SepeteEkle(row);

                    urunPanel.Controls.Add(pb);
                    urunPanel.Controls.Add(lblAd);
                    urunPanel.Controls.Add(btnEkle);

                    if (kategori == "FastFood")
                    {
                        flpUrunler.Controls.Add(urunPanel);
                    }
                    else if (kategori == "içecek")
                    {
                        flpUrunler1.Controls.Add(urunPanel);
                    }
                    else if (kategori == "Tatlı")
                    {
                        flpUrunler2.Controls.Add(urunPanel);
                    }
                }
            }
        }

        private void SepetiOlustur()
        {
            sepetTablosu = new DataTable();

            sepetTablosu.Columns.Add("UrunAdi");
            sepetTablosu.Columns.Add("Fiyat", typeof(decimal));
            sepetTablosu.Columns.Add("Miktar", typeof(int));
            sepetTablosu.Columns.Add("Toplam", typeof(decimal), "Fiyat * Miktar");
            sepetTablosu.Columns.Add("UrunID", typeof(int));
        }

        private void SepeteEkle(DataRow urun)
        {
            string urunAdi = urun["UrunAdi"].ToString();
            decimal fiyat = Convert.ToDecimal(urun["Fiyat"]);
            int urunID = Convert.ToInt32(urun["UrunID"]);

            DataRow mevcutSatir = sepetTablosu.AsEnumerable()
                .FirstOrDefault(r => r.Field<string>("UrunAdi") == urunAdi);

            if (mevcutSatir != null)
            {
                mevcutSatir["Miktar"] = Convert.ToInt32(mevcutSatir["Miktar"]) + 1;
                lblToplamFiyat.Text = $"Urun arttirildi -> {mevcutSatir["UrunAdi"]}";
            }
            else
            {
                DataRow yeniSatir = sepetTablosu.NewRow();
                yeniSatir["UrunAdi"] = urunAdi;
                yeniSatir["Fiyat"] = fiyat;
                yeniSatir["Miktar"] = 1;
                yeniSatir["UrunID"] = urunID;
                sepetTablosu.Rows.Add(yeniSatir);
                lblToplamFiyat.Text = $"Urun sepete eklendi -> {yeniSatir["UrunAdi"]}";
            }

        }


        private void btnSiparisiOnayla_Click(object sender, EventArgs e)
        {
            if (sepetTablosu.Rows.Count == 0)
            {
                MessageBox.Show("Sepetiniz boş!");
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();

                try
                {
                    SqlCommand command = new SqlCommand(
                        "INSERT INTO Siparisler (KullaniciID, SiparisDurumu, ToplamFiyat) VALUES (@KullaniciID, @SiparisDurumu, @ToplamFiyat); SELECT SCOPE_IDENTITY();",
                        connection,
                        transaction
                    );
                    command.Parameters.AddWithValue("@KullaniciID", 1);
                    command.Parameters.AddWithValue("@SiparisDurumu", "Hazırlanıyor");
                    command.Parameters.AddWithValue("@ToplamFiyat", sepetTablosu.Compute("SUM(Toplam)", string.Empty));
                    int siparisID = Convert.ToInt32(command.ExecuteScalar());

                    foreach (DataRow satir in sepetTablosu.Rows)
                    {
                        SqlCommand detayCommand = new SqlCommand(
                            "INSERT INTO SiparisUrunler (SiparisID, UrunID, Miktar) VALUES (@SiparisID, @UrunID, @Miktar)",
                            connection,
                            transaction
                        );
                        detayCommand.Parameters.AddWithValue("@SiparisID", siparisID);
                        detayCommand.Parameters.AddWithValue("@UrunID", satir["UrunID"]);
                        detayCommand.Parameters.AddWithValue("@Miktar", satir["Miktar"]);
                        detayCommand.ExecuteNonQuery();
                    }

                    transaction.Commit();
                    MessageBox.Show("Siparişiniz başarıyla oluşturuldu!");
                    sepetTablosu.Clear();

                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Hata oluştu! " + ex.Message);
                }
            }
        }



        private void siparis_Click(object sender, EventArgs e)
        {
            SiparislerFormu siparislerFormu = new SiparislerFormu();
            siparislerFormu.ShowDialog();
        }
        private void Sepet_Click(object sender, EventArgs e)
        {
            SepetFormu sepetFormu = new SepetFormu(sepetTablosu);
            sepetFormu.ShowDialog();
        }

        private void MusteriFormu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
