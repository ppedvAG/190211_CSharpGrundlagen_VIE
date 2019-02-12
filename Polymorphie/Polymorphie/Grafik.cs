using System;

namespace Polymorphie
{
    class Grafik
    {
        public string Farbe { get; set; }
        // virtual bedeutet, dass wir diese Methode in Subklassen überschreiben können
        public virtual void Zeichnen()
        {
            Console.WriteLine("Eine Grafik mit der Farbe " + Farbe + " wird gezeichnet");
        }

        public void Demo()
        {

        }
    }

}
