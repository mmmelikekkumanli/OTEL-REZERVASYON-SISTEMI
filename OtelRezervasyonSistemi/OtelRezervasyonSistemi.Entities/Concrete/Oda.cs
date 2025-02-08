using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelRezervasyonSistemi.Entities.Concrete
{
    public class Oda
    {
        public Oda()
        {
            // Boş constructor
        }

        public int OdaID { get; set; }
        public string OdaNumarasi { get; set; }
        public string OdaTipi { get; set; }
        public decimal Fiyat { get; set; }
        public bool Durum { get; set; }
        public string DurumText { get; set; }
        
    }
}