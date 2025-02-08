using System;
using System.Data;
using System.Windows.Forms;
using OtelRezervasyonSistemi.DataAccess.Concrete;
using OtelRezervasyonSistemi.Entities.Concrete;
using OtelRezervasyonSistemi.Business.Concrete;
using MySql.Data.MySqlClient;

namespace OtelRezervasyonSistemi
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            this.AcceptButton = btnGiris;
            this.CancelButton = btnCikis;

            DatabaseConnection.TestDatabaseConnection(); // Bağlantıyı test et
        }

        private void btnGiris_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtKullaniciAdi.Text) || string.IsNullOrEmpty(txtSifre.Text))
                {
                    MessageBox.Show("Kullanıcı adı ve şifre boş bırakılamaz!", "Uyarı",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                using (var connection = DatabaseConnection.GetConnection())
                {
                    connection.Open();

                    if (connection.State == ConnectionState.Open)
                    {
                        bool girisBasarili = GirisKontrol();

                        if (girisBasarili)
                        {
                            MainForm anaForm = new MainForm();
                            this.Hide();
                            anaForm.ShowDialog();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Kullanıcı adı veya şifre hatalı!", "Hata",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtSifre.Clear();
                            txtKullaniciAdi.Focus();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Giriş yapılırken bir hata oluştu. Lütfen tekrar deneyiniz.",
                    "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Hata loglanabilir
                Console.WriteLine($"Hata Detayı: {ex.Message}\nStack Trace: {ex.StackTrace}");
            }
        }

        private bool GirisKontrol()
        {
            try
            {
                using (var connection = DatabaseConnection.GetConnection())
                {
                    connection.Open();
                    string query = "SELECT COUNT(*) FROM Kullanicilar WHERE kullaniciAdi = @kullaniciAdi AND sifre = @sifre";

                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@kullaniciAdi", txtKullaniciAdi.Text.Trim());
                    command.Parameters.AddWithValue("@sifre", txtSifre.Text.Trim());

                    int count = Convert.ToInt32(command.ExecuteScalar());
                    return count > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Giriş kontrolü sırasında hata oluştu.",
                    "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Hata loglanabilir
                Console.WriteLine($"Giriş Kontrolü Hatası: {ex.Message}");
                return false;
            }
        }

        private void btnCikis_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtSifre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnGiris_Click_1(sender, e);
            }
        }

        private void pnlSag_Paint(object sender, PaintEventArgs e)
        {
            // Paint eventi gerekli değilse kaldırılabilir
        }
    }
}