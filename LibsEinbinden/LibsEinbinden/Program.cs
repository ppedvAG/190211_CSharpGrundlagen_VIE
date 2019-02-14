using MeineLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibsEinbinden
{
    class Program
    {
        static void Main(string[] args)
        {
            Taschenrechner t = new Taschenrechner();
            int erg = t.Add(12, 5);

            Console.WriteLine(erg);

            unsafe
            {
                int zahl = 32;
                int* p = &zahl;
                Console.WriteLine("Der Wert ist:" + *p);
            }


            Console.WriteLine("---ENDE---");
            Console.ReadKey();
        }
    }
}
