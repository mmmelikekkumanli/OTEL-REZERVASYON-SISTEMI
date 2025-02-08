using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OtelRezervasyonSistemi.Entities.Concrete;

namespace OtelRezervasyonSistemi.Business.Abstract
{
    public interface IFaturaService
    {
        void Add(Fatura fatura);
        void Update(Fatura fatura);
        void Delete(int faturaId);
        Fatura GetById(int faturaId);
        List<Fatura> GetAll();
        List<Fatura> GetByRezervasyonId(int rezervasyonId);
        List<Fatura> GetUnpaidInvoices();
        void UpdatePaymentStatus(int faturaId, string durum);
        Fatura CreateInvoiceFromReservation(int rezervasyonId);  // Rezervasyondan fatura oluştur
        decimal HesaplaKDV(decimal tutar);  // KDV hesapla
    }
}