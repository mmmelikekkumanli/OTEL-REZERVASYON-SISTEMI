using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OtelRezervasyonSistemi.Entities.Concrete;

namespace OtelRezervasyonSistemi.DataAccess.Abstract
{
    public interface IMusteriDal
    {
        void Add(Musteri musteri);        // Müşteri ekleme
        void Update(Musteri musteri);     // Müşteri güncelleme
        void Delete(int musteriId);       // Müşteri silme
        Musteri GetById(int musteriId);   // ID'ye göre müşteri getirme
        List<Musteri> GetAll();           // Tüm müşterileri getirme
        Musteri GetByTCKN(string tcKimlik); // TC Kimlik No'ya göre müşteri getirme
    }
}