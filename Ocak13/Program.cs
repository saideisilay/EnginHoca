using System;
using System.Collections.Generic;

namespace Ocak13
{
    class Product
    {
        public int Id { set; get; }
        public string Name { set; get; }
        public decimal Price { set; get; }
        public bool IsInStock { set; get; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Product urun1 = new Product
            {
                Id = 1,
                Name = "Bilgisayar",
                Price = 3550,
                IsInStock = true
            };
            Product urun2 = new Product
            {
                Id = 2,
                Name = "Cep Telefonu",
                Price = 2500,
                IsInStock = false
            };
            Product urun3 = new Product
            {
                Id = 3,
                Name="Robot Süpürge",
                Price=3500,
                IsInStock=true
            };
            Product urun4 = new Product
            {
                Id = 4,
                Name = "Firewire PCI Kart",
                Price = 350,
                IsInStock = false
            };
            Product urun5 = new Product
            {
                Id = 5,
                Name = "Focusrite Bundle Ses Kartı",
                Price = 2700,
                IsInStock = true
            };
            Product urun6 = new Product
            {
                Id = 6,
                Name = "YAMAHA Genos Workstation Klavye",
                Price = 42000,
                IsInStock = false
            };

            Product[] urunler = new Product[] {urun1,urun2,urun3,urun4,urun5,urun6 };
            Console.WriteLine("**************WHILE ILE DONGU:********************");

            int i = 0;
            while(i<urunler.Length)
            {
                Console.WriteLine("{0}.Ürünün Adı: {1}",urunler[i].Id,urunler[i].Name);
                i++;
                
                
            }
            Console.WriteLine("**************FOR ILE DONGU:********************");

            for (int j  = 0; j < urunler.Length; j++)
            {

                Console.WriteLine(" {0} adlı ürünün Fiyatı:{1} ", urunler[j].Name, urunler[j].Price.ToString());
            }
            Console.WriteLine("*****************FOREACH DÖNGÜSÜ*****************");
            Console.WriteLine("Burda Stokta olanları Listeliyor");

            foreach (var urun in urunler)
            {
                if (urun.IsInStock != false)
                {
                    Console.WriteLine("Ürün Id: " + urun.Id + "\nÜrünün Adı: " + urun.Name + "\nÜrünün Fiyatı: " + urun.Price + "\n++++++++++++++++");

                }
                else
                    continue;
            }
            Console.WriteLine("Kapatmak için bir tuşa basın.");
            Console.ReadKey();
        }
    }
}
