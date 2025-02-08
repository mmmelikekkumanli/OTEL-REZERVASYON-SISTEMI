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
    public partial class EditRoomForm : Form
    {
        private int odaId;
        private string eskiOdaNo;

        public EditRoomForm(int odaId)
        {
            InitializeComponent();
            this.odaId = odaId;
            cmbOdaTipi.Items.AddRange(new string[] { "Tek Kişilik", "Çift Kişilik", "Suit" });
            OdaBilgileriniGetir();
        }

        private void OdaBilgileriniGetir()
        {
            try
            {
                using (var connection = DatabaseConnection.GetConnection())
                {
                    connection.Open();
                    string query = "SELECT * FROM Odalar WHERE odaID = @id";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@id", odaId);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            txtOdaNo.Text = reader["odaNumarasi"].ToString();
                            eskiOdaNo = txtOdaNo.Text;
                            cmbOdaTipi.SelectedItem = reader["odaTipi"].ToString();
                            txtFiyat.Text = reader["fiyat"].ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Oda bilgileri yüklenirken hata oluştu: " + ex.Message);
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (ValidateOda())
            {
                try
                {
                    using (var connection = DatabaseConnection.GetConnection())
                    {
                        connection.Open();
                        string query = @"UPDATE Odalar 
                                       SET odaNumarasi = @odaNo,
                                           odaTipi = @odaTipi,
                                           fiyat = @fiyat
                                       WHERE odaID = @id";

                        MySqlCommand command = new MySqlCommand(query, connection);
                        command.Parameters.AddWithValue("@odaNo", txtOdaNo.Text.Trim());
                        command.Parameters.AddWithValue("@odaTipi", cmbOdaTipi.SelectedItem.ToString());
                        command.Parameters.AddWithValue("@fiyat", Convert.ToDecimal(txtFiyat.Text));
                        command.Parameters.AddWithValue("@id", odaId);

                        command.ExecuteNonQuery();

                        MessageBox.Show("Oda bilgileri başarıyla güncellendi!");
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Oda güncellenirken hata oluştu: " + ex.Message);
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

            // Oda numarası değiştiyse ve yeni numara başka bir odada kullanılıyorsa
            if (txtOdaNo.Text.Trim() != eskiOdaNo && OdaNumarasiKontrol(txtOdaNo.Text.Trim()))
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
                    string query = "SELECT COUNT(*) FROM Odalar WHERE odaNumarasi = @odaNo AND odaID != @odaId";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@odaNo", odaNo);
                    command.Parameters.AddWithValue("@odaId", odaId);

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

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
