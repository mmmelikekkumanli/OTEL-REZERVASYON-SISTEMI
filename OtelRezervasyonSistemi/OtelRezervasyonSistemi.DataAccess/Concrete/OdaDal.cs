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
    public class OdaDal : IOdaDal
    {
        // Oda Ekleme
        public void Add(Oda oda)
        {
            using (var connection = DatabaseConnection.GetConnection())
            {
                try
                {
                    connection.Open();
                    string query = @"INSERT INTO Odalar (odaNumarasi, odaTipi, fiyat, durum) 
                                   VALUES (@odaNumarasi, @odaTipi, @fiyat, @durum)";

                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@odaNumarasi", oda.OdaNumarasi);
                    command.Parameters.AddWithValue("@odaTipi", oda.OdaTipi);
                    command.Parameters.AddWithValue("@fiyat", oda.Fiyat);
                    command.Parameters.AddWithValue("@durum", oda.Durum);

                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw new Exception("Oda eklenirken hata oluştu: " + ex.Message);
                }
            }
        }

        // Tüm Odaları Getirme
        public List<Oda> GetAll()
        {
            List<Oda> odalar = new List<Oda>();

            using (var connection = DatabaseConnection.GetConnection())
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM Odalar";

                    MySqlCommand command = new MySqlCommand(query, connection);
                    MySqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        odalar.Add(new Oda
                        {
                            OdaID = Convert.ToInt32(reader["odaID"]),
                            OdaNumarasi = reader["odaNumarasi"].ToString(),
                            OdaTipi = reader["odaTipi"].ToString(),
                            Fiyat = Convert.ToDecimal(reader["fiyat"]),
                            Durum = Convert.ToBoolean(reader["durum"])
                        });
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Odalar listelenirken hata oluştu: " + ex.Message);
                }
            }
            return odalar;
        }

        // Müsait Odaları Getirme
        public List<Oda> GetAvailableRooms()
        {
            List<Oda> odalar = new List<Oda>();

            using (var connection = DatabaseConnection.GetConnection())
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM Odalar WHERE durum = TRUE";

                    MySqlCommand command = new MySqlCommand(query, connection);
                    MySqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        odalar.Add(new Oda
                        {
                            OdaID = Convert.ToInt32(reader["odaID"]),
                            OdaNumarasi = reader["odaNumarasi"].ToString(),
                            OdaTipi = reader["odaTipi"].ToString(),
                            Fiyat = Convert.ToDecimal(reader["fiyat"]),
                            Durum = Convert.ToBoolean(reader["durum"])
                        });
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Müsait odalar listelenirken hata oluştu: " + ex.Message);
                }
            }
            return odalar;
        }

        // ID'ye Göre Oda Getirme
        public Oda GetById(int odaId)
        {
            using (var connection = DatabaseConnection.GetConnection())
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM Odalar WHERE odaID = @odaId";

                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@odaId", odaId);

                    MySqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        return new Oda
                        {
                            OdaID = Convert.ToInt32(reader["odaID"]),
                            OdaNumarasi = reader["odaNumarasi"].ToString(),
                            OdaTipi = reader["odaTipi"].ToString(),
                            Fiyat = Convert.ToDecimal(reader["fiyat"]),
                            Durum = Convert.ToBoolean(reader["durum"])
                        };
                    }
                    return null;
                }
                catch (Exception ex)
                {
                    throw new Exception("Oda aranırken hata oluştu: " + ex.Message);
                }
            }
        }

        // Oda Güncelleme
        public void Update(Oda oda)
        {
            using (var connection = DatabaseConnection.GetConnection())
            {
                try
                {
                    connection.Open();
                    string query = @"UPDATE Odalar 
                                   SET odaNumarasi = @odaNumarasi,
                                       odaTipi = @odaTipi,
                                       fiyat = @fiyat,
                                       durum = @durum
                                   WHERE odaID = @odaId";

                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@odaId", oda.OdaID);
                    command.Parameters.AddWithValue("@odaNumarasi", oda.OdaNumarasi);
                    command.Parameters.AddWithValue("@odaTipi", oda.OdaTipi);
                    command.Parameters.AddWithValue("@fiyat", oda.Fiyat);
                    command.Parameters.AddWithValue("@durum", oda.Durum);

                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw new Exception("Oda güncellenirken hata oluştu: " + ex.Message);
                }
            }
        }

        // Oda Durumu Güncelleme
        public void UpdateStatus(int odaId, bool durum)
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

        // Oda Silme
        public void Delete(int odaId)
        {
            using (var connection = DatabaseConnection.GetConnection())
            {
                try
                {
                    connection.Open();
                    string query = "DELETE FROM Odalar WHERE odaID = @odaId";

                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@odaId", odaId);

                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw new Exception("Oda silinirken hata oluştu: " + ex.Message);
                }
            }
        }
    }
}