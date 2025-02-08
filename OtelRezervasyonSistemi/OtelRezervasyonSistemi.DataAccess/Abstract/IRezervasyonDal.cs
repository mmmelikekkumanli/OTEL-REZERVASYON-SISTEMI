using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OtelRezervasyonSistemi.Entities.Concrete;


namespace OtelRezervasyonSistemi.DataAccess.Abstract
{
    public interface IRezervasyonDal
    {
        void Add(Rezervasyon rezervasyon);                     // Rezervasyon ekleme
        void Update(Rezervasyon rezervasyon);                  // Rezervasyon güncelleme
        void Delete(int rezervasyonId);                        // Rezervasyon silme
        Rezervasyon GetById(int rezervasyonId);               // ID'ye göre rezervasyon getirme
        List<Rezervasyon> GetAll();                           // Tüm rezervasyonları getirme
        List<Rezervasyon> GetByMusteriId(int musteriId);      // Müşteriye ait rezervasyonları getirme
        List<Rezervasyon> GetActiveReservations();            // Aktif rezervasyonları getirme
        bool IsOdaAvailable(int odaId, DateTime girisTarihi, DateTime cikisTarihi); // Oda müsaitlik kontrolü
    }
}