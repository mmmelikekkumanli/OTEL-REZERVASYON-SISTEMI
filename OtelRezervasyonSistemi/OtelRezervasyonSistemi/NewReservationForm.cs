using MySql.Data.MySqlClient;
using OtelRezervasyonSistemi.DataAccess.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtelRezervasyonSistemi
{
    public partial class NewReservationForm : Form
    {
        private int rezervasyonId = 0; // Sınıf seviyesinde değişken

        public NewReservationForm()
        {
            InitializeComponent();
            MusterileriYukle();
            OdalariYukle();
        }

        public NewReservationForm(int rezervasyonId)
        {
            InitializeComponent();
            this.rezervasyonId = rezervasyonId;
            MusterileriYukle();
            OdalariYukle();
            RezervasyonBilgileriniGetir();
        }

        private void MusterileriYukle()
        {
            try
            {
                using (var connection = DatabaseConnection.GetConnection())
                {
                    connection.Open();
                    string query = "SELECT musteriID, CONCAT(ad, ' ', soyad, ' - ', tcKimlik) as MusteriInfo FROM Musteriler";

                    MySqlCommand command = new MySqlCommand(query, connection);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    cmbMusteriler.DataSource = dt;
                    cmbMusteriler.DisplayMember = "MusteriInfo";
                    cmbMusteriler.ValueMember = "musteriID";
                    cmbMusteriler.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Müşteriler yüklenirken hata oluştu: " + ex.Message);
            }
        }

        private void OdalariYukle()
        {
            try
            {
                using (var connection = DatabaseConnection.GetConnection())
                {
                    connection.Open();
                    string query = @"SELECT odaID, 
                                   CONCAT(odaNumarasi, ' - ', odaTipi, ' (', fiyat, ' TL)') as OdaInfo 
                                   FROM Odalar WHERE durum = true";

                    MySqlCommand command = new MySqlCommand(query, connection);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    cmbOdalar.DataSource = dt;
                    cmbOdalar.DisplayMember = "OdaInfo";
                    cmbOdalar.ValueMember = "odaID";
                    cmbOdalar.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Odalar yüklenirken hata oluştu: " + ex.Message);
            }
        }

        private void RezervasyonBilgileriniGetir()
        {
            try
            {
                using (var connection = DatabaseConnection.GetConnection())
                {
                    connection.Open();
                    string query = "SELECT * FROM Rezervasyonlar WHERE rezervasyonID = @id";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@id", rezervasyonId);
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Müşteri seçimi
                            cmbMusteriler.SelectedValue = reader["musteriID"];

                            // Oda seçimi
                            cmbOdalar.SelectedValue = reader["odaID"];

                            // Tarihler
                            if (dtpGirisTarihi != null)
                                dtpGirisTarihi.Value = Convert.ToDateTime(reader["girisTarihi"]);
                            if (dtpCikisTarihi != null)
                                dtpCikisTarihi.Value = Convert.ToDateTime(reader["cikisTarihi"]);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Rezervasyon bilgileri yüklenirken hata: " + ex.Message);
            }
        }
        // Sınıf seviyesinde değişkenler
        private decimal gunlukFiyat = 0;
        private int gunSayisi = 0;

        private void dtpGirisTarihi_ValueChanged(object sender, EventArgs e)
        {
            // Giriş tarihi bugünden küçük olamaz
            if (dtpGirisTarihi.Value.Date < DateTime.Now.Date)
            {
                MessageBox.Show("Giriş tarihi geçmiş bir tarih olamaz!");
                dtpGirisTarihi.Value = DateTime.Now;
                return;
            }

            // Giriş tarihi çıkış tarihinden büyük olamaz
            if (dtpGirisTarihi.Value.Date > dtpCikisTarihi.Value.Date)
            {
                dtpCikisTarihi.Value = dtpGirisTarihi.Value.AddDays(1);
            }

            FiyatHesapla();
        }

        private void cmbOdalar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbOdalar.SelectedIndex != -1)
            {
                try
                {
                    using (var connection = DatabaseConnection.GetConnection())
                    {
                        connection.Open();
                        string query = "SELECT fiyat FROM Odalar WHERE odaID = @odaId";
                        MySqlCommand command = new MySqlCommand(query, connection);
                        command.Parameters.AddWithValue("@odaId", cmbOdalar.SelectedValue);

                        gunlukFiyat = Convert.ToDecimal(command.ExecuteScalar());
                        FiyatHesapla();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Oda fiyatı alınırken hata oluştu: " + ex.Message);
                }
            }
        }
        private void FiyatHesapla()
        {
            if (dtpGirisTarihi.Value != null && dtpCikisTarihi.Value != null)
            {
                gunSayisi = (dtpCikisTarihi.Value.Date - dtpGirisTarihi.Value.Date).Days;
                decimal toplamFiyat = gunlukFiyat * gunSayisi;

                // Konaklama süresi Label'ı
                lblGunDeger.Text = $"{gunSayisi} Gün";

                // Toplam fiyat Label'ı
                lblTutarDeger.Text = $"{toplamFiyat:C2}";
            }
        }

       
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (ValidateRezervasyon())
            {
                try
                {
                    using (var connection = DatabaseConnection.GetConnection())
                    {
                        connection.Open();
                        string query = @"INSERT INTO Rezervasyonlar 
                               (musteriID, odaID, girisTarihi, cikisTarihi, toplamFiyat, durum)
                               VALUES 
                               (@musteriId, @odaId, @girisTarihi, @cikisTarihi, @toplamFiyat, @durum)";

                        MySqlCommand command = new MySqlCommand(query, connection);
                        command.Parameters.AddWithValue("@musteriId", cmbMusteriler.SelectedValue);
                        command.Parameters.AddWithValue("@odaId", cmbOdalar.SelectedValue);
                        command.Parameters.AddWithValue("@girisTarihi", dtpGirisTarihi.Value.Date);
                        command.Parameters.AddWithValue("@cikisTarihi", dtpCikisTarihi.Value.Date);
                        command.Parameters.AddWithValue("@toplamFiyat", gunlukFiyat * gunSayisi);
                        command.Parameters.AddWithValue("@durum", "Aktif");

                        command.ExecuteNonQuery();

                        // Odanın durumunu güncelle
                        string updateOdaQuery = "UPDATE Odalar SET durum = false WHERE odaID = @odaId";
                        command = new MySqlCommand(updateOdaQuery, connection);
                        command.Parameters.AddWithValue("@odaId", cmbOdalar.SelectedValue);
                        command.ExecuteNonQuery();

                        MessageBox.Show("Rezervasyon başarıyla kaydedildi!");
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Rezervasyon kaydedilirken hata oluştu: " + ex.Message);
                }
            }
        }

        private bool ValidateRezervasyon()
        {
            if (cmbMusteriler.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen müşteri seçiniz!");
                return false;
            }

            if (cmbOdalar.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen oda seçiniz!");
                return false;
            }

            if (dtpGirisTarihi.Value.Date < DateTime.Now.Date)
            {
                MessageBox.Show("Giriş tarihi geçmiş bir tarih olamaz!");
                return false;
            }

            if (dtpCikisTarihi.Value.Date <= dtpGirisTarihi.Value.Date)
            {
                MessageBox.Show("Çıkış tarihi giriş tarihinden sonra olmalıdır!");
                return false;
            }

            return true;
        }

        private void dtpCikisTarihi_ValueChanged(object sender, EventArgs e)
        {
            // Çıkış tarihi giriş tarihinden küçük olamaz
            if (dtpCikisTarihi.Value.Date <= dtpGirisTarihi.Value.Date)
            {
                MessageBox.Show("Çıkış tarihi giriş tarihinden sonra olmalıdır!");
                dtpCikisTarihi.Value = dtpGirisTarihi.Value.AddDays(1);
                return;
            }

            FiyatHesapla();
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnYeniMusteri_Click(object sender, EventArgs e)
        {
            NewCustomerForm yeniMusteri = new NewCustomerForm();
            if (yeniMusteri.ShowDialog() == DialogResult.OK)
            {
                MusterileriYukle();
            }
        }
    }
}