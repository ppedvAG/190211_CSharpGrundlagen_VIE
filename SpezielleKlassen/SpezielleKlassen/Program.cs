using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpezielleKlassen
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Statische Klassen
            //Taschenrechner t = new Taschenrechner();
            //int erg = t.Addieren(15, 3);

            //int erg2 = Taschenrechner.Subtrahieren(12, 4);
            //Console.WriteLine(erg); 
            #endregion

            Grafik g1 = new Kreis();

            g1.Zeichnen();

            Rechteck r = new Rechteck();

            Console.WriteLine("---ENDE---");
            Console.ReadKey();
        }
    }

    partial class Rechteck
    {
        public void Demo()
        {

        }
    }
}
