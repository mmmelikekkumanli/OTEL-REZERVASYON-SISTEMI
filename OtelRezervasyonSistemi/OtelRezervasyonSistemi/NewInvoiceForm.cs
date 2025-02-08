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
    public partial class NewInvoiceForm : Form
    {
        public NewInvoiceForm()
        {
            InitializeComponent();
            RezervasyonlariYukle();
        }
        private void RezervasyonlariYukle()
        {
            try
            {
                using (var connection = DatabaseConnection.GetConnection())
                {
                    connection.Open();
                    string query = @"SELECT r.rezervasyonID, 
                               CONCAT(m.ad, ' ', m.soyad, ' - Oda: ', o.odaNumarasi) as RezervasyonBilgi
                               FROM Rezervasyonlar r
                               INNER JOIN Musteriler m ON r.musteriID = m.musteriID
                               INNER JOIN Odalar o ON r.odaID = o.odaID
                               WHERE r.durum = 'Aktif'
                               AND NOT EXISTS (SELECT 1 FROM Faturalar f WHERE f.rezervasyonID = r.rezervasyonID)";

                    MySqlCommand command = new MySqlCommand(query, connection);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    cmbRezervasyonlar.DataSource = dt;
                    cmbRezervasyonlar.DisplayMember = "RezervasyonBilgi";
                    cmbRezervasyonlar.ValueMember = "rezervasyonID";
                    cmbRezervasyonlar.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Rezervasyonlar yüklenirken hata oluştu: " + ex.Message);
            }
        }

        private void btnOlustur_Click(object sender, EventArgs e)
        {
            {
                if (ValidateFatura())
                {
                    try
                    {
                        using (var connection = DatabaseConnection.GetConnection())
                        {
                            connection.Open();
                            string query = @"INSERT INTO Faturalar 
                               (rezervasyonID, toplamTutar, faturaTarihi, odemeDurumu) 
                               VALUES 
                               (@rezervasyonId, @toplamTutar, @faturaTarihi, @odemeDurumu)";

                            MySqlCommand command = new MySqlCommand(query, connection);
                            command.Parameters.AddWithValue("@rezervasyonId", cmbRezervasyonlar.SelectedValue);
                            command.Parameters.AddWithValue("@toplamTutar", Convert.ToDecimal(txtToplamTutar.Text));
                            command.Parameters.AddWithValue("@faturaTarihi", DateTime.Now);
                            command.Parameters.AddWithValue("@odemeDurumu", "Ödenmedi");

                            command.ExecuteNonQuery();

                            MessageBox.Show("Fatura başarıyla oluşturuldu!");
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Faturanızı görebilirsiniz: " + ex.Message);
                    }
                }
            }

        }

        private bool ValidateFatura()
        {
            if (cmbRezervasyonlar.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen rezervasyon seçiniz!");
                return false;
            }

            if (string.IsNullOrEmpty(txtToplamTutar.Text))
            {
                MessageBox.Show("Toplam tutar boş olamaz!");
                return false;
            }

            return true;
        }

        private void cmbRezervasyonlar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int rezervasyonId = Convert.ToInt32(cmbRezervasyonlar.SelectedValue);
                using (var connection = DatabaseConnection.GetConnection())
                {
                    connection.Open();
                    string query = @"SELECT r.toplamFiyat, m.ad, m.soyad, o.odaNumarasi
                               FROM Rezervasyonlar r
                               INNER JOIN Musteriler m ON r.musteriID = m.musteriID
                               INNER JOIN Odalar o ON r.odaID = o.odaID
                               WHERE r.rezervasyonID = @id";

                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@id", rezervasyonId);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            txtToplamTutar.Text = reader["toplamFiyat"].ToString();
                            // Diğer bilgileri doldur
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Rezervasyon bilgileri alınırken hata oluştu: " + ex.Message);
            }
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

