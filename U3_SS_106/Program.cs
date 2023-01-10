using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U3_SS_106
{

    public abstract class Kutuphane
    {
        public string KitapAdi { get; set; }
        public string DergAdi { get; set; }
        public string AnsiklopediAdi { get; set; }
        public abstract void Oku();
    }

    public class Kitap : Kutuphane
    {
        public override void Oku()
        {
            Console.WriteLine("OVERRİDE METHODU İLE OKUNDU");
        }
    }

    public class Dergi : Kutuphane
    {
        public override void Oku()
        {
            Console.WriteLine("OVERRİDE METHODU İLE OKUNDU");
        }
    }

    public class Ansiklopedi : Kutuphane
    {
        public override void Oku()
        {
            Console.WriteLine("OVERRİDE METHODU İLE OKUNDU");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Kitap k = new Kitap();
            k.KitapAdi = "Huzur Sokağı";
            Console.Write("{0} adlı kitap ", k.KitapAdi);
            k.Oku();


            Dergi d = new Dergi();
            d.DergAdi = "Derin Tarih";
            Console.Write("{0} adlı dergi ", d.DergAdi);
            d.Oku();

            Ansiklopedi a = new Ansiklopedi();
            a.AnsiklopediAdi = "Meydan LAROUSSE";
            Console.Write("{0} adlı ansiklopedi ", a.AnsiklopediAdi);
            a.Oku();


            Console.ReadLine();
        }
    }
}
