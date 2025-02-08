using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OtelRezervasyonSistemi.Entities.Concrete;

namespace OtelRezervasyonSistemi.Business.Abstract
{
    public interface IOdaService
    {
        void Add(Oda oda);
        void Update(Oda oda);
        void Delete(int odaId);
        Oda GetById(int odaId);
        List<Oda> GetAll();
        List<Oda> GetAvailableRooms();       // Müsait odaları getir
        void UpdateStatus(int odaId, bool durum);  // Oda durumunu güncelle
        bool OdaNumarasiVarMi(string odaNumarasi); // Oda numarası kontrolü
    }
}