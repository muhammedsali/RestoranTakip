using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace RestoranTakip
{
    public partial class SepetFormu : Form
    {
        private DataTable sepetTablosu;
        private string connectionString = "Data Source=DESKTOP-4U1EH3V\\SQLEXPRESS;Initial Catalog=RestoranDB;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";

        public SepetFormu(DataTable sepet)
        {

            InitializeComponent();
            SepetiOlustur();
            sepetTablosu = sepet;
            dgvSepet.DataSource = sepetTablosu;
            dgvSepet.Columns["UrunID"].Visible = false; // Kullanıcıya göstermiyoruz
            SepetToplaminiGuncelle();
        }
        private void SepetiOlustur()
        {
            sepetTablosu = new DataTable();

            sepetTablosu.Columns.Add("UrunAdi");
            sepetTablosu.Columns.Add("Fiyat", typeof(decimal));
            sepetTablosu.Columns.Add("Miktar", typeof(int));
            sepetTablosu.Columns.Add("Toplam", typeof(decimal), "Fiyat * Miktar");
            sepetTablosu.Columns.Add("UrunID", typeof(int)); 

            dgvSepet.DataSource = sepetTablosu;
            dgvSepet.Columns["UrunID"].Visible = false;
        }
        private void SepetToplaminiGuncelle()
        {
            decimal toplam = sepetTablosu.AsEnumerable().Sum(r => r.Field<decimal>("Toplam"));
            lblToplamFiyat.Text = $"Toplam Fiyat: {toplam:C}";
        }

        private void btnSepettenCikar_Click(object sender, EventArgs e)
        {
            if (dgvSepet.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvSepet.SelectedRows)
                {
                    dgvSepet.Rows.Remove(row);
                }
                SepetToplaminiGuncelle();
            }
            else
            {
                MessageBox.Show("Lütfen kaldırılacak bir ürün seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSiparisiOnayla_Click(object sender, EventArgs e)
        {
            if (sepetTablosu.Rows.Count == 0)
            {
                MessageBox.Show("Sepet boş. Sipariş oluşturulamıyor.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if(!odeme1.Checked && checkBox1.Checked) {
                MessageBox.Show("Bir ödeme seçeneği seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                    SepetToplaminiGuncelle();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Hata oluştu! " + ex.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void odeme1_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            odeme1.Checked = false;
        }








    }
}
