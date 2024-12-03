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

            // Veritaban� ba�lant�s�
            SqlConnection connection = new SqlConnection("your_connection_string");
            SqlCommand command = new SqlCommand("SELECT * FROM Kullan�c�lar WHERE Eposta = @Eposta AND �ifre = @�ifre", connection);
            command.Parameters.AddWithValue("@Eposta", kullaniciAdi);
            command.Parameters.AddWithValue("@�ifre", sifre);

            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                // Kullan�c� ba�ar�l� giri� yapt�
                MessageBox.Show("Giri� ba�ar�l�!");
                // Kullan�c� rol�ne g�re ana sayfay� a�
            }
            else
            {
                MessageBox.Show("Kullan�c� ad� veya �ifre hatal�.");
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



