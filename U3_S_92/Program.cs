using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U3_S_92
{
    class Kisi
    {
        int yas;
        string ad;
        public Kisi()
        {
            yas = 40;
            ad = "Serkan";
            Console.WriteLine("Yapıcı metod ÇALIŞTI");
        }

        public int Yas
        {
            get
            { return yas; }
        }

        public string Ad
        {
            get { return ad; }
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program çalıştı");
            Kisi k = new Kisi();
            Console.WriteLine("Yaşınız: {0} ve İsminiz: {1}", k.Yas, k.Ad);
            Console.WriteLine("Program BİTTİ");


            Console.ReadLine();
        }
    }
}
