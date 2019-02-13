using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct_Demo
{
    struct Rechteck // <= Wertetyp
    {
        // Aufpassen bei Konstruktoren
        public Rechteck(int Höhe, int Breite)
        {
            this.Höhe = Höhe;
            this.Breite = Breite;
        }

        public int Höhe;
        public int Breite;
    }

    // Structs dürfen:
    /*
     * Konstruktor (parameterlos existiert IMMER)
     * Konstanten (const)
     * Felder
     * Methoden (empfohlen sind: wenige bis keine)
     * Properties
     * Indexer ( z.B. zahlen[0])
     * Operatoren ( "+" "-")
     * Delegaten und Ereignisse
     * ... Von einem Interface erben
     * ... keine "verzögerung mit GC"
     */

    // Was nicht geht:
    // Vererbung, Abstract, parameterloser Konstruktor
    // Feldinitialisierer, Propertyinitialisierer
    //  -> Konstruktor MUSS alles setzen
    //  -> protected geht dementsprechend nicht

}
