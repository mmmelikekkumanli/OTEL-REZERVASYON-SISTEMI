using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OtelRezervasyonSistemi.Business.Abstract;
using OtelRezervasyonSistemi.DataAccess.Abstract;
using OtelRezervasyonSistemi.DataAccess.Concrete;
using OtelRezervasyonSistemi.Entities.Concrete;

namespace OtelRezervasyonSistemi.Business.Concrete
{
    public class FaturaManager : IFaturaService
    {
        private IFaturaDal _faturaDal;
        private IRezervasyonDal _rezervasyonDal;
        private const decimal KDV_ORANI = 0.18M;  // %18 KDV

        public FaturaManager()
        {
            _faturaDal = new FaturaDal();
            _rezervasyonDal = new RezervasyonDal();
        }

        public void Add(Fatura fatura)
        {
            try
            {
                // Temel kontroller
                if (fatura.ToplamTutar <= 0)
                    throw new Exception("Toplam tutar 0'dan büyük olmalıdır!");

                if (string.IsNullOrEmpty(fatura.OdemeDurumu))
                    fatura.OdemeDurumu = "Ödenmedi";

                // Fatura tarihini otomatik ayarla
                fatura.FaturaTarihi = DateTime.Now;

                _faturaDal.Add(fatura);
            }
            catch (Exception ex)
            {
                throw new Exception("Fatura eklenirken bir hata oluştu: " + ex.Message);
            }
        }

        public Fatura CreateInvoiceFromReservation(int rezervasyonId)
        {
            try
            {
                var rezervasyon = _rezervasyonDal.GetById(rezervasyonId);
                if (rezervasyon == null)
                    throw new Exception("Rezervasyon bulunamadı!");

                // Eğer rezervasyona ait fatura varsa hata ver
                var mevcutFaturalar = _faturaDal.GetByRezervasyonId(rezervasyonId);
                if (mevcutFaturalar.Count > 0)
                    throw new Exception("Bu rezervasyona ait fatura zaten oluşturulmuş!");

                var fatura = new Fatura
                {
                    RezervasyonID = rezervasyonId,
                    ToplamTutar = rezervasyon.ToplamFiyat + HesaplaKDV(rezervasyon.ToplamFiyat),
                    FaturaTarihi = DateTime.Now,
                    OdemeDurumu = "Ödenmedi"
                };

                _faturaDal.Add(fatura);
                return fatura;
            }
            catch (Exception ex)
            {
                throw new Exception("Fatura oluşturulurken bir hata oluştu: " + ex.Message);
            }
        }

        public void Delete(int faturaId)
        {
            try
            {
                _faturaDal.Delete(faturaId);
            }
            catch (Exception ex)
            {
                throw new Exception("Fatura silinirken bir hata oluştu: " + ex.Message);
            }
        }

        public List<Fatura> GetAll()
        {
            try
            {
                return _faturaDal.GetAll();
            }
            catch (Exception ex)
            {
                throw new Exception("Faturalar listelenirken bir hata oluştu: " + ex.Message);
            }
        }

        public Fatura GetById(int faturaId)
        {
            try
            {
                return _faturaDal.GetById(faturaId);
            }
            catch (Exception ex)
            {
                throw new Exception("Fatura bilgileri alınırken bir hata oluştu: " + ex.Message);
            }
        }

        public List<Fatura> GetByRezervasyonId(int rezervasyonId)
        {
            try
            {
                return _faturaDal.GetByRezervasyonId(rezervasyonId);
            }
            catch (Exception ex)
            {
                throw new Exception("Rezervasyona ait faturalar listelenirken bir hata oluştu: " + ex.Message);
            }
        }

        public List<Fatura> GetUnpaidInvoices()
        {
            try
            {
                return _faturaDal.GetUnpaidInvoices();
            }
            catch (Exception ex)
            {
                throw new Exception("Ödenmemiş faturalar listelenirken bir hata oluştu: " + ex.Message);
            }
        }

        public decimal HesaplaKDV(decimal tutar)
        {
            return tutar * KDV_ORANI;
        }

        public void Update(Fatura fatura)
        {
            try
            {
                if (fatura.ToplamTutar <= 0)
                    throw new Exception("Toplam tutar 0'dan büyük olmalıdır!");

                _faturaDal.Update(fatura);
            }
            catch (Exception ex)
            {
                throw new Exception("Fatura güncellenirken bir hata oluştu: " + ex.Message);
            }
        }

        public void UpdatePaymentStatus(int faturaId, string durum)
        {
            try
            {
                if (string.IsNullOrEmpty(durum))
                    throw new Exception("Ödeme durumu boş olamaz!");

                if (durum != "Ödendi" && durum != "Ödenmedi" && durum != "Kısmi Ödeme")
                    throw new Exception("Geçersiz ödeme durumu!");

                _faturaDal.UpdatePaymentStatus(faturaId, durum);
            }
            catch (Exception ex)
            {
                throw new Exception("Ödeme durumu güncellenirken bir hata oluştu: " + ex.Message);
            }
        }
    }
}