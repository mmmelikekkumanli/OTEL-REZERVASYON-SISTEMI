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
    public partial class RoomsForm : Form
    {
        public RoomsForm()
        {
            InitializeComponent();
            dgvOdalar.AutoGenerateColumns = false;
            dgvOdalar.DataError += dgvOdalar_DataError;
        }

        private void dgvOdalar_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false;
        }

        private void RoomsForm_Load(object sender, EventArgs e)
        {
            OdalariListele();
        }

        private void OdalariListele()
        {
            try
            {
                using (var connection = DatabaseConnection.GetConnection())
                {
                    connection.Open();
                    string query = "SELECT odaID, odaNumarasi, odaTipi, fiyat, durum FROM Odalar";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dgvOdalar.AutoGenerateColumns = false;
                    dgvOdalar.Columns["colDurum"].ValueType = typeof(string);

                    dgvOdalar.Columns["colOdaNo"].DataPropertyName = "odaNumarasi";
                    dgvOdalar.Columns["colOdaTipi"].DataPropertyName = "odaTipi";
                    dgvOdalar.Columns["colFiyat"].DataPropertyName = "fiyat";
                    dgvOdalar.Columns["colDurum"].DataPropertyName = "durum";

                    dgvOdalar.DataSource = dt;

                    foreach (DataGridViewRow row in dgvOdalar.Rows)
                    {
                        object durumValue = row.Cells["colDurum"].Value;
                        if (durumValue != null && durumValue != DBNull.Value)
                        {
                            bool durum = Convert.ToBoolean(durumValue);
                            row.Cells["colDurum"].Value = durum ? "Müsait" : "Dolu";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Odalar listelenirken hata oluştu: " + ex.Message);
            }
        }

        private void txtArama_TextChanged(object sender, EventArgs e)
        {
            try
            {
                using (var connection = DatabaseConnection.GetConnection())
                {
                    connection.Open();
                    string query = @"SELECT odaID, odaNumarasi, odaTipi, fiyat, durum 
                          FROM Odalar 
                          WHERE odaNumarasi LIKE @arama 
                          OR odaTipi LIKE @arama";

                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@arama", "%" + txtArama.Text + "%");

                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dgvOdalar.DataSource = dt;

                    foreach (DataGridViewRow row in dgvOdalar.Rows)
                    {
                        object durumValue = row.Cells["colDurum"].Value;
                        if (durumValue != null && durumValue != DBNull.Value)
                        {
                            bool durum = Convert.ToBoolean(durumValue);
                            row.Cells["colDurum"].Value = durum ? "Müsait" : "Dolu";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Arama sırasında hata oluştu: " + ex.Message);
            }
        }

        private void btnYeniOda_Click(object sender, EventArgs e)
        {
            NewRoomForm yeniOda = new NewRoomForm();
            if (yeniOda.ShowDialog() == DialogResult.OK)
            {
                OdalariListele();
            }
        }

        private void duzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvOdalar.SelectedRows.Count > 0)
            {
                int odaId = Convert.ToInt32(dgvOdalar.SelectedRows[0].Cells["odaID"].Value);
                EditRoomForm duzenleForm = new EditRoomForm(odaId);
                if (duzenleForm.ShowDialog() == DialogResult.OK)
                {
                    OdalariListele();
                }
            }
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvOdalar.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Seçili odayı silmek istediğinize emin misiniz?",
                    "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        int odaId = Convert.ToInt32(dgvOdalar.SelectedRows[0].Cells["odaID"].Value);
                        using (var connection = DatabaseConnection.GetConnection())
                        {
                            connection.Open();
                            string query = "DELETE FROM Odalar WHERE odaID = @id";

                            MySqlCommand command = new MySqlCommand(query, connection);
                            command.Parameters.AddWithValue("@id", odaId);
                            command.ExecuteNonQuery();

                            MessageBox.Show("Oda başarıyla silindi!");
                            OdalariListele();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Oda silinirken hata oluştu: " + ex.Message);
                    }
                }
            }
        }
    }
}