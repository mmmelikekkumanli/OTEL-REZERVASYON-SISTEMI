using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelRezervasyonSistemi.Entities.Concrete
{
    public class Rezervasyon
    {
        public Rezervasyon()
        {
            Durum = "Aktif"; // Varsayılan değer
        }

        public int RezervasyonID { get; set; }
        public int MusteriID { get; set; }
        public int OdaID { get; set; }
        public DateTime GirisTarihi { get; set; }
        public DateTime CikisTarihi { get; set; }
        public decimal ToplamFiyat { get; set; }
        public string Durum { get; set; }  // Aktif, İptal, Tamamlandı

        public int KonaklamaSuresi()
        {
            return (CikisTarihi - GirisTarihi).Days;
        }
    }
}