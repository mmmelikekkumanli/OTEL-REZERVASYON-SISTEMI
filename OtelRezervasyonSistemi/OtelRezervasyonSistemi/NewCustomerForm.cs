using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using OtelRezervasyonSistemi.DataAccess.Concrete;

namespace OtelRezervasyonSistemi
{
    public partial class NewCustomerForm : Form
    {
        public NewCustomerForm()
        {
            InitializeComponent();
            btnKaydet.Click += new EventHandler(btnKaydet_Click_1);
            btnIptal.Click += new EventHandler(btnIptal_Click_1);
        }

        private void btnKaydet_Click_1(object sender, EventArgs e)
        {
            if (ValidateMusteri())
            {
                try
                {
                    using (var connection = DatabaseConnection.GetConnection())
                    {
                        connection.Open();
                        using (var transaction = connection.BeginTransaction())
                        {
                            try
                            {
                                string query = @"INSERT INTO Musteriler 
                                    (ad, soyad, tcKimlik, telefon, email) 
                                    VALUES 
                                    (@ad, @soyad, @tcKimlik, @telefon, @email)";

                                MySqlCommand command = new MySqlCommand(query, connection);
                                command.Transaction = transaction;
                                command.Parameters.AddWithValue("@ad", txtAd.Text.Trim());
                                command.Parameters.AddWithValue("@soyad", txtSoyad.Text.Trim());
                                command.Parameters.AddWithValue("@tcKimlik", txtTCKN.Text.Trim());
                                command.Parameters.AddWithValue("@telefon", txtTelefon.Text.Trim());
                                command.Parameters.AddWithValue("@email", string.IsNullOrEmpty(txtEmail.Text.Trim()) ? DBNull.Value : (object)txtEmail.Text.Trim());

                                command.ExecuteNonQuery();
                                transaction.Commit();

                                MessageBox.Show("Müşteri başarıyla kaydedildi!");
                                this.DialogResult = DialogResult.OK;
                                this.Close();
                            }
                            catch (MySqlException ex) when (ex.Number == 1062) // Duplicate key hatası
                            {
                                transaction.Rollback();
                                MessageBox.Show("Müşteriye ait rezervasyon bulunamadı!");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Müşteri kaydedilirken hata oluştu: " + ex.Message);
                }
            }
        }

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

            if (!TCKimlikKontrol(txtTCKN.Text.Trim()))
            {
                MessageBox.Show("Geçerli bir TC Kimlik numarası giriniz!");
                txtTCKN.Focus();
                return false;
            }

            if (!TelefonKontrol(txtTelefon.Text.Trim()))
            {
                MessageBox.Show("Geçerli bir telefon numarası giriniz! (5XXXXXXXXX)");
                txtTelefon.Focus();
                return false;
            }

            if (!string.IsNullOrEmpty(txtEmail.Text.Trim()) && !EmailKontrol(txtEmail.Text.Trim()))
            {
                MessageBox.Show("Geçerli bir e-posta adresi giriniz!");
                txtEmail.Focus();
                return false;
            }

            return true;
        }

        private bool TCKimlikKontrol(string tcNo)
        {
            if (string.IsNullOrEmpty(tcNo) || tcNo.Length != 11) return false;
            return Regex.IsMatch(tcNo, @"^[0-9]{11}$");
        }

        private bool TelefonKontrol(string telefon)
        {
            return Regex.IsMatch(telefon, @"^5[0-9]{9}$");
        }

        private bool EmailKontrol(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private void btnIptal_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}