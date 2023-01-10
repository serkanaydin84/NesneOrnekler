using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U3_S_100
{
    class OkulPersoneli
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
    }

    class Ogretmen : OkulPersoneli
    {
        public string Brans { get; set; }
    }


    class Program
    {
        static void Main(string[] args)
        {
            OkulPersoneli per = new OkulPersoneli();
            Ogretmen ogrt = new Ogretmen();

            ogrt.Ad = "Serkan";
            ogrt.Soyad = "Aydın";
            ogrt.Brans = "Bilişim";
            Console.WriteLine("Öğretmen Sınıfından Türetilen {0} {1} {2}", ogrt.Ad, ogrt.Soyad, ogrt.Brans);
            // Brans metoduna Ogretmen sınıfndan ulaşabiliriz.
            // Çünkü Ogretmen sınıfı, OkulPersoneli sınıfında türetilmiştir. Yani KALITIM kullanılmıştır

            per.Ad = "Ramazan";
            per.Soyad = "Güneş";
            Console.WriteLine("OkulPersoneli Sınıfından Türetilen {0} {1}", per.Ad, per.Soyad);
            // Brans metoduna OkulPersoneli sınıfından ulaşamayız.

            Console.ReadLine();
        }
    }
}
