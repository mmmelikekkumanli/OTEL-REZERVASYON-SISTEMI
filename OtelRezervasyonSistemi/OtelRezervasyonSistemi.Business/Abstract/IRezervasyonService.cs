using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OtelRezervasyonSistemi.Entities.Concrete;

namespace OtelRezervasyonSistemi.Business.Abstract
{
    public interface IRezervasyonService
    {
        void Add(Rezervasyon rezervasyon);
        void Update(Rezervasyon rezervasyon);
        void Delete(int rezervasyonId);
        Rezervasyon GetById(int rezervasyonId);
        List<Rezervasyon> GetAll();
        List<Rezervasyon> GetByMusteriId(int musteriId);
        List<Rezervasyon> GetActiveReservations();
        bool IsOdaAvailable(int odaId, DateTime girisTarihi, DateTime cikisTarihi);
        decimal HesaplaToplamFiyat(int odaId, DateTime girisTarihi, DateTime cikisTarihi);
        void RezervasyonIptalEt(int rezervasyonId);
    }
}