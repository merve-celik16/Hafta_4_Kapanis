using System;

namespace TeknolojiMagazasi
{
    abstract class BaseMakine
    {
        public DateTime UretimTarihi { get; set; } = DateTime.Now;
        public int SeriNumarasi { get; set; }
        public string Ad { get; set; }
        public string Aciklama { get; set; }
        public string IsletimSistemi { get; set; }

        public BaseMakine()
        {
            SeriNumarasi = new Random().Next(1000, 10000); // Rastgele seri numarası ataması
        }

        public virtual void BilgileriYazdir()
        {
            Console.WriteLine($"Üretim Tarihi: {UretimTarihi}");
            Console.WriteLine($"Seri Numarası: {SeriNumarasi}");
            Console.WriteLine($"Ad: {Ad}");
            Console.WriteLine($"Açıklama: {Aciklama}");
            Console.WriteLine($"İşletim Sistemi: {IsletimSistemi}");
        }

        public abstract void UrunAdiGetir();
    }

    class Telefon : BaseMakine
    {
        public bool TrLisansli { get; set; }

        public override void BilgileriYazdir()
        {
            base.BilgileriYazdir();
            Console.WriteLine($"Türkçe Lisanslı: {TrLisansli}");
        }

        public override void UrunAdiGetir()
        {
            Console.WriteLine($"Telefonunuzun adı: {Ad}");
        }
    }

    class Bilgisayar : BaseMakine
    {
        public int UsbGirisSayisi { get; set; }
        public bool Bluetooth { get; set; }

        public Bilgisayar()
        {
            while (true)
            {
                Console.Write("USB Giriş Sayısı (2 veya 4): ");
                if (int.TryParse(Console.ReadLine(), out int sayi) && (sayi == 2 || sayi == 4))
                {
                    UsbGirisSayisi = sayi;
                    break;
                }
                else
                {
                    Console.WriteLine("Geçersiz giriş. Lütfen 2 veya 4 giriniz.");
                }
            }
        }

        public override void BilgileriYazdir()
        {
            base.BilgileriYazdir();
            Console.WriteLine($"USB Giriş Sayısı: {UsbGirisSayisi}");
            Console.WriteLine($"Bluetooth: {Bluetooth}");
        }

        public override void UrunAdiGetir()
        {
            Console.WriteLine($"Bilgisayarınızın adı: {Ad}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Ürün seçimi: (1) Telefon, (2) Bilgisayar");
                int secim = Convert.ToInt32(Console.ReadLine());

                switch (secim)
                {
                    case 1:
                        Telefon telefon = new Telefon();
                        // Telefon özelliklerini al
                        telefon.BilgileriYazdir();
                        break;
                    case 2:
                        Bilgisayar bilgisayar = new Bilgisayar();
                        // Bilgisayar özelliklerini al
                        bilgisayar.BilgileriYazdir();
                        break;
                    default:
                        Console.WriteLine("Geçersiz seçim.");
                        break;
                }

                Console.Write("Başka ürün eklemek ister misiniz? (e/h): ");
                if (Console.ReadLine().ToLower() != "e")
                {
                    break;
                }
            }
        }
    }
}