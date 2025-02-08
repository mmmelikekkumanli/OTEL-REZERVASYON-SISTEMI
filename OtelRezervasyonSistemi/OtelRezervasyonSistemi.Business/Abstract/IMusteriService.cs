using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OtelRezervasyonSistemi.Entities.Concrete;


namespace OtelRezervasyonSistemi.Business.Abstract
{
    public interface IMusteriService
    {
        void Add(Musteri musteri);
        void Update(Musteri musteri);
        void Delete(int musteriId);
        Musteri GetById(int musteriId);
        List<Musteri> GetAll();
        Musteri GetByTCKN(string tcKimlik);
        bool TCKimlikKontrol(string tcKimlik); // TC Kimlik formatı kontrolü
        bool MusteriVarMi(string tcKimlik);    // Müşteri kayıtlı mı kontrolü
    }
}