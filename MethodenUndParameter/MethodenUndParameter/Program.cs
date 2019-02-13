using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodenUndParameter
{
    [Flags]
    public enum Wochentage
    {
        Montag = 1,
        Dienstag = 2,
        Mittwoch = 4,
        Donnerstag = 8,
        Freitag = 16,
        Samstag = 32,
        Sonntag = 64
    }

    class Program
    {
        static void Main(string[] args)
        {
            #region params
            //int[] meineZahlen = { 3, 7, 5 };
            //int erg = Addieren(meineZahlen);
            //Console.WriteLine(erg);

            //int erg2 = Addieren(12, 5, 7, 9);
            //int erg3 = Addieren(1,2); 
            #endregion

            #region Arbeiten mit Enum:

            //Wochentage heute = Wochentage.Mittwoch;
            //// switch + TAB + TAB, "heute" eingeben + ENTER
            //Console.WriteLine(heute);

            //heute = (Wochentage)86;
            //Console.WriteLine(heute);
            //if (heute.HasFlag(Wochentage.Dienstag))
            //{
            //    Console.WriteLine("Dienstag ist dabei");
            //} 
            #endregion

            // Übergabe per Wert und per Referenz
            int i = 42;                 // Wertetyp
            Person p = new Person();    // Referenztyp
            p.Vorname = "Tom";
            p.Nachname = "Ate";
            p.Alter = 50;
            p.Kontostand = 5000;
            p.Geschlecht = Geschlecht.Kampfhubschrauber;

            ÜbergabePerReferenz(ref i);

            // Trick um mehrere Ergebnisse zu bekommen
            string ergebnis = "";
            int ergebnisZahl = GibZweiSachenZurück(out ergebnis);

            // Tupel ( .NET Framework 4.7 und C# 7.0)
            var meinTupel = GibZweiWerteZurück();
            Console.WriteLine(meinTupel.zahl);
            Console.WriteLine(meinTupel.text);

            Console.WriteLine("---ENDE---");
            Console.ReadKey();
        }

        public static (int zahl, string text) GibZweiWerteZurück()
        {
            return (99, "Hallo Welt");
        }

        // out -> ist wie übergabe per Referenz, aber man MUSS dem out-Parameter einen neuen Wert zuweisen
        public static int GibZweiSachenZurück(out string ergebnis)
        {
            // ergebnis = "meine erste Rückgabe";
            return 99;
        }
        public static int GibZweiSachenZurück2(ref string ergebnis)
        {
            //ergebnis = "meine erste Rückgabe";
            return 99;
        }

        // readonly-ref
        public static void ReadonlyReference(in int zahl)
        {
            //zahl = 99;
        }

        public static void ÜbergabePerReferenz(ref int zahl)
        {
            zahl = 99;
        }

        public static void ÜbergabePerWert(int zahl)
        {
            zahl = 99;
        }
        public static void ÜbergabePerWert(Person max)
        {
            max.Vorname = "Max";
        }



        // params => eingabeparameter in einem Array zusammenfassen
        public static int Addieren(params int[] alleZahlen)
        {
            return alleZahlen.Sum();
        }
        public static int Addieren(int z1, int z2)
        {
            return z1 + z2;
        }
        public static int Addieren(int z1, int z2, int z3)
        {
            return z1 + z2 + z3;
        }
        //public static int Addieren(int z1, int z2, int z3, int z4)
        //{
        //    return z1 + z2 + z3 + z4;
        //}


        public static void MethodeOhneRückgabe()
        {

        }
        public static int MethodeMitRückgabe()
        {
            return 12345;
        }
        public static int MethodeMitRückgabe(int zahl1)
        {
            return 12345;
        }
        public static int MethodeMitRückgabe(int zahl1, int zahl2)
        {
            return 12345;
        }
    }
}
