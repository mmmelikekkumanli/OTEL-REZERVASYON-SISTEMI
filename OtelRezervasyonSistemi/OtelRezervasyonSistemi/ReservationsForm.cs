using MySql.Data.MySqlClient;
using OtelRezervasyonSistemi.DataAccess.Concrete;
using OtelRezervasyonSistemi.Entities.Concrete;
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
    public partial class ReservationsForm : Form
    {
        public ReservationsForm()
        {
            InitializeComponent();
        }

        private void ReservationsForm_Load(object sender, EventArgs e)
        {
            RezervasyonlariListele();
        }

        private void RezervasyonlariListele()
        {
            try
            {
                using (var connection = DatabaseConnection.GetConnection())
                {
                    connection.Open();
                    string query = @"SELECT r.rezervasyonID, 
                         CONCAT(m.ad, ' ', m.soyad) as MusteriAdi,
                         o.odaNumarasi,
                         r.girisTarihi,
                         r.cikisTarihi,
                         r.toplamFiyat,
                         r.durum
                  FROM Rezervasyonlar r
                  INNER JOIN Musteriler m ON r.musteriID = m.musteriID
                  INNER JOIN Odalar o ON r.odaID = o.odaID";

                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    // Otomatik sütun oluşturmayı engelle
                    dgvRezervasyonlar.AutoGenerateColumns = false;

                    // Manuel oluşturduğunuz sütunlarla eşleştirme
                    dgvRezervasyonlar.Columns["colRezervasyonNo"].DataPropertyName = "rezervasyonID";
                    dgvRezervasyonlar.Columns["colMusteriAdi"].DataPropertyName = "MusteriAdi";
                    dgvRezervasyonlar.Columns["colOdaNo"].DataPropertyName = "odaNumarasi";
                    dgvRezervasyonlar.Columns["colGirisTarihi"].DataPropertyName = "girisTarihi";
                    dgvRezervasyonlar.Columns["colCikisTarihi"].DataPropertyName = "cikisTarihi";
                    dgvRezervasyonlar.Columns["colToplamTutar"].DataPropertyName = "toplamFiyat";
                    dgvRezervasyonlar.Columns["colDurum"].DataPropertyName = "durum";

                    // Veri kaynağını ayarla
                    dgvRezervasyonlar.DataSource = dt;

                    // Button sütunu için değerleri ayarla
                    foreach (DataGridViewRow row in dgvRezervasyonlar.Rows)
                    {
                        if (row.Cells["colIslemler"] is DataGridViewButtonCell)
                        {
                            row.Cells["colIslemler"].Value = "İptal Et";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Rezervasyonlar listelenirken hata oluştu: " + ex.Message);
            }
        }
        private void txtArama_TextChanged(object sender, EventArgs e)
        {
            try
            {
                using (var connection = DatabaseConnection.GetConnection())
                {
                    connection.Open();
                    string query = @"SELECT r.rezervasyonID, 
                          CONCAT(m.ad, ' ', m.soyad) as MusteriAdi,
                          o.odaNumarasi,
                          r.girisTarihi,
                          r.cikisTarihi,
                          r.toplamFiyat,
                          r.durum
                   FROM Rezervasyonlar r
                   INNER JOIN Musteriler m ON r.musteriID = m.musteriID
                   INNER JOIN Odalar o ON r.odaID = o.odaID
                   WHERE m.ad LIKE @arama 
                   OR m.soyad LIKE @arama 
                   OR o.odaNumarasi LIKE @arama";

                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@arama", "%" + txtArama.Text + "%");

                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dgvRezervasyonlar.AutoGenerateColumns = false;
                    dgvRezervasyonlar.DataSource = dt;

                    if (dgvRezervasyonlar.Columns["colIslemler"] is DataGridViewButtonColumn)
                    {
                        foreach (DataGridViewRow row in dgvRezervasyonlar.Rows)
                        {
                            row.Cells["colIslemler"].Value = "İptal Et";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Arama sırasında hata oluştu: " + ex.Message);
            }
        }

        private void btnYeniRezervasyon_Click(object sender, EventArgs e)
        {
            NewReservationForm yeniRezervasyon = new NewReservationForm();
            yeniRezervasyon.ShowDialog();
            if (yeniRezervasyon.DialogResult == DialogResult.OK)
            {
                RezervasyonlariListele();
            }
        }

        private void duzenletoolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (dgvRezervasyonlar.SelectedRows.Count > 0)
            {
                int rezervasyonId = Convert.ToInt32(dgvRezervasyonlar.SelectedRows[0].Cells["rezervasyonID"].Value);
                NewReservationForm duzenleForm = new NewReservationForm(rezervasyonId);
                if (duzenleForm.ShowDialog() == DialogResult.OK)
                {
                    RezervasyonlariListele();
                }
            }
        }

        private void iptalEtToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (dgvRezervasyonlar.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Seçili rezervasyonu iptal etmek istediğinize emin misiniz?",
                    "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        // Seçili satırdan rezervasyonID'yi al
                        int rezervasyonId = Convert.ToInt32(dgvRezervasyonlar.SelectedRows[0].Cells["colRezervasyonNo"].Value);

                        using (var connection = DatabaseConnection.GetConnection())
                        {
                            connection.Open();
                            using (var transaction = connection.BeginTransaction())
                            {
                                try
                                {
                                    // Odayı müsait yap
                                    string updateOdaQuery = @"UPDATE Odalar SET durum = true 
                                                    WHERE odaID = (SELECT odaID FROM Rezervasyonlar 
                                                    WHERE rezervasyonID = @rezervasyonId)";

                                    MySqlCommand updateOdaCmd = new MySqlCommand(updateOdaQuery, connection, transaction);
                                    updateOdaCmd.Parameters.AddWithValue("@rezervasyonId", rezervasyonId);
                                    updateOdaCmd.ExecuteNonQuery();

                                    // Rezervasyonu iptal et
                                    string updateRezervasyonQuery = "UPDATE Rezervasyonlar SET durum = 'İptal' WHERE rezervasyonID = @rezervasyonId";
                                    MySqlCommand updateRezervasyonCmd = new MySqlCommand(updateRezervasyonQuery, connection, transaction);
                                    updateRezervasyonCmd.Parameters.AddWithValue("@rezervasyonId", rezervasyonId);
                                    updateRezervasyonCmd.ExecuteNonQuery();

                                    transaction.Commit();
                                    MessageBox.Show("Rezervasyon başarıyla iptal edildi!");
                                    RezervasyonlariListele();
                                }
                                catch (Exception)
                                {
                                    transaction.Rollback();
                                    throw;
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Rezervasyon iptal edilirken hata oluştu: " + ex.Message);
                    }
                }
            }
        }

        private void dgvRezervasyonlar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // İşlemler sütunundaki butona tıklandıysa
                if (e.ColumnIndex == dgvRezervasyonlar.Columns["colIslemler"].Index)
                {
                    int rezervasyonId = Convert.ToInt32(dgvRezervasyonlar.Rows[e.RowIndex].Cells["colRezervasyonNo"].Value);

                    if (MessageBox.Show("Seçili rezervasyonu iptal etmek istediğinize emin misiniz?",
                        "Rezervasyon İptali",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        try
                        {
                            using (var connection = DatabaseConnection.GetConnection())
                            {
                                connection.Open();
                                string query = "UPDATE Rezervasyonlar SET durum = 'İptal' WHERE rezervasyonID = @id";

                                MySqlCommand command = new MySqlCommand(query, connection);
                                command.Parameters.AddWithValue("@id", rezervasyonId);
                                command.ExecuteNonQuery();

                                MessageBox.Show("Rezervasyon başarıyla iptal edildi.");
                                RezervasyonlariListele(); // Listeyi yenile
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Rezervasyon iptal edilirken hata oluştu: " + ex.Message);
                        }
                    }
                }
            }
        }


    }

}
