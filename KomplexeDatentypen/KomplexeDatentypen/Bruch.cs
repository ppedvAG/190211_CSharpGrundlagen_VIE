using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomplexeDatentypen
{
    class Bruch
    {
        public Bruch(int zähler, int nenner)
        {
            Zähler = zähler;
            Nenner = nenner;
        }

        public int Zähler { get; set; }
        public int Nenner { get; set; }

        // Operatorüberladung:
        // Mögliche Überladungen:

        /* Arithmetische Operatoren:
         * +,-,*,/,%
         * Binär-Operatoren:
         * & (AND), | (OR), ~(Invert), <<, >> (SHIFT), ^ (XOR)
         * Vergleichsoperatoren:
         * <,<=,>,>=, ==, != 
         * => ACHTUNG: müssen paarweise überladen werden
         * 
         * Werden automatisch überladen:
         * +=, -= ....
         */

        public static Bruch operator *(Bruch links,Bruch rechts)
        {
            // Logik 
            return new Bruch(links.Zähler * rechts.Zähler, links.Nenner * rechts.Nenner);
        }
    }
}
