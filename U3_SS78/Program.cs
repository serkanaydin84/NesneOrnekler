using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U3_SS78
{
    class Program
    {
        static void Main(string[] args)
        {
            Daire daire = new Daire(15);

            Console.WriteLine("Dairenin Alanı: " + daire.AlanHesapla());
            Console.WriteLine("Dairenin Çevresi: " + daire.CevreHesapla());
            Console.ReadLine();
        }
    }


    class Daire
    {
        private int r;
        private double pi = 3.14;

        public Daire(int r)
        {
            this.r = r;
        }

        public double AlanHesapla()
        {
            return pi * r * r;
        }

        public double CevreHesapla()
        {
            return 2 * pi * r;
        }
    }

}
