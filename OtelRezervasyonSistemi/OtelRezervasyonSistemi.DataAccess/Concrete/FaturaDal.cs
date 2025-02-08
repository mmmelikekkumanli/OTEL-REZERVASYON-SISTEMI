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
    public class FaturaDal : IFaturaDal
    {
        // Fatura Ekleme
        public void Add(Fatura fatura)
        {
            using (var connection = DatabaseConnection.GetConnection())
            {
                try
                {
                    connection.Open();
                    string query = @"INSERT INTO Faturalar 
                                   (rezervasyonID, toplamTutar, faturaTarihi, odemeDurumu) 
                                   VALUES 
                                   (@rezervasyonId, @toplamTutar, @faturaTarihi, @odemeDurumu)";

                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@rezervasyonId", fatura.RezervasyonID);
                    command.Parameters.AddWithValue("@toplamTutar", fatura.ToplamTutar);
                    command.Parameters.AddWithValue("@faturaTarihi", fatura.FaturaTarihi);
                    command.Parameters.AddWithValue("@odemeDurumu", fatura.OdemeDurumu);

                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw new Exception("Fatura eklenirken hata oluştu: " + ex.Message);
                }
            }
        }

        // Tüm Faturaları Getirme
        public List<Fatura> GetAll()
        {
            List<Fatura> faturalar = new List<Fatura>();

            using (var connection = DatabaseConnection.GetConnection())
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM Faturalar";

                    MySqlCommand command = new MySqlCommand(query, connection);
                    MySqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        faturalar.Add(new Fatura
                        {
                            FaturaID = Convert.ToInt32(reader["faturaID"]),
                            RezervasyonID = Convert.ToInt32(reader["rezervasyonID"]),
                            ToplamTutar = Convert.ToDecimal(reader["toplamTutar"]),
                            FaturaTarihi = Convert.ToDateTime(reader["faturaTarihi"]),
                            OdemeDurumu = reader["odemeDurumu"].ToString()
                        });
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Faturalar listelenirken hata oluştu: " + ex.Message);
                }
            }
            return faturalar;
        }

        // ID'ye Göre Fatura Getirme
        public Fatura GetById(int faturaId)
        {
            using (var connection = DatabaseConnection.GetConnection())
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM Faturalar WHERE faturaID = @faturaId";

                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@faturaId", faturaId);

                    MySqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        return new Fatura
                        {
                            FaturaID = Convert.ToInt32(reader["faturaID"]),
                            RezervasyonID = Convert.ToInt32(reader["rezervasyonID"]),
                            ToplamTutar = Convert.ToDecimal(reader["toplamTutar"]),
                            FaturaTarihi = Convert.ToDateTime(reader["faturaTarihi"]),
                            OdemeDurumu = reader["odemeDurumu"].ToString()
                        };
                    }
                    return null;
                }
                catch (Exception ex)
                {
                    throw new Exception("Fatura aranırken hata oluştu: " + ex.Message);
                }
            }
        }

        // Rezervasyona Göre Fatura Getirme
        public List<Fatura> GetByRezervasyonId(int rezervasyonId)
        {
            List<Fatura> faturalar = new List<Fatura>();

            using (var connection = DatabaseConnection.GetConnection())
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM Faturalar WHERE rezervasyonID = @rezervasyonId";

                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@rezervasyonId", rezervasyonId);

                    MySqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        faturalar.Add(new Fatura
                        {
                            FaturaID = Convert.ToInt32(reader["faturaID"]),
                            RezervasyonID = Convert.ToInt32(reader["rezervasyonID"]),
                            ToplamTutar = Convert.ToDecimal(reader["toplamTutar"]),
                            FaturaTarihi = Convert.ToDateTime(reader["faturaTarihi"]),
                            OdemeDurumu = reader["odemeDurumu"].ToString()
                        });
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Rezervasyona ait faturalar listelenirken hata oluştu: " + ex.Message);
                }
            }
            return faturalar;
        }

        // Ödenmemiş Faturaları Getirme
        public List<Fatura> GetUnpaidInvoices()
        {
            List<Fatura> faturalar = new List<Fatura>();

            using (var connection = DatabaseConnection.GetConnection())
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM Faturalar WHERE odemeDurumu = 'Ödenmedi'";

                    MySqlCommand command = new MySqlCommand(query, connection);
                    MySqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        faturalar.Add(new Fatura
                        {
                            FaturaID = Convert.ToInt32(reader["faturaID"]),
                            RezervasyonID = Convert.ToInt32(reader["rezervasyonID"]),
                            ToplamTutar = Convert.ToDecimal(reader["toplamTutar"]),
                            FaturaTarihi = Convert.ToDateTime(reader["faturaTarihi"]),
                            OdemeDurumu = reader["odemeDurumu"].ToString()
                        });
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Ödenmemiş faturalar listelenirken hata oluştu: " + ex.Message);
                }
            }
            return faturalar;
        }

        // Fatura Güncelleme
        public void Update(Fatura fatura)
        {
            using (var connection = DatabaseConnection.GetConnection())
            {
                try
                {
                    connection.Open();
                    string query = @"UPDATE Faturalar 
                                   SET rezervasyonID = @rezervasyonId,
                                       toplamTutar = @toplamTutar,
                                       faturaTarihi = @faturaTarihi,
                                       odemeDurumu = @odemeDurumu
                                   WHERE faturaID = @faturaId";

                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@faturaId", fatura.FaturaID);
                    command.Parameters.AddWithValue("@rezervasyonId", fatura.RezervasyonID);
                    command.Parameters.AddWithValue("@toplamTutar", fatura.ToplamTutar);
                    command.Parameters.AddWithValue("@faturaTarihi", fatura.FaturaTarihi);
                    command.Parameters.AddWithValue("@odemeDurumu", fatura.OdemeDurumu);

                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw new Exception("Fatura güncellenirken hata oluştu: " + ex.Message);
                }
            }
        }

        // Ödeme Durumu Güncelleme
        public void UpdatePaymentStatus(int faturaId, string durum)
        {
            using (var connection = DatabaseConnection.GetConnection())
            {
                try
                {
                    connection.Open();
                    string query = "UPDATE Faturalar SET odemeDurumu = @durum WHERE faturaID = @faturaId";

                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@faturaId", faturaId);
                    command.Parameters.AddWithValue("@durum", durum);

                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw new Exception("Fatura ödeme durumu güncellenirken hata oluştu: " + ex.Message);
                }
            }
        }

        // Fatura Silme
        public void Delete(int faturaId)
        {
            using (var connection = DatabaseConnection.GetConnection())
            {
                try
                {
                    connection.Open();
                    string query = "DELETE FROM Faturalar WHERE faturaID = @faturaId";

                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@faturaId", faturaId);

                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw new Exception("Fatura silinirken hata oluştu: " + ex.Message);
                }
            }
        }
    }
}