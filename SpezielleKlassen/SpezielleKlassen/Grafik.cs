using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpezielleKlassen
{
    // Vorlagenklasse -> z.B. fürs Vererben (kleinster gemeinsamer Nenner)
    abstract class Grafik
    {
        public string Farbe { get; set; }
        //public void Zeichnen()
        //{
        //    Console.WriteLine($"Eine Grafik mit der Farbe {Farbe} wird gezeichnet");
        //}

        // Jeder, der davon erbt MUSS eine eigene Version von Zeichnen() einbauen
        public abstract void Zeichnen();
    }

    class Kreis : Grafik
    {
        public int Radius { get; set; }

        public override void Zeichnen()
        {
            Console.WriteLine($"Ein Kreis mit der Farbe {Farbe} und dem Radius {Radius} wird gezeichnet");
        }
    }

    partial class Rechteck
    {
        public int Höhe { get; set; }
        public int Breite { get; set; }
    }

}
