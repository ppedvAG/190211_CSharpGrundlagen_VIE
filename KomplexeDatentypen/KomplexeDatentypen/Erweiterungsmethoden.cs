using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomplexeDatentypen
{
    // Einzige Vorraussetzung: statische Klasse
    static class Erweiterungsmethoden
    {
        // this string -> Methode "Umdrehen" nun über die Klasse string aufrufbar wird
        public static string Umdrehen(this string eingabe)
        {
            StringBuilder sb = new StringBuilder(); // Klasse, mit der wir Zeichenketten zusammensetzen können

            // forr + TAB + TAB
            for (int i = eingabe.Length- 1; i >= 0; i--)
            {
                sb.Append(eingabe[i]);
            }

            return sb.ToString(); // Umgedrehter string
        }

        public static int Verdoppeln(this int eingabe)
        {
            return eingabe * 2;
        }

    }
}
