using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OtelRezervasyonSistemi.Business.Abstract;
using OtelRezervasyonSistemi.DataAccess.Abstract;
using OtelRezervasyonSistemi.DataAccess.Concrete;
using OtelRezervasyonSistemi.Entities.Concrete;
using System.Text.RegularExpressions;

namespace OtelRezervasyonSistemi.Business.Concrete
{
    public class MusteriManager : IMusteriService
    {
        private IMusteriDal _musteriDal;

        public MusteriManager()
        {
            _musteriDal = new MusteriDal();
        }

        public void Add(Musteri musteri)
        {
            try
            {
                // TC Kimlik kontrolü
                if (!TCKimlikKontrol(musteri.TCKimlik))
                    throw new Exception("Geçersiz TC Kimlik Numarası!");

                // TC Kimlik kayıtlı mı kontrolü
                if (MusteriVarMi(musteri.TCKimlik))
                    throw new Exception("Bu TC Kimlik numarası ile kayıtlı müşteri bulunmaktadır!");

                // Telefon format kontrolü
                if (!TelefonKontrol(musteri.Telefon))
                    throw new Exception("Geçersiz telefon numarası formatı!");

                // Email format kontrolü (eğer email girilmişse)
                if (!string.IsNullOrEmpty(musteri.Email) && !EmailKontrol(musteri.Email))
                    throw new Exception("Geçersiz email formatı!");

                // Boş alan kontrolü
                if (string.IsNullOrEmpty(musteri.Ad) || string.IsNullOrEmpty(musteri.Soyad))
                    throw new Exception("Ad ve soyad alanları boş bırakılamaz!");

                _musteriDal.Add(musteri);
            }
            catch (Exception ex)
            {
                throw new Exception("Müşteri eklenirken bir hata oluştu: " + ex.Message);
            }
        }

        public void Update(Musteri musteri)
        {
            try
            {
                // Temel kontroller
                if (!TCKimlikKontrol(musteri.TCKimlik))
                    throw new Exception("Geçersiz TC Kimlik Numarası!");

                if (!TelefonKontrol(musteri.Telefon))
                    throw new Exception("Geçersiz telefon numarası formatı!");

                if (!string.IsNullOrEmpty(musteri.Email) && !EmailKontrol(musteri.Email))
                    throw new Exception("Geçersiz email formatı!");

                // Boş alan kontrolü
                if (string.IsNullOrEmpty(musteri.Ad) || string.IsNullOrEmpty(musteri.Soyad))
                    throw new Exception("Ad ve soyad alanları boş bırakılamaz!");

                _musteriDal.Update(musteri);
            }
            catch (Exception ex)
            {
                throw new Exception("Müşteri güncellenirken bir hata oluştu: " + ex.Message);
            }
        }

        public void Delete(int musteriId)
        {
            try
            {
                // Müşterinin aktif rezervasyonu var mı kontrolü yapılabilir
                _musteriDal.Delete(musteriId);
            }
            catch (Exception ex)
            {
                throw new Exception("Müşteri silinirken bir hata oluştu: " + ex.Message);
            }
        }

        public Musteri GetById(int musteriId)
        {
            try
            {
                return _musteriDal.GetById(musteriId);
            }
            catch (Exception ex)
            {
                throw new Exception("Müşteri bilgileri alınırken bir hata oluştu: " + ex.Message);
            }
        }

        public List<Musteri> GetAll()
        {
            try
            {
                return _musteriDal.GetAll();
            }
            catch (Exception ex)
            {
                throw new Exception("Müşteri listesi alınırken bir hata oluştu: " + ex.Message);
            }
        }

        public Musteri GetByTCKN(string tcKimlik)
        {
            try
            {
                if (!TCKimlikKontrol(tcKimlik))
                    throw new Exception("Geçersiz TC Kimlik Numarası!");

                return _musteriDal.GetByTCKN(tcKimlik);
            }
            catch (Exception ex)
            {
                throw new Exception("Müşteri aranırken bir hata oluştu: " + ex.Message);
            }
        }

        public bool TCKimlikKontrol(string tcKimlik)
        {
            // TC Kimlik 11 haneli olmalı ve sadece rakamlardan oluşmalı
            if (string.IsNullOrEmpty(tcKimlik) || tcKimlik.Length != 11)
                return false;

            return Regex.IsMatch(tcKimlik, @"^[0-9]{11}$");
        }

        public bool MusteriVarMi(string tcKimlik)
        {
            return _musteriDal.GetByTCKN(tcKimlik) != null;
        }

        // Yardımcı metotlar
        private bool TelefonKontrol(string telefon)
        {
            // Telefon formatı: 5XX-XXX-XXXX
            return Regex.IsMatch(telefon, @"^5[0-9]{2}[0-9]{3}[0-9]{4}$");
        }

        private bool EmailKontrol(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
    }
}