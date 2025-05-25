using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4
{
    public abstract class BaseMakine
    {
        public DateTime UretimTarihi { get; set; }
        public string SeriNo { get; set; }
        public string Ad {  get; set; } 
        public string Aciklama {  get; set; }   
        public string IsletimSistemi { get; set; }

        public BaseMakine(string seriNo, string ad, string aciklama, string isletimSistemi)
        {
            UretimTarihi= DateTime.Now.Date;
            SeriNo= seriNo;
            Ad= ad;
            Aciklama= aciklama;
            IsletimSistemi= isletimSistemi;
        }
        public virtual void BilgileriYazdir()
        {
            Console.WriteLine($"Üretim Tarihi: {UretimTarihi}\nSeri Numarası: {SeriNo}\nAd: {Ad}\nAçıklama: {Aciklama}\nİşletim Sistemi: {IsletimSistemi}");
        }
        public abstract void UrunAdiGetir();
    }
}
