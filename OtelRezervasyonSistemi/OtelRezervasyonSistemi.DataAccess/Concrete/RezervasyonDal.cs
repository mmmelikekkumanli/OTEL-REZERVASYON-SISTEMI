using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using OtelRezervasyonSistemi.DataAccess.Abstract;
using OtelRezervasyonSistemi.Entities.Concrete;


namespace OtelRezervasyonSistemi.DataAccess.Concrete
{
    public class RezervasyonDal : IRezervasyonDal
    {
        // Rezervasyon Ekleme
        public void Add(Rezervasyon rezervasyon)
        {
            using (var connection = DatabaseConnection.GetConnection())
            {
                try
                {
                    connection.Open();
                    string query = @"INSERT INTO Rezervasyonlar 
                                   (musteriID, odaID, girisTarihi, cikisTarihi, toplamFiyat, durum) 
                                   VALUES 
                                   (@musteriId, @odaId, @girisTarihi, @cikisTarihi, @toplamFiyat, @durum)";

                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@musteriId", rezervasyon.MusteriID);
                    command.Parameters.AddWithValue("@odaId", rezervasyon.OdaID);
                    command.Parameters.AddWithValue("@girisTarihi", rezervasyon.GirisTarihi);
                    command.Parameters.AddWithValue("@cikisTarihi", rezervasyon.CikisTarihi);
                    command.Parameters.AddWithValue("@toplamFiyat", rezervasyon.ToplamFiyat);
                    command.Parameters.AddWithValue("@durum", rezervasyon.Durum);

                    command.ExecuteNonQuery();

                    // Odanın durumunu güncelle
                    UpdateRoomStatus(rezervasyon.OdaID, false);
                }
                catch (Exception ex)
                {
                    throw new Exception("Rezervasyon eklenirken hata oluştu: " + ex.Message);
                }
            }
        }

        // Tüm Rezervasyonları Getirme
        public List<Rezervasyon> GetAll()
        {
            List<Rezervasyon> rezervasyonlar = new List<Rezervasyon>();

            using (var connection = DatabaseConnection.GetConnection())
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM Rezervasyonlar";

                    MySqlCommand command = new MySqlCommand(query, connection);
                    MySqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        rezervasyonlar.Add(new Rezervasyon
                        {
                            RezervasyonID = Convert.ToInt32(reader["rezervasyonID"]),
                            MusteriID = Convert.ToInt32(reader["musteriID"]),
                            OdaID = Convert.ToInt32(reader["odaID"]),
                            GirisTarihi = Convert.ToDateTime(reader["girisTarihi"]),
                            CikisTarihi = Convert.ToDateTime(reader["cikisTarihi"]),
                            ToplamFiyat = Convert.ToDecimal(reader["toplamFiyat"]),
                            Durum = reader["durum"].ToString()
                        });
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Rezervasyonlar listelenirken hata oluştu: " + ex.Message);
                }
            }
            return rezervasyonlar;
        }

        // Aktif Rezervasyonları Getirme
        public List<Rezervasyon> GetActiveReservations()
        {
            List<Rezervasyon> rezervasyonlar = new List<Rezervasyon>();

            using (var connection = DatabaseConnection.GetConnection())
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM Rezervasyonlar WHERE durum = 'Aktif'";

                    MySqlCommand command = new MySqlCommand(query, connection);
                    MySqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        rezervasyonlar.Add(new Rezervasyon
                        {
                            RezervasyonID = Convert.ToInt32(reader["rezervasyonID"]),
                            MusteriID = Convert.ToInt32(reader["musteriID"]),
                            OdaID = Convert.ToInt32(reader["odaID"]),
                            GirisTarihi = Convert.ToDateTime(reader["girisTarihi"]),
                            CikisTarihi = Convert.ToDateTime(reader["cikisTarihi"]),
                            ToplamFiyat = Convert.ToDecimal(reader["toplamFiyat"]),
                            Durum = reader["durum"].ToString()
                        });
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Aktif rezervasyonlar listelenirken hata oluştu: " + ex.Message);
                }
            }
            return rezervasyonlar;
        }

        // Müşteriye Ait Rezervasyonları Getirme
        public List<Rezervasyon> GetByMusteriId(int musteriId)
        {
            List<Rezervasyon> rezervasyonlar = new List<Rezervasyon>();

            using (var connection = DatabaseConnection.GetConnection())
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM Rezervasyonlar WHERE musteriID = @musteriId";

                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@musteriId", musteriId);

                    MySqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        rezervasyonlar.Add(new Rezervasyon
                        {
                            RezervasyonID = Convert.ToInt32(reader["rezervasyonID"]),
                            MusteriID = Convert.ToInt32(reader["musteriID"]),
                            OdaID = Convert.ToInt32(reader["odaID"]),
                            GirisTarihi = Convert.ToDateTime(reader["girisTarihi"]),
                            CikisTarihi = Convert.ToDateTime(reader["cikisTarihi"]),
                            ToplamFiyat = Convert.ToDecimal(reader["toplamFiyat"]),
                            Durum = reader["durum"].ToString()
                        });
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Müşterinin rezervasyonları listelenirken hata oluştu: " + ex.Message);
                }
            }
            return rezervasyonlar;
        }

        // ID'ye Göre Rezervasyon Getirme
        public Rezervasyon GetById(int rezervasyonId)
        {
            using (var connection = DatabaseConnection.GetConnection())
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM Rezervasyonlar WHERE rezervasyonID = @rezervasyonId";

                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@rezervasyonId", rezervasyonId);

                    MySqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        return new Rezervasyon
                        {
                            RezervasyonID = Convert.ToInt32(reader["rezervasyonID"]),
                            MusteriID = Convert.ToInt32(reader["musteriID"]),
                            OdaID = Convert.ToInt32(reader["odaID"]),
                            GirisTarihi = Convert.ToDateTime(reader["girisTarihi"]),
                            CikisTarihi = Convert.ToDateTime(reader["cikisTarihi"]),
                            ToplamFiyat = Convert.ToDecimal(reader["toplamFiyat"]),
                            Durum = reader["durum"].ToString()
                        };
                    }
                    return null;
                }
                catch (Exception ex)
                {
                    throw new Exception("Rezervasyon aranırken hata oluştu: " + ex.Message);
                }
            }
        }

        // Oda Müsaitlik Kontrolü
        public bool IsOdaAvailable(int odaId, DateTime girisTarihi, DateTime cikisTarihi)
        {
            using (var connection = DatabaseConnection.GetConnection())
            {
                try
                {
                    connection.Open();
                    string query = @"SELECT COUNT(*) FROM Rezervasyonlar 
                                   WHERE odaID = @odaId 
                                   AND durum = 'Aktif'
                                   AND ((girisTarihi BETWEEN @girisTarihi AND @cikisTarihi) 
                                   OR (cikisTarihi BETWEEN @girisTarihi AND @cikisTarihi))";

                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@odaId", odaId);
                    command.Parameters.AddWithValue("@girisTarihi", girisTarihi);
                    command.Parameters.AddWithValue("@cikisTarihi", cikisTarihi);

                    int count = Convert.ToInt32(command.ExecuteScalar());
                    return count == 0;
                }
                catch (Exception ex)
                {
                    throw new Exception("Oda müsaitlik kontrolü yapılırken hata oluştu: " + ex.Message);
                }
            }
        }

        // Rezervasyon Güncelleme
        public void Update(Rezervasyon rezervasyon)
        {
            using (var connection = DatabaseConnection.GetConnection())
            {
                try
                {
                    connection.Open();
                    string query = @"UPDATE Rezervasyonlar 
                                   SET musteriID = @musteriId,
                                       odaID = @odaId,
                                       girisTarihi = @girisTarihi,
                                       cikisTarihi = @cikisTarihi,
                                       toplamFiyat = @toplamFiyat,
                                       durum = @durum
                                   WHERE rezervasyonID = @rezervasyonId";

                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@rezervasyonId", rezervasyon.RezervasyonID);
                    command.Parameters.AddWithValue("@musteriId", rezervasyon.MusteriID);
                    command.Parameters.AddWithValue("@odaId", rezervasyon.OdaID);
                    command.Parameters.AddWithValue("@girisTarihi", rezervasyon.GirisTarihi);
                    command.Parameters.AddWithValue("@cikisTarihi", rezervasyon.CikisTarihi);
                    command.Parameters.AddWithValue("@toplamFiyat", rezervasyon.ToplamFiyat);
                    command.Parameters.AddWithValue("@durum", rezervasyon.Durum);

                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw new Exception("Rezervasyon güncellenirken hata oluştu: " + ex.Message);
                }
            }
        }

        // Rezervasyon Silme
        public void Delete(int rezervasyonId)
        {
            using (var connection = DatabaseConnection.GetConnection())
            {
                try
                {
                    connection.Open();
                    // Önce rezervasyona ait odayı bul
                    int odaId = GetOdaIdByRezervasyonId(rezervasyonId);

                    string query = "DELETE FROM Rezervasyonlar WHERE rezervasyonID = @rezervasyonId";

                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@rezervasyonId", rezervasyonId);

                    command.ExecuteNonQuery();

                    // Odanın durumunu müsait olarak güncelle
                    UpdateRoomStatus(odaId, true);
                }
                catch (Exception ex)
                {
                    throw new Exception("Rezervasyon silinirken hata oluştu: " + ex.Message);
                }
            }
        }

        // Yardımcı metodlar
        private void UpdateRoomStatus(int odaId, bool durum)
        {
            using (var connection = DatabaseConnection.GetConnection())
            {
                try
                {
                    connection.Open();
                    string query = "UPDATE Odalar SET durum = @durum WHERE odaID = @odaId";

                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@odaId", odaId);
                    command.Parameters.AddWithValue("@durum", durum);

                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw new Exception("Oda durumu güncellenirken hata oluştu: " + ex.Message);
                }
            }
        }

        private int GetOdaIdByRezervasyonId(int rezervasyonId)
        {
            using (var connection = DatabaseConnection.GetConnection())
            {
                try
                {
                    connection.Open();
                    string query = "SELECT odaID FROM Rezervasyonlar WHERE rezervasyonID = @rezervasyonId";

                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@rezervasyonId", rezervasyonId);

                    object result = command.ExecuteScalar();
                    return result != null ? Convert.ToInt32(result) : 0;
                }
                catch (Exception ex)
                {
                    throw new Exception("Oda ID'si alınırken hata oluştu: " + ex.Message);
                }
            }
        }
    }
}