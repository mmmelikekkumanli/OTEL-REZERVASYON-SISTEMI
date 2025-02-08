using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OtelRezervasyonSistemi.Entities.Concrete
{
    public class Musteri
    {
        // Constructor (Kurucu metod)
        public Musteri()
        {
            // Boş constructor
        }

        // Özellikler (Properties)
        public int MusteriID { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Telefon { get; set; }
        public string Email { get; set; }
        public string TCKimlik { get; set; }

        // Tam ad döndüren metod
        public string TamAd()
        {
            return $"{Ad} {Soyad}";
        }
    }
}
