using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace OtelRezervasyonSistemi.DataAccess.Concrete
{
    public class DatabaseConnection
    {
        // Veritabanı bağlantı bilgileri
        private static readonly string connectionString = "Server=172.21.54.253;Database=25_132230090;Uid=25_132230090;Pwd=!nif.ogr90KU";

        public static MySqlConnection GetConnection()
        {
            try
            {
                // Yeni bir bağlantı oluştur
                MySqlConnection connection = new MySqlConnection(connectionString);
                return connection;
            }
            catch (Exception ex)
            {
                // Hata durumunda kullanıcıyı bilgilendir
                throw new Exception("Veritabanı bağlantısı oluşturulamadı: " + ex.Message);
            }
        }

        // Bağlantının çalışıp çalışmadığını test et
        public static bool TestConnection()
        {
            try
            {
                using (MySqlConnection connection = GetConnection())
                {
                    connection.Open();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        // Yeni eklenen test metodu
        public static void TestDatabaseConnection()
        {
            try
            {
                using (var connection = GetConnection())
                {
                    connection.Open();
                    MessageBox.Show("Veritabanı bağlantısı başarılı!", "Test",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veritabanı bağlantı hatası:\n\n" + ex.Message, "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}