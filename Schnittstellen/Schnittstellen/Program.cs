using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schnittstellen
{
    class Program
    {
        static void Main(string[] args)
        {
            Obst o1 = new Obst();
            o1.Name = "Apfel";
            o1.Preis = 1;
            o1.Herkunft = "Steiermark";
            o1.Kcal = 80;

            Händler max = new Händler();
            max.Anzahl = 10000;
            max.Produkt = o1;

            // Objektinitialisierer
            Obst o2 = new Obst() { Name = "Banane", Herkunft = "Brasilien", Preis = 1.20m, Kcal = 120 };
            // Bei einem parameterlosen Konstruktor kann man optional die runden Klammern weglassen
            Händler moritz = new Händler { Anzahl = 500, Produkt = o2 };

            // Finale Variante

            Händler lisa = new Händler
            {
                Anzahl = 100,
                Produkt = new Gemüse { Name = "Tomaten", Preis = 0.60m }
            };

            Console.WriteLine("---ENDE---");
            Console.ReadKey();
        }
    }
}
