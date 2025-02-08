using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using OtelRezervasyonSistemi.DataAccess.Concrete;
using System.Windows.Forms;

namespace OtelRezervasyonSistemi
{
    public partial class EditCustomerForm : Form
    {
        private int musteriId;

        // Constructor'da müşteri ID'sini alıyoruz
        public EditCustomerForm(int musteriId)
        {
            InitializeComponent();
            this.musteriId = musteriId;
            MusteriBilgileriniGetir(); // Form açılınca bilgileri yükle
        }

        // Veritabanından müşteri bilgilerini çekip form kontrollerine dolduruyoruz
        private void MusteriBilgileriniGetir()
        {
            try
            {
                using (var connection = DatabaseConnection.GetConnection())
                {
                    connection.Open();
                    string query = "SELECT * FROM Musteriler WHERE musteriID = @id";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@id", musteriId);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            txtAd.Text = reader["ad"].ToString();
                            txtSoyad.Text = reader["soyad"].ToString();
                            txtTCKN.Text = reader["tcKimlik"].ToString();
                            txtTelefon.Text = reader["telefon"].ToString();
                            txtEmail.Text = reader["email"].ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Müşteri bilgileri yüklenirken hata: " + ex.Message);
            }
        }

        // Kaydet butonuna tıklanınca
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (ValidateMusteri())
            {
                try
                {
                    using (var connection = DatabaseConnection.GetConnection())
                    {
                        connection.Open();
                        string query = @"UPDATE Musteriler 
                                       SET ad = @ad, 
                                           soyad = @soyad, 
                                           telefon = @telefon, 
                                           email = @email 
                                       WHERE musteriID = @id";

                        MySqlCommand command = new MySqlCommand(query, connection);
                        command.Parameters.AddWithValue("@ad", txtAd.Text.Trim());
                        command.Parameters.AddWithValue("@soyad", txtSoyad.Text.Trim());
                        command.Parameters.AddWithValue("@telefon", txtTelefon.Text.Trim());
                        command.Parameters.AddWithValue("@email", string.IsNullOrEmpty(txtEmail.Text.Trim()) ?
                            DBNull.Value : (object)txtEmail.Text.Trim());
                        command.Parameters.AddWithValue("@id", musteriId);

                        command.ExecuteNonQuery();
                        MessageBox.Show("Müşteri bilgileri başarıyla güncellendi!");
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Müşteri güncellenirken hata: " + ex.Message);
                }
            }
        }

        // Validasyon kontrolü
        private bool ValidateMusteri()
        {
            if (string.IsNullOrEmpty(txtAd.Text.Trim()))
            {
                MessageBox.Show("Lütfen ad giriniz!");
                txtAd.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(txtSoyad.Text.Trim()))
            {
                MessageBox.Show("Lütfen soyad giriniz!");
                txtSoyad.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(txtTelefon.Text.Trim()))
            {
                MessageBox.Show("Lütfen telefon giriniz!");
                txtTelefon.Focus();
                return false;
            }

            return true;
        }

        // İptal butonuna tıklanınca
        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}