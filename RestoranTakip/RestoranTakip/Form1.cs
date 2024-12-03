namespace RestoranTakip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = txtKullaniciAdi.Text;
            string sifre = txtSifre.Text;

            // Veritabaný baðlantýsý
            SqlConnection connection = new SqlConnection("your_connection_string");
            SqlCommand command = new SqlCommand("SELECT * FROM Kullanýcýlar WHERE Eposta = @Eposta AND Þifre = @Þifre", connection);
            command.Parameters.AddWithValue("@Eposta", kullaniciAdi);
            command.Parameters.AddWithValue("@Þifre", sifre);

            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                // Kullanýcý baþarýlý giriþ yaptý
                MessageBox.Show("Giriþ baþarýlý!");
                // Kullanýcý rolüne göre ana sayfayý aç
            }
            else
            {
                MessageBox.Show("Kullanýcý adý veya þifre hatalý.");
            }
            connection.Close();
        }

        //private void linkKayit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        //{
        //    Form2 kayitFormu = new Form2();
        //    kayitFormu.Show();
        //}
    }
}



