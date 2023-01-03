using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U3_S_86
{
    class SayiBulucu
    {
        public int BuyukOlaniBul(int a, int b)
        {
            int sonuc;

            if (a < b)
            {
                sonuc = b;
            }
            else
            {
                sonuc = a;
            }
            return sonuc;
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            SayiBulucu sb = new SayiBulucu();
            Console.WriteLine("Büyük olan sayı: " + sb.BuyukOlaniBul(10, 25));

            Console.WriteLine("Büyük olan sayı: " + sb.BuyukOlaniBul(50, 25));

            Console.WriteLine("Büyük olan sayı: " + sb.BuyukOlaniBul(50, 250));


            Console.ReadLine();
        }
    }
}
