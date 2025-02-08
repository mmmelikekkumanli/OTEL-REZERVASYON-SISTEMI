using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using OtelRezervasyonSistemi.DataAccess.Concrete;

namespace OtelRezervasyonSistemi
{
    public partial class NewRoomForm : Form
    {
        public NewRoomForm()
        {
            InitializeComponent();
           
        }
        private void btnKaydet_Click_1(object sender, EventArgs e)
        {
            if (ValidateOda())
            {
                try
                {
                    using (var connection = DatabaseConnection.GetConnection())
                    {
                        connection.Open();
                        string query = @"INSERT INTO Odalar 
                                       (odaNumarasi, odaTipi, fiyat, durum) 
                                       VALUES 
                                       (@odaNo, @odaTipi, @fiyat, @durum)";

                        MySqlCommand command = new MySqlCommand(query, connection);
                        command.Parameters.AddWithValue("@odaNo", txtOdaNo.Text.Trim());
                        command.Parameters.AddWithValue("@odaTipi", cmbOdaTipi.SelectedItem.ToString());
                        command.Parameters.AddWithValue("@fiyat", Convert.ToDecimal(txtFiyat.Text));
                        command.Parameters.AddWithValue("@durum", true); // Yeni oda varsayılan olarak müsait

                        command.ExecuteNonQuery();

                        MessageBox.Show("Oda başarıyla kaydedildi!");
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Oda kaydedilirken hata oluştu: " + ex.Message);
                }
            }
        }

        private bool ValidateOda()
        {
            if (string.IsNullOrEmpty(txtOdaNo.Text.Trim()))
            {
                MessageBox.Show("Lütfen oda numarası giriniz!");
                txtOdaNo.Focus();
                return false;
            }

            if (cmbOdaTipi.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen oda tipi seçiniz!");
                cmbOdaTipi.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(txtFiyat.Text.Trim()))
            {
                MessageBox.Show("Lütfen fiyat giriniz!");
                txtFiyat.Focus();
                return false;
            }

            decimal fiyat;
            if (!decimal.TryParse(txtFiyat.Text.Trim(), out fiyat) || fiyat <= 0)
            {
                MessageBox.Show("Lütfen geçerli bir fiyat giriniz!");
                txtFiyat.Focus();
                return false;
            }

            // Oda numarası benzersiz mi kontrolü
            if (OdaNumarasiKontrol(txtOdaNo.Text.Trim()))
            {
                MessageBox.Show("Bu oda numarası zaten kullanılmakta!");
                txtOdaNo.Focus();
                return false;
            }

            return true;
        }

        private bool OdaNumarasiKontrol(string odaNo)
        {
            try
            {
                using (var connection = DatabaseConnection.GetConnection())
                {
                    connection.Open();
                    string query = "SELECT COUNT(*) FROM Odalar WHERE odaNumarasi = @odaNo";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@odaNo", odaNo);

                    int count = Convert.ToInt32(command.ExecuteScalar());
                    return count > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Oda numarası kontrolü yapılırken hata oluştu: " + ex.Message);
                return false;
            }
        }

        private void btnIptal_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}

    

