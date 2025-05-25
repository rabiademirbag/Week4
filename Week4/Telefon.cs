using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4
{
    public class Telefon : BaseMakine
    {
        public bool LisansVarMi;

        public Telefon(string seriNo, string ad, string aciklama, string isletimSistemi,bool lisansVarMi) : base(seriNo, ad, aciklama, isletimSistemi)
        {
            LisansVarMi = lisansVarMi;
        }

        public override void UrunAdiGetir()
        {
            Console.WriteLine($"Telefonunuzun adı ---> {this.Ad}");
        }
        public override void BilgileriYazdir()
        {
            base.BilgileriYazdir();
            Console.WriteLine($"TR Lisansı {(LisansVarMi? "var":"yok")}");
        }
    }
}
