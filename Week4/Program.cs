using Week4;

public class Program
{
    public static void Main(string[] args)
    {
        string choice;

        while (true)
        {
            Console.WriteLine("Telefon üretmek için 1, Bilgisayar üretmek için 2'ye basınız.");
            choice = Console.ReadLine();

            while (choice != "1" && choice != "2")
            {
                Console.WriteLine("Hatalı giriş! Lütfen 1 (Telefon) veya 2 (Bilgisayar) giriniz.");
                choice = Console.ReadLine();
            }

            if (choice == "1")
            {
                // Telefon üretimi
                Console.Write("Seri No Giriniz: ");
                string seriNo = Console.ReadLine();

                Console.Write("Ad Giriniz: ");
                string ad = Console.ReadLine();

                Console.Write("Açıklama Giriniz: ");
                string aciklama = Console.ReadLine();

                Console.Write("İşletim Sistemi Giriniz: ");
                string isletimSistemi = Console.ReadLine();

                Console.Write("TR Lisansı varsa 'var', yoksa 'yok' yazınız: ");
                string lisansVarMi = Console.ReadLine().ToLower();
                bool lisans = lisansVarMi == "var";

                BaseMakine telefon = new Telefon(seriNo, ad, aciklama, isletimSistemi, lisans);
                telefon.UrunAdiGetir();
                telefon.BilgileriYazdir();
            }
            else if (choice == "2")
            {
                // Bilgisayar üretimi
                Console.Write("Seri No Giriniz: ");
                string seriNo = Console.ReadLine();

                Console.Write("Ad Giriniz: ");
                string ad = Console.ReadLine();

                Console.Write("Açıklama Giriniz: ");
                string aciklama = Console.ReadLine();

                Console.Write("İşletim Sistemi Giriniz: ");
                string isletimSistemi = Console.ReadLine();

                Console.Write("USB Giriş Sayısını Giriniz (2 veya 4): ");
                int usbGiris;
                while (!int.TryParse(Console.ReadLine(), out usbGiris))
                {
                    Console.Write("Geçerli bir sayı giriniz: ");
                }

                Console.Write("Bluetooth varsa 'var', yoksa 'yok' yazınız: ");
                string bluetoothVarMi = Console.ReadLine().ToLower();
                bool bluetooth = bluetoothVarMi == "var";

                BaseMakine bilgisayar = new Bilgisayar(seriNo, ad, aciklama, isletimSistemi, usbGiris, bluetooth);
                bilgisayar.UrunAdiGetir();
                bilgisayar.BilgileriYazdir();
            }

            Console.WriteLine("Ürün başarıyla oluşturuldu. Başka bir ürün üretmek istiyor musunuz? (evet / hayır)");
            string devamMi = Console.ReadLine().ToLower();

            if (devamMi != "evet")
            {
                Console.WriteLine("İyi Günler...");
                break;
            }
        }
    }
}
