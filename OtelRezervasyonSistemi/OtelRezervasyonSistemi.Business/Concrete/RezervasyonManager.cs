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
    public class RezervasyonManager : IRezervasyonService
    {
        private IRezervasyonDal _rezervasyonDal;
        private IOdaDal _odaDal;

        public RezervasyonManager()
        {
            _rezervasyonDal = new RezervasyonDal();
            _odaDal = new OdaDal();
        }

        public void Add(Rezervasyon rezervasyon)
        {
            try
            {
                // Tarih kontrolleri
                if (rezervasyon.GirisTarihi < DateTime.Now.Date)
                    throw new Exception("Giriş tarihi geçmiş bir tarih olamaz!");

                if (rezervasyon.CikisTarihi <= rezervasyon.GirisTarihi)
                    throw new Exception("Çıkış tarihi giriş tarihinden sonra olmalıdır!");

                // Oda müsaitlik kontrolü
                if (!IsOdaAvailable(rezervasyon.OdaID, rezervasyon.GirisTarihi, rezervasyon.CikisTarihi))
                    throw new Exception("Seçilen tarihler için oda müsait değil!");

                // Toplam fiyat hesaplama
                rezervasyon.ToplamFiyat = HesaplaToplamFiyat(rezervasyon.OdaID, rezervasyon.GirisTarihi, rezervasyon.CikisTarihi);

                // Rezervasyon durumunu "Aktif" olarak ayarla
                rezervasyon.Durum = "Aktif";

                _rezervasyonDal.Add(rezervasyon);
            }
            catch (Exception ex)
            {
                throw new Exception("Rezervasyon eklenirken bir hata oluştu: " + ex.Message);
            }
        }

        public void Update(Rezervasyon rezervasyon)
        {
            try
            {
                // Tarih kontrolleri
                if (rezervasyon.GirisTarihi < DateTime.Now.Date)
                    throw new Exception("Giriş tarihi geçmiş bir tarih olamaz!");

                if (rezervasyon.CikisTarihi <= rezervasyon.GirisTarihi)
                    throw new Exception("Çıkış tarihi giriş tarihinden sonra olmalıdır!");

                // Mevcut rezervasyonu al
                var mevcutRezervasyon = _rezervasyonDal.GetById(rezervasyon.RezervasyonID);

                // Eğer oda veya tarih değişiyorsa müsaitlik kontrolü yap
                if (mevcutRezervasyon.OdaID != rezervasyon.OdaID ||
                    mevcutRezervasyon.GirisTarihi != rezervasyon.GirisTarihi ||
                    mevcutRezervasyon.CikisTarihi != rezervasyon.CikisTarihi)
                {
                    if (!IsOdaAvailable(rezervasyon.OdaID, rezervasyon.GirisTarihi, rezervasyon.CikisTarihi))
                        throw new Exception("Seçilen tarihler için oda müsait değil!");

                    // Toplam fiyatı güncelle
                    rezervasyon.ToplamFiyat = HesaplaToplamFiyat(rezervasyon.OdaID, rezervasyon.GirisTarihi, rezervasyon.CikisTarihi);
                }

                _rezervasyonDal.Update(rezervasyon);
            }
            catch (Exception ex)
            {
                throw new Exception("Rezervasyon güncellenirken bir hata oluştu: " + ex.Message);
            }
        }

        public void Delete(int rezervasyonId)
        {
            try
            {
                _rezervasyonDal.Delete(rezervasyonId);
            }
            catch (Exception ex)
            {
                throw new Exception("Rezervasyon silinirken bir hata oluştu: " + ex.Message);
            }
        }

        public void RezervasyonIptalEt(int rezervasyonId)
        {
            try
            {
                var rezervasyon = _rezervasyonDal.GetById(rezervasyonId);
                if (rezervasyon == null)
                    throw new Exception("Rezervasyon bulunamadı!");

                // Rezervasyon durumunu "İptal" olarak güncelle
                rezervasyon.Durum = "İptal";
                _rezervasyonDal.Update(rezervasyon);

                // Odayı müsait duruma getir
                _odaDal.UpdateStatus(rezervasyon.OdaID, true);
            }
            catch (Exception ex)
            {
                throw new Exception("Rezervasyon iptal edilirken bir hata oluştu: " + ex.Message);
            }
        }

        public List<Rezervasyon> GetAll()
        {
            try
            {
                return _rezervasyonDal.GetAll();
            }
            catch (Exception ex)
            {
                throw new Exception("Rezervasyonlar listelenirken bir hata oluştu: " + ex.Message);
            }
        }

        public List<Rezervasyon> GetActiveReservations()
        {
            try
            {
                return _rezervasyonDal.GetActiveReservations();
            }
            catch (Exception ex)
            {
                throw new Exception("Aktif rezervasyonlar listelenirken bir hata oluştu: " + ex.Message);
            }
        }

        public Rezervasyon GetById(int rezervasyonId)
        {
            try
            {
                return _rezervasyonDal.GetById(rezervasyonId);
            }
            catch (Exception ex)
            {
                throw new Exception("Rezervasyon bilgileri alınırken bir hata oluştu: " + ex.Message);
            }
        }

        public List<Rezervasyon> GetByMusteriId(int musteriId)
        {
            try
            {
                return _rezervasyonDal.GetByMusteriId(musteriId);
            }
            catch (Exception ex)
            {
                throw new Exception("Müşteri rezervasyonları listelenirken bir hata oluştu: " + ex.Message);
            }
        }

        public bool IsOdaAvailable(int odaId, DateTime girisTarihi, DateTime cikisTarihi)
        {
            try
            {
                return _rezervasyonDal.IsOdaAvailable(odaId, girisTarihi, cikisTarihi);
            }
            catch (Exception ex)
            {
                throw new Exception("Oda müsaitlik kontrolü yapılırken bir hata oluştu: " + ex.Message);
            }
        }

        public decimal HesaplaToplamFiyat(int odaId, DateTime girisTarihi, DateTime cikisTarihi)
        {
            try
            {
                var oda = _odaDal.GetById(odaId);
                if (oda == null)
                    throw new Exception("Oda bulunamadı!");

                int gunSayisi = (cikisTarihi - girisTarihi).Days;
                return oda.Fiyat * gunSayisi;
            }
            catch (Exception ex)
            {
                throw new Exception("Toplam fiyat hesaplanırken bir hata oluştu: " + ex.Message);
            }
        }
    }
}