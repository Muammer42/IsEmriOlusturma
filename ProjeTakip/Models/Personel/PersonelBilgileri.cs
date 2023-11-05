using ProjeTakip.Models.ProjeTakip;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjeTakip.Models.Personel
{
    public class PersonelBilgileri
    {
        public PersonelBilgileri()
        {
            this.PersonelProjeleris = new HashSet<PersonelProjeleri>();
        }
        [Key]
        public int PersonelBilgileriId { get; set; }

        [DisplayName("E-POSTA")]
        public string Eposta { get; set; }
        [DisplayName("ŞİFRE")] //İSİMNLENDİRMELER
        [StringLength(25, ErrorMessage = "Maximum uzunluk 25 karakterden fazla olamaz")]
        public string Sifre { get; set; }
        [DisplayName("YETKİ")]
        [StringLength(15, ErrorMessage = "Maximum uzunluk 15 karakterden fazla olamaz")]
        public string Yetki { get; set; }
        [DisplayName("AD SOYAD")]
        [StringLength(50, ErrorMessage = "Maximum uzunluk 50 karakterden fazla olamaz")]
        public string AdSoyad { get; set; }



        [DisplayName("PERSONEL GÖRSELİ")]
        public string PersonelGörseli { get; set; }



        [DisplayName("TC KİMLİK NO")]
        [StringLength(15, ErrorMessage = "Maximum uzunluk 11 karakterden fazla olamaz")]
        public string TCNO { get; set; }
        [DisplayName("DEPARTMANI")]
        public string Departman { get; set; }
        [StringLength(25, ErrorMessage = "Maximum uzunluk 25 karakterden fazla olamaz")]
        [DisplayName("GÖREVİ")]

        public string Gorev { get; set; }
        [DisplayName("AÇIKLAMA")]
        public string PozisyonAciklama { get; set; }
        [DisplayName("TELEFON NUMARASI")]
        [StringLength(15, ErrorMessage = "Maximum uzunluk 15 karakterden fazla olamaz")]
        public string TelNo { get; set; }
        [DisplayName("ADRES BİLGİLERİ")]
        public string Adres { get; set; }
        [DisplayName("MEDENİ HAL")]
        [StringLength(25, ErrorMessage = "Maximum uzunluk 10 karakterden fazla olamaz")]
        public string MedeniHal { get; set; }
        [DisplayName("YAKINLIK BİLGİSİ")]
        [StringLength(25, ErrorMessage = "Maximum uzunluk 25 karakterden fazla olamaz")]
        public string YakinBilgisi { get; set; }
        [DisplayName("YAKIN TC NO")]
        [StringLength(25, ErrorMessage = "Maximum uzunluk 11 karakterden fazla olamaz")]
        public string YakinTC { get; set; }
        [DisplayName("YAKIN AD SOYAD")]
        [StringLength(25, ErrorMessage = "Maximum uzunluk 50 karakterden fazla olamaz")]
        public string YakinAdSoyad { get; set; }
        [DisplayName("YAKIN TELEFONU")]
        [StringLength(25, ErrorMessage = "Maximum uzunluk 25 karakterden fazla olamaz")]
        public string YakinTel { get; set; }
        [DisplayName("DOĞUM TARİHİ")]
        public DateTime DogumTarihi { get; set; }
        [DisplayName("İŞE GİRİŞ TARİHİ")]
        public DateTime? IseGirisTarihi { get; set; }
        public virtual ICollection<PersonelProjeleri> PersonelProjeleris { get; set; }
    }
}