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
    public partial class InvoicesForm : Form
    {
        public InvoicesForm()
        {
            InitializeComponent();
            dgvFaturalar.AutoGenerateColumns = false;  // Manuel sütunlar kullanılacak
        }

        private void InvoicesForm_Load(object sender, EventArgs e)
        {
            FaturalariListele();
        }

        private void FaturalariListele()
        {
            try
            {
                using (var connection = DatabaseConnection.GetConnection())
                {
                    connection.Open();
                    string query = @"SELECT f.faturaID, 
                                  CONCAT(m.ad, ' ', m.soyad) as MusteriAdi,
                                  f.rezervasyonID,
                                  f.faturaTarihi,
                                  f.toplamTutar,
                                  f.odemeDurumu
                           FROM Faturalar f
                           INNER JOIN Rezervasyonlar r ON f.rezervasyonID = r.rezervasyonID
                           INNER JOIN Musteriler m ON r.musteriID = m.musteriID";

                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    // Sütun eşleştirmelerini yapın
                    dgvFaturalar.Columns["colFaturaNo"].DataPropertyName = "faturaID";
                    dgvFaturalar.Columns["colMusteriAdi"].DataPropertyName = "MusteriAdi";
                    dgvFaturalar.Columns["colRezervasyonNo"].DataPropertyName = "rezervasyonID";
                    dgvFaturalar.Columns["colFaturaTarihi"].DataPropertyName = "faturaTarihi";
                    dgvFaturalar.Columns["colTutar"].DataPropertyName = "Tutar";
                    dgvFaturalar.Columns["colOdemeDurumu"].DataPropertyName = "odemeDurumu";

                    dgvFaturalar.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
               
            }
        }

        private void txtArama_TextChanged(object sender, EventArgs e)
        {
            try
            {
                using (var connection = DatabaseConnection.GetConnection())
                {
                    connection.Open();
                    string query = @"SELECT f.faturaID, 
                                  CONCAT(m.ad, ' ', m.soyad) as MusteriAdi,
                                  f.rezervasyonID,
                                  f.faturaTarihi,
                                  f.toplamTutar,
                                  f.odemeDurumu
                           FROM Faturalar f
                           INNER JOIN Rezervasyonlar r ON f.rezervasyonID = r.rezervasyonID
                           INNER JOIN Musteriler m ON r.musteriID = m.musteriID
                           WHERE m.ad LIKE @arama 
                           OR m.soyad LIKE @arama 
                           OR f.faturaID LIKE @arama";

                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@arama", "%" + txtArama.Text + "%");

                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvFaturalar.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Arama sırasında hata oluştu: " + ex.Message);
            }
        }

        private void btnYeniFatura_Click(object sender, EventArgs e)
        {
            NewInvoiceForm yeniFatura = new NewInvoiceForm();
            if (yeniFatura.ShowDialog() == DialogResult.OK)
            {
                FaturalariListele(); // Listeyi yenile
            }
        }
    }
}
   

