using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using MySql.Data.MySqlClient;
using OtelRezervasyonSistemi.DataAccess.Concrete;

namespace OtelRezervasyonSistemi
{
    public partial class ReportsForm : Form
    {
        public ReportsForm()
        {
            InitializeComponent();
        }
        private void DolulukRaporuGoster(DateTime baslangicTarihi, DateTime bitisTarihi)
        {
            try
            {
                using (var connection = DatabaseConnection.GetConnection())
                {
                    connection.Open();
                    string query = @"SELECT 
                           r.girisTarihi as Tarih,
                           (SELECT COUNT(*) FROM Odalar) as ToplamOda,
                           COUNT(*) as DoluOda,
                           ((SELECT COUNT(*) FROM Odalar) - COUNT(*)) as BosOda,
                           ROUND((COUNT(*) * 100.0 / (SELECT COUNT(*) FROM Odalar)), 2) as DolulukOrani
                           FROM Rezervasyonlar r
                           WHERE r.girisTarihi BETWEEN @baslangic AND @bitis
                           AND r.durum = 'Aktif'
                           GROUP BY r.girisTarihi";

                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@baslangic", baslangicTarihi);
                    command.Parameters.AddWithValue("@bitis", bitisTarihi);

                    dgvRapor.Rows.Clear();
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            dgvRapor.Rows.Add(
                                Convert.ToDateTime(reader["Tarih"]).ToShortDateString(),
                                reader["ToplamOda"],
                                reader["DoluOda"],
                                reader["BosOda"],
                                reader["DolulukOrani"].ToString() + "%"
                            );
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Doluluk raporu oluşturulurken hata: " + ex.Message);
            }
        }

        private void GelirRaporuGoster(DateTime baslangicTarihi, DateTime bitisTarihi)
        {
            try
            {
                using (var connection = DatabaseConnection.GetConnection())
                {
                    connection.Open();
                    string query = @"SELECT 
                           DATE_FORMAT(r.girisTarihi, '%Y-%m') as Donem,
                           COUNT(*) as RezervasyonSayisi,
                           SUM(r.toplamFiyat) as ToplamGelir
                           FROM Rezervasyonlar r
                           WHERE r.girisTarihi BETWEEN @baslangic AND @bitis
                           AND r.durum = 'Aktif'
                           GROUP BY DATE_FORMAT(r.girisTarihi, '%Y-%m')
                           ORDER BY Donem DESC";

                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@baslangic", baslangicTarihi);
                    command.Parameters.AddWithValue("@bitis", bitisTarihi);

                    dgvRapor.Rows.Clear();
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            dgvRapor.Rows.Add(
                                reader["Donem"],
                                reader["RezervasyonSayisi"],
                                string.Format("{0:C2}", reader["ToplamGelir"])
                            );
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gelir raporu oluşturulurken hata: " + ex.Message);
            }
        }

        private void MusteriRaporuGoster(DateTime baslangicTarihi, DateTime bitisTarihi)
        {
            try
            {
                using (var connection = DatabaseConnection.GetConnection())
                {
                    connection.Open();
                    string query = @"SELECT 
                           CONCAT(m.ad, ' ', m.soyad) as MusteriAdi,
                           COUNT(*) as KonaklamaSayisi,
                           SUM(r.toplamFiyat) as ToplamHarcama,
                           AVG(DATEDIFF(r.cikisTarihi, r.girisTarihi)) as OrtalamaKonaklama
                           FROM Rezervasyonlar r
                           INNER JOIN Musteriler m ON r.musteriID = m.musteriID
                           WHERE r.girisTarihi BETWEEN @baslangic AND @bitis
                           AND r.durum = 'Aktif'
                           GROUP BY m.musteriID
                           ORDER BY ToplamHarcama DESC";

                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@baslangic", baslangicTarihi);
                    command.Parameters.AddWithValue("@bitis", bitisTarihi);

                    dgvRapor.Rows.Clear();
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            dgvRapor.Rows.Add(
                                reader["MusteriAdi"],
                                reader["KonaklamaSayisi"],
                                string.Format("{0:C2}", reader["ToplamHarcama"]),
                                string.Format("{0:0.0} Gün", reader["OrtalamaKonaklama"])
                            );
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Faturalar kısmından görebilirsiniz: " + ex.Message);
            }
        }

        private void RaporTuruneGoreKolonlariAyarla(string raporTuru)
        {
            dgvRapor.Columns.Clear(); // Mevcut kolonları temizle
            switch (raporTuru)
            {
                case "Doluluk":
                    dgvRapor.Columns.Add("colTarih", "Tarih");
                    dgvRapor.Columns.Add("colToplamOda", "Toplam Oda");
                    dgvRapor.Columns.Add("colDoluOda", "Dolu Oda");
                    dgvRapor.Columns.Add("colBosOda", "Boş Oda");
                    dgvRapor.Columns.Add("colDolulukOrani", "Doluluk Oranı (%)");
                    break;

                case "Gelir":
                    dgvRapor.Columns.Add("colDonem", "Dönem");
                    dgvRapor.Columns.Add("colRezervasyonSayisi", "Rezervasyon Sayısı");
                    dgvRapor.Columns.Add("colToplamGelir", "Toplam Gelir");
                    break;

                case "Musteri":
                    dgvRapor.Columns.Add("colMusteriAdi", "Müşteri Adı");
                    dgvRapor.Columns.Add("colKonaklamaSayisi", "Konaklama Sayısı");
                    dgvRapor.Columns.Add("colToplamHarcama", "Toplam Harcama");
                    dgvRapor.Columns.Add("colOrtalamaKonaklama", "Ortalama Konaklama");
                    break;
            }

            // Tüm kolonlar için ortak ayarlar
            foreach (DataGridViewColumn column in dgvRapor.Columns)
            {
                column.Width = 130;
                column.ReadOnly = true;
            }
        }

        private void btnDolulukRaporu_Click_1(object sender, EventArgs e)
        {
            try
            {
                RaporTuruneGoreKolonlariAyarla("Doluluk");
                using (var connection = DatabaseConnection.GetConnection())
                {
                    connection.Open();
                    string query = @"SELECT 
                                  CURDATE() as Tarih,
                                  (SELECT COUNT(*) FROM Odalar) as ToplamOda,
                                  (SELECT COUNT(*) FROM Odalar WHERE durum = 0) as DoluOda,
                                  (SELECT COUNT(*) FROM Odalar WHERE durum = 1) as BosOda,
                                  ROUND(((SELECT COUNT(*) FROM Odalar WHERE durum = 0) * 100.0 / 
                                  (SELECT COUNT(*) FROM Odalar)), 2) as DolulukOrani";

                    MySqlCommand command = new MySqlCommand(query, connection);
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            dgvRapor.Rows.Add(
                                reader["Tarih"],
                                reader["ToplamOda"],
                                reader["DoluOda"],
                                reader["BosOda"],
                                reader["DolulukOrani"].ToString() + "%"
                            );
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Doluluk raporu oluşturulurken hata: " + ex.Message);
            }
        }

        private void btnGelirRaporu_Click_1(object sender, EventArgs e)
        {
            try
            {
                RaporTuruneGoreKolonlariAyarla("Gelir");
                using (var connection = DatabaseConnection.GetConnection())
                {
                    connection.Open();
                    string query = @"SELECT 
                                  DATE_FORMAT(r.girisTarihi, '%Y-%m') as Donem,
                                  COUNT(*) as RezervasyonSayisi,
                                  SUM(r.toplamFiyat) as ToplamGelir
                                  FROM Rezervasyonlar r
                                  WHERE r.durum = 'Aktif'
                                  GROUP BY DATE_FORMAT(r.girisTarihi, '%Y-%m')
                                  ORDER BY Donem DESC";

                    MySqlCommand command = new MySqlCommand(query, connection);
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            dgvRapor.Rows.Add(
                                reader["Donem"],
                                reader["RezervasyonSayisi"],
                                string.Format("{0:C2}", reader["ToplamGelir"])
                            );
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gelir raporu oluşturulurken hata: " + ex.Message);
            }
        }

        private void btnMusteriRaporu_Click_1(object sender, EventArgs e)
        {
            try
            {
                RaporTuruneGoreKolonlariAyarla("Musteri");
                using (var connection = DatabaseConnection.GetConnection())
                {
                    connection.Open();
                    string query = @"SELECT 
                                  CONCAT(m.ad, ' ', m.soyad) as MusteriAdi,
                                  COUNT(*) as KonaklamaSayisi,
                                  SUM(r.toplamFiyat) as ToplamHarcama,
                                  AVG(DATEDIFF(r.cikisTarihi, r.girisTarihi)) as OrtalamaKonaklama
                                  FROM Rezervasyonlar r
                                  INNER JOIN Musteriler m ON r.musteriID = m.musteriID
                                  GROUP BY m.musteriID
                                  ORDER BY ToplamHarcama DESC";

                    MySqlCommand command = new MySqlCommand(query, connection);
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            dgvRapor.Rows.Add(
                                reader["MusteriAdi"],
                                reader["KonaklamaSayisi"],
                                string.Format("{0:C2}", reader["ToplamHarcama"]),
                                string.Format("{0:0.0} Gün", reader["OrtalamaKonaklama"])
                            );
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Raporlar kısmından görebilirsiniz" +
                    ": " + ex.Message);
            }
        }

        private void btnRaporGoster_Click_1(object sender, EventArgs e)
        {
            DateTime baslangicTarihi = dtpBaslangic.Value;
            DateTime bitisTarihi = dtpBitis.Value;

            if (bitisTarihi < baslangicTarihi)
            {
                MessageBox.Show("Bitiş tarihi başlangıç tarihinden önce olamaz!",
                    "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Aktif olan rapora göre tarihe bağlı veri getirme
            if (dgvRapor.Columns.Contains("colDolulukOrani"))
                DolulukRaporuGoster(baslangicTarihi, bitisTarihi);
            else if (dgvRapor.Columns.Contains("colToplamGelir"))
                GelirRaporuGoster(baslangicTarihi, bitisTarihi);
            else if (dgvRapor.Columns.Contains("colKonaklamaSayisi"))
                MusteriRaporuGoster(baslangicTarihi, bitisTarihi);
        }

        private void ReportsForm_Load(object sender, EventArgs e)
        {
            dgvRapor.BringToFront(); // DataGridView’i en üste getirir
            ipbRapor.SendToBack(); // IconPictureBox’ı en arkaya atar
            ipbRapor.Parent = dgvRapor;
            ipbRapor.BackColor = Color.Transparent; // Arkaplanı saydam yap


        }
    }
}       

        
    
