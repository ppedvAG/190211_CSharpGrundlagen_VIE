using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Taschenrechner
    {   
        // Methoden -> Logik in einer Klasse
        // void => Keine Rückgabe
        // Gültigkeitsmodifizierer Rückgabetypen Name(parameter)
        // { ...... }
        public void Machetwas()
        {
            Console.WriteLine("irgendwas");
        }

        public void Verdoppeln(int zahl)
        {
            Console.WriteLine(zahl * 2);
        }

        public int Addieren(int zahl1, int zahl2)
        {
            // Wert zurückgeben
            return zahl1 + zahl2;
        }
        // Überladen von Methoden
        // Methoden müssen sich von der Anzahl und/oder Datentypen unterscheiden
        public int Addieren(int zahl1, int zahl2, int zahl3)
        {
            // Wert zurückgeben
            return zahl1 + zahl2 + zahl3;
        }

        public void MachEtwasOptional(int zahl = -1) // = bedeutet Optional
        {
            Console.WriteLine("Deine Eingabe war:" + zahl);
        }

    }
}
