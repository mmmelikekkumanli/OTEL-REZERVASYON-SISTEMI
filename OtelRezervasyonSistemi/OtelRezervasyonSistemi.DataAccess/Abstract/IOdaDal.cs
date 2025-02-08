using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OtelRezervasyonSistemi.Entities.Concrete;

namespace OtelRezervasyonSistemi.DataAccess.Abstract
{
    public interface IOdaDal
    {
        void Add(Oda oda);                // Oda ekleme
        void Update(Oda oda);             // Oda güncelleme
        void Delete(int odaId);           // Oda silme
        Oda GetById(int odaId);           // ID'ye göre oda getirme
        List<Oda> GetAll();               // Tüm odaları getirme
        List<Oda> GetAvailableRooms();    // Müsait odaları getirme
        void UpdateStatus(int odaId, bool durum); // Oda durumunu güncelleme
    }
}