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
    public class OdaManager : IOdaService
    {
        private IOdaDal _odaDal;

        public OdaManager()
        {
            _odaDal = new OdaDal();
        }

        public void Add(Oda oda)
        {
            try
            {
                // Oda numarası boş olamaz
                if (string.IsNullOrEmpty(oda.OdaNumarasi))
                    throw new Exception("Oda numarası boş olamaz!");

                // Oda numarası benzersiz olmalı
                if (OdaNumarasiVarMi(oda.OdaNumarasi))
                    throw new Exception("Bu oda numarası zaten kullanılmakta!");

                // Oda tipi boş olamaz
                if (string.IsNullOrEmpty(oda.OdaTipi))
                    throw new Exception("Oda tipi boş olamaz!");

                // Fiyat kontrolü
                if (oda.Fiyat <= 0)
                    throw new Exception("Oda fiyatı 0'dan büyük olmalıdır!");

                _odaDal.Add(oda);
            }
            catch (Exception ex)
            {
                throw new Exception("Oda eklenirken bir hata oluştu: " + ex.Message);
            }
        }

        public void Update(Oda oda)
        {
            try
            {
                // Temel kontroller
                if (string.IsNullOrEmpty(oda.OdaNumarasi))
                    throw new Exception("Oda numarası boş olamaz!");

                if (string.IsNullOrEmpty(oda.OdaTipi))
                    throw new Exception("Oda tipi boş olamaz!");

                if (oda.Fiyat <= 0)
                    throw new Exception("Oda fiyatı 0'dan büyük olmalıdır!");

                // Mevcut odanın numarası değiştiriliyorsa ve yeni numara başka bir odada kullanılıyorsa
                var mevcutOda = _odaDal.GetById(oda.OdaID);
                if (mevcutOda.OdaNumarasi != oda.OdaNumarasi && OdaNumarasiVarMi(oda.OdaNumarasi))
                    throw new Exception("Bu oda numarası zaten kullanılmakta!");

                _odaDal.Update(oda);
            }
            catch (Exception ex)
            {
                throw new Exception("Oda güncellenirken bir hata oluştu: " + ex.Message);
            }
        }

        public void Delete(int odaId)
        {
            try
            {
                // Odanın aktif rezervasyonu var mı kontrolü yapılabilir
                _odaDal.Delete(odaId);
            }
            catch (Exception ex)
            {
                throw new Exception("Oda silinirken bir hata oluştu: " + ex.Message);
            }
        }

        public List<Oda> GetAll()
        {
            try
            {
                var odalar = _odaDal.GetAll();
                foreach (var oda in odalar)
                {
                    // Durum değerini string olarak ayarla
                    oda.DurumText = oda.Durum ? "Müsait" : "Dolu";
                }
                return odalar;
            }
            catch (Exception ex)
            {
                throw new Exception("Odalar listelenirken bir hata oluştu: " + ex.Message);
            }
        }

        public List<Oda> GetAvailableRooms()
        {
            try
            {
                var odalar = _odaDal.GetAvailableRooms();
                foreach (var oda in odalar)
                {
                    // Durum değerini string olarak ayarla
                    oda.DurumText = oda.Durum ? "Müsait" : "Dolu";
                }
                return odalar;
            }
            catch (Exception ex)
            {
                throw new Exception("Müsait odalar listelenirken bir hata oluştu: " + ex.Message);
            }
        }

        public Oda GetById(int odaId)
        {
            try
            {
                var oda = _odaDal.GetById(odaId);
                oda.DurumText = oda.Durum ? "Müsait" : "Dolu";
                return oda;
            }
            catch (Exception ex)
            {
                throw new Exception("Oda bilgileri alınırken bir hata oluştu: " + ex.Message);
            }
        }

        public void UpdateStatus(int odaId, bool durum)
        {
            try
            {
                _odaDal.UpdateStatus(odaId, durum);
            }
            catch (Exception ex)
            {
                throw new Exception("Oda durumu güncellenirken bir hata oluştu: " + ex.Message);
            }
        }

        public bool OdaNumarasiVarMi(string odaNumarasi)
        {
            try
            {
                var odalar = _odaDal.GetAll();
                return odalar.Any(o => o.OdaNumarasi == odaNumarasi);
            }
            catch (Exception ex)
            {
                throw new Exception("Oda numarası kontrolü yapılırken bir hata oluştu: " + ex.Message);
            }
        }
    }
}