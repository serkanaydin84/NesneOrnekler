using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U3_S_81
{
    class Program
    {
        static void Main(string[] args)
        {
            Ucgen ucgen = new Ucgen();
            ucgen.A = 3;
            ucgen.B = 4;
            ucgen.C = 5;
            
            Console.WriteLine(ucgen.A);
            Console.WriteLine(ucgen.B);
            Console.WriteLine(ucgen.C);
            
            Console.WriteLine("Üçgenin çevresi: " + ucgen.Cevre);


            Console.ReadLine();
        }
    }


    class Ucgen
    {
        int a;
        int b;
        int c;

        public int A
        {
            get { return a; }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Hatalı Bilgi");
                }
                else
                {
                    a = value;
                }
            }
        }

        public int B
        {
            get { return b; }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Hatalı Bilgi");
                }
                else
                {
                    b = value;
                }
            }
        }

        public int C
        {
            get { return c; }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Hatalı Bilgi");
                }
                else
                {
                    c = value;
                }
            }
        }

        public int Cevre
        {
            get { return a + b + c; }
        }
    }
}
