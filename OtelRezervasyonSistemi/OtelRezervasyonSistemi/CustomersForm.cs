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
    public partial class CustomersForm : Form
    {
        public CustomersForm()
        {
            InitializeComponent();
        }

        private void CustomersForm_Load(object sender, EventArgs e)
        {
            MusterileriListele();
        }

        private void MusterileriListele()
        {
            try
            {
                using (var connection = DatabaseConnection.GetConnection())
                {
                    connection.Open();
                    string query = @"SELECT m.musteriID,
                                  m.ad,
                                  m.soyad,
                                  m.tcKimlik,
                                  m.telefon,
                                  m.email 
                           FROM Musteriler m";

                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    // DataGridView'e veri bağlamadan önce AutoGenerateColumns'ı false yap
                    dgvMusteriler.AutoGenerateColumns = false;

                    // Manuel oluşturduğunuz sütunlarla eşleştirme
                    dgvMusteriler.Columns["colAd"].DataPropertyName = "ad";
                    dgvMusteriler.Columns["colSoyad"].DataPropertyName = "soyad";
                    dgvMusteriler.Columns["colTCKN"].DataPropertyName = "tcKimlik";
                    dgvMusteriler.Columns["colTelefon"].DataPropertyName = "telefon";
                    dgvMusteriler.Columns["colEmail"].DataPropertyName = "email";

                    dgvMusteriler.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Müşteriler listelenirken hata oluştu: " + ex.Message);
            }
        }

        private void txtArama_TextChanged(object sender, EventArgs e)
        {
            try
            {
                using (var connection = DatabaseConnection.GetConnection())
                {
                    connection.Open();
                    string query = @"SELECT m.musteriID,
                                  m.ad,
                                  m.soyad,
                                  m.tcKimlik,
                                  m.telefon,
                                  m.email 
                           FROM Musteriler m
                           WHERE m.ad LIKE @arama 
                           OR m.soyad LIKE @arama 
                           OR m.tcKimlik LIKE @arama 
                           OR m.telefon LIKE @arama";

                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@arama", "%" + txtArama.Text + "%");

                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    // DataGridView'e veri bağlamadan önce AutoGenerateColumns'ı false yap
                    dgvMusteriler.AutoGenerateColumns = false;
                    dgvMusteriler.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Arama sırasında hata oluştu: " + ex.Message);
            }
        }

        private void duzenletoolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvMusteriler.SelectedRows.Count > 0)
            {
                int musteriId = Convert.ToInt32(dgvMusteriler.SelectedRows[0].Cells["colmusteriID"].Value);
                EditCustomerForm duzenleForm = new EditCustomerForm(musteriId);
                if (duzenleForm.ShowDialog() == DialogResult.OK)
                {
                    MusterileriListele(); // Listeyi yenile
                }
            }
        }

        private void siltoolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (dgvMusteriler.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Seçili müşteriyi silmek istediğinize emin misiniz?",
                    "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        int musteriId = Convert.ToInt32(dgvMusteriler.SelectedRows[0].Cells["musteriID"].Value);
                        using (var connection = DatabaseConnection.GetConnection())
                        {
                            connection.Open();
                            // Önce müşterinin aktif rezervasyonu var mı kontrol et
                            string kontrolQuery = "SELECT COUNT(*) FROM Rezervasyonlar WHERE musteriID = @id AND durum = 'Aktif'";
                            MySqlCommand kontrolCommand = new MySqlCommand(kontrolQuery, connection);
                            kontrolCommand.Parameters.AddWithValue("@id", musteriId);
                            int rezervasyonSayisi = Convert.ToInt32(kontrolCommand.ExecuteScalar());

                            if (rezervasyonSayisi > 0)
                            {
                                MessageBox.Show("Bu müşterinin aktif rezervasyonu bulunmaktadır. Önce rezervasyonları iptal ediniz.");
                                return;
                            }

                            // Aktif rezervasyon yoksa sil
                            string deleteQuery = "DELETE FROM Musteriler WHERE musteriID = @id";
                            MySqlCommand deleteCommand = new MySqlCommand(deleteQuery, connection);
                            deleteCommand.Parameters.AddWithValue("@id", musteriId);
                            deleteCommand.ExecuteNonQuery();

                            MessageBox.Show("Müşteri başarıyla silindi!");
                            MusterileriListele(); // Listeyi yenile
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Müşteri silinirken hata oluştu: " + ex.Message);
                    }
                }
            }
        }

        private void btnYeniMusteri_Click(object sender, EventArgs e)
        {
            NewCustomerForm yeniMusteri = new NewCustomerForm();
            if (yeniMusteri.ShowDialog() == DialogResult.OK)
            {
                MusterileriListele(); // Listeyi yenile
            }
        }

       
    }
}
