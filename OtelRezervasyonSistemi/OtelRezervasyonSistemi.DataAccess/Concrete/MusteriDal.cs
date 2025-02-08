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
    public class MusteriDal : IMusteriDal
    {
        // Müşteri Ekleme
        public void Add(Musteri musteri)
        {
            using (var connection = DatabaseConnection.GetConnection())
            {
                try
                {
                    connection.Open();
                    string query = @"INSERT INTO Musteriler (ad, soyad, telefon, email, tcKimlik) 
                                   VALUES (@ad, @soyad, @telefon, @email, @tcKimlik)";

                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@ad", musteri.Ad);
                    command.Parameters.AddWithValue("@soyad", musteri.Soyad);
                    command.Parameters.AddWithValue("@telefon", musteri.Telefon);
                    command.Parameters.AddWithValue("@email", musteri.Email ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@tcKimlik", musteri.TCKimlik);

                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw new Exception("Müşteri eklenirken hata oluştu: " + ex.Message);
                }
            }
        }

        // Tüm Müşterileri Getirme
        public List<Musteri> GetAll()
        {
            List<Musteri> musteriler = new List<Musteri>();

            using (var connection = DatabaseConnection.GetConnection())
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM Musteriler";

                    MySqlCommand command = new MySqlCommand(query, connection);
                    MySqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        musteriler.Add(new Musteri
                        {
                            MusteriID = Convert.ToInt32(reader["musteriID"]),
                            Ad = reader["ad"].ToString(),
                            Soyad = reader["soyad"].ToString(),
                            Telefon = reader["telefon"].ToString(),
                            Email = reader["email"] == DBNull.Value ? null : reader["email"].ToString(),
                            TCKimlik = reader["tcKimlik"].ToString()
                        });
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Müşteriler listelenirken hata oluştu: " + ex.Message);
                }
            }
            return musteriler;
        }

        // TC Kimlik Numarasına göre müşteri getirme
        public Musteri GetByTCKN(string tcKimlik)
        {
            using (var connection = DatabaseConnection.GetConnection())
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM Musteriler WHERE tcKimlik = @tcKimlik";

                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@tcKimlik", tcKimlik);

                    MySqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        return new Musteri
                        {
                            MusteriID = Convert.ToInt32(reader["musteriID"]),
                            Ad = reader["ad"].ToString(),
                            Soyad = reader["soyad"].ToString(),
                            Telefon = reader["telefon"].ToString(),
                            Email = reader["email"] == DBNull.Value ? null : reader["email"].ToString(),
                            TCKimlik = reader["tcKimlik"].ToString()
                        };
                    }
                    return null;
                }
                catch (Exception ex)
                {
                    throw new Exception("Müşteri aranırken hata oluştu: " + ex.Message);
                }
            }
        }

        // ID'ye göre müşteri getirme
        public Musteri GetById(int musteriId)
        {
            using (var connection = DatabaseConnection.GetConnection())
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM Musteriler WHERE musteriID = @musteriID";

                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@musteriID", musteriId);

                    MySqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        return new Musteri
                        {
                            MusteriID = Convert.ToInt32(reader["musteriID"]),
                            Ad = reader["ad"].ToString(),
                            Soyad = reader["soyad"].ToString(),
                            Telefon = reader["telefon"].ToString(),
                            Email = reader["email"] == DBNull.Value ? null : reader["email"].ToString(),
                            TCKimlik = reader["tcKimlik"].ToString()
                        };
                    }
                    return null;
                }
                catch (Exception ex)
                {
                    throw new Exception("Müşteri aranırken hata oluştu: " + ex.Message);
                }
            }
        }

        // Müşteri güncelleme
        public void Update(Musteri musteri)
        {
            using (var connection = DatabaseConnection.GetConnection())
            {
                try
                {
                    connection.Open();
                    string query = @"UPDATE Musteriler 
                                   SET ad = @ad, 
                                       soyad = @soyad, 
                                       telefon = @telefon, 
                                       email = @email, 
                                       tcKimlik = @tcKimlik 
                                   WHERE musteriID = @musteriID";

                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@musteriID", musteri.MusteriID);
                    command.Parameters.AddWithValue("@ad", musteri.Ad);
                    command.Parameters.AddWithValue("@soyad", musteri.Soyad);
                    command.Parameters.AddWithValue("@telefon", musteri.Telefon);
                    command.Parameters.AddWithValue("@email", musteri.Email ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@tcKimlik", musteri.TCKimlik);

                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw new Exception("Müşteri güncellenirken hata oluştu: " + ex.Message);
                }
            }
        }

        // Müşteri silme
        public void Delete(int musteriId)
        {
            using (var connection = DatabaseConnection.GetConnection())
            {
                try
                {
                    connection.Open();
                    string query = "DELETE FROM Musteriler WHERE musteriID = @musteriID";

                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@musteriID", musteriId);

                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw new Exception("Müşteri silinirken hata oluştu: " + ex.Message);
                }
            }
        }
    }
}