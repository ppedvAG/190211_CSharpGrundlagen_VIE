using System;

namespace Polymorphie
{
    class Rechteck : Grafik
    {
        public int Höhe { get; set; }
        public int Breite { get; set; }

        public void Zeichnen() // Warnung fürs Verstecken kann mit dem "new"-Schlüsselwort unterdrückt werden: "public new void Zeichnen()"
        {
            // String Interpolation
            Console.WriteLine($"Ein Rechteck mit der Farbe {Farbe}, der Höhe {Höhe} und der Breite {Breite} wird gezeichnet");
        }

        // Verstecken im Vergleich zum Überschreiben:
        // Überschreiben geht nur bei Methoden, die als "virtual" oder "override" gekennzeichnet sind
        // -> Verstecken geht IMMER
    }

}
