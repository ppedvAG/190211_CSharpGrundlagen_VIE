using System;

namespace Polymorphie
{
    // Klassen kann man ebenfalls mit "sealed" versiegeln, damit keiner mehr davon erben kann
    class Kreis : Grafik
    {
        public int Radius { get; set; }

        public override void Zeichnen() // override ist gleichzeitig auch überschreibbar, will man weiteres überscheiben verhindern: "sealed override"
        {
            // Ruft das originale Zeichnen aus der Basisklasse auf:
            // base.Zeichnen();
            // String.Format
            Console.WriteLine("Ein Kreis mit der Farbe {0} und dem Radius {1} wird gezeichnet",Farbe,Radius);
        }
    }



}
