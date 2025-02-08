using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OtelRezervasyonSistemi.Entities.Concrete;


namespace OtelRezervasyonSistemi.DataAccess.Abstract
{
    public interface IFaturaDal
    {
        void Add(Fatura fatura);                              // Fatura ekleme
        void Update(Fatura fatura);                           // Fatura güncelleme
        void Delete(int faturaId);                            // Fatura silme
        Fatura GetById(int faturaId);                         // ID'ye göre fatura getirme
        List<Fatura> GetAll();                                // Tüm faturaları getirme
        List<Fatura> GetByRezervasyonId(int rezervasyonId);   // Rezervasyona göre fatura getirme
        List<Fatura> GetUnpaidInvoices();                     // Ödenmemiş faturaları getirme
        void UpdatePaymentStatus(int faturaId, string durum); // Ödeme durumu güncelleme
    }
}