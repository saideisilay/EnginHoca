using System;

namespace Ocak20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------SÖZLÜK KAVRAMI---------\n");
            MyDictionary<string, string> sozlükTDK = new MyDictionary<string, string>();
            sozlükTDK.Add("sevmek", "Sevgi ve bağlılık duymak");
            sozlükTDK.Add("hissetmek", "Fiziksel bir uyarıyı duymak");
            sozlükTDK.Add("söz etmek", "bir şey üzerine konuşmak");
            Console.WriteLine("-------{0} fiil LİSTESİ----------",sozlükTDK.Count);
            sozlükTDK.List();

            
            sozlükTDK.Add("ilgi", "İki şey arasında bulunan herhangi bir bağlılık, ilişki, alaka, taalluk, aidiyet");
            sozlükTDK.Add("yergi", "Bir kimseyi, bir toplumu, bir düşünceyi, bir nesneyi, bir göreneği yermek için yazılmış yazı veya söylenmiş söz, hicviye, hiciv, satir");
            sozlükTDK.Add("sevgi", "İnsanı bir şeye veya bir kimseye karşı yakın ilgi ve bağlılık göstermeye yönelten duygu");
            Console.WriteLine("--------{0} SON LİSTE---------", sozlükTDK.Count);
            sozlükTDK.List();
        }
    }
}
