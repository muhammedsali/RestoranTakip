using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace RestoranTakip
{
    public partial class SiparislerFormu : Form
    {
        private string connectionString = "Data Source=DESKTOP-4U1EH3V\\SQLEXPRESS;Initial Catalog=RestoranDB;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";

        public SiparislerFormu()
        {
            InitializeComponent();
            SiparisleriGetir();
        }

        private void SiparisleriGetir()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"
                    SELECT 
                        s.SiparisID,
                                    u.UrunAdi,
                        su.Miktar,
                        su.Miktar * u.Fiyat AS ToplamFiyat,
                        s.SiparisDurumu
                    FROM 
                        Siparisler s
                    INNER JOIN 
                        SiparisUrunler su ON s.SiparisID = su.SiparisID
                    INNER JOIN 
                        Urunler u ON su.UrunID = u.UrunID
                    ORDER BY 
                        s.SiparisTarihi DESC";

                SqlDataAdapter da = new SqlDataAdapter(query, connection);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvSiparisler.DataSource = dt;
                dgvSiparisler.Columns["SiparisID"].Visible = false; // ID sütununu gizle
                dgvSiparisler.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }

        
    }
}
