using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4
{
    public class Bilgisayar : BaseMakine
    {

        public int UsbGiris { get; }
        public bool BluethootVarMi { get; }

        public Bilgisayar(string seriNo, string ad, string aciklama, string isletimSistemi,int usbGiris, bool bluethootVarMi) : base(seriNo, ad, aciklama, isletimSistemi)
        {
           
            BluethootVarMi = BluethootVarMi;
            if(usbGiris==2 || usbGiris == 4)
            {
                UsbGiris = usbGiris;
            }
            else
            {
                Console.WriteLine("USB Girişi 2 veya 4 olabilir.");
                UsbGiris = -1;
            }

        }

        public override void UrunAdiGetir()
        {
            Console.WriteLine($"Bilgisayarınızın adı ---> {this.Ad}");
        }
        public override void BilgileriYazdir()
        {
            base.BilgileriYazdir();
            Console.WriteLine($"USB Giriş Sayısı: {UsbGiris}\nBluetooth {(BluethootVarMi ?"Var":"Yok")}");
        }
    }
}
