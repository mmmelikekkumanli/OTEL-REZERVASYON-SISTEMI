using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelRezervasyonSistemi.Entities.Concrete
{
    public class Fatura
    {
        public Fatura()
        {
            FaturaTarihi = DateTime.Now;
            OdemeDurumu = "Ödenmedi";
        }

        public int FaturaID { get; set; }
        public int RezervasyonID { get; set; }
        public decimal ToplamTutar { get; set; }
        public DateTime FaturaTarihi { get; set; }
        public string OdemeDurumu { get; set; }  // Ödendi, Ödenmedi, Kısmi Ödeme
    }
}