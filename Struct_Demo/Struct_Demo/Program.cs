using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Rechteck r1 = new Rechteck(99, 88);

            r1.Höhe = 100;
            r1.Breite = 100;

            // Console.WriteLine(r1.Höhe);
           
            Console.WriteLine("---ENDE---");
            Console.ReadKey();
        }
    }
}
