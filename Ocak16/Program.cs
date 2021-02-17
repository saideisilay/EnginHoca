using System;
using System.Collections.Generic;

namespace Ocak16
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.MusteriId = 1;
            musteri1.Ad = "Saide Işılay";
            musteri1.Soyad = "Baykal";
            musteri1.SubeAdi = "Beyazıt";
            musteri1.TcKimlik = 21345679596;

            Musteri musteri2 = new Musteri();
            musteri2.MusteriId = 2;
            musteri2.Ad = "Fahri Emre";
            musteri2.Soyad = "Özdemir";
            musteri2.SubeAdi = "Bakırköy";
            musteri2.TcKimlik = 54698754952;

            List<Musteri> musteriListesi = new List<Musteri>();
            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteriListesi,musteri1);
            musteriManager.Ekle(musteriListesi,musteri2);
            Console.WriteLine("----------");
            Console.WriteLine("----------MÜSTERİ LİSTELEME-------------");
            musteriManager.Listeleme(musteriListesi);
            Console.WriteLine("----------");
            Console.WriteLine("----------MÜSTERİ Silme-------------");
            musteriManager.Silme(musteriListesi, musteri1);
            Console.WriteLine("----------");
            Console.WriteLine("----------MÜSTERİ silindikten sonra LİSTELEME-------------");
            musteriManager.Listeleme(musteriListesi);
        }
    }
}
