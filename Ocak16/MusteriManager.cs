using System;
using System.Collections.Generic;
using System.Text;

namespace Ocak16
{
    public class MusteriManager
    {
        public void Ekle(List<Musteri> liste,Musteri musteri)
        {
            Console.WriteLine("{0}. nolu {1} {2} isimli müşteri {3} şubeye eklenmiştir.",musteri.MusteriId,musteri.Ad,musteri.Soyad,musteri.SubeAdi);
            liste.Add(musteri);

        }

        public void Listeleme(List<Musteri> musteriListe )
        {
            //= new List<Musteri>();
            foreach (var item in musteriListe)
            {
                Console.WriteLine("{0}. nolu {1} {2} isimli müşteri {3} şubeye aittir.", item.MusteriId, item.Ad, item.Soyad, item.SubeAdi);
            }
        }
        public void Silme(List<Musteri> liste, Musteri musteri)
        {
            Console.WriteLine("{0}. nolu {1} {2} isimli müşteri {3} şubeden silinmiştir.", musteri.MusteriId, musteri.Ad, musteri.Soyad, musteri.SubeAdi);
            liste.Remove(musteri);
        }
    }
}
