using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Erstellen eines Objektes
            //// Wertetyp
            //int zahl;
            //zahl = 42;

            //// Referenztyp
            //Person p = new Person();
            //p.Vorname = "Tom";
            //p.Nachname = "Ate";
            //p.Alter = 20;
            //p.Kontostand = 500;
            //p.Geschlecht = true; // Männlich
            //Console.WriteLine(p.Nachname);

            #endregion

            #region Unterschiede zwischen Wertetypen und Referenztypen
            //// Wertetypen
            //int zahl1 = 5;
            //int zahl2 = 5;

            //if(zahl1 == zahl2)  // Wertevergleich
            //    Console.WriteLine("Zahl1 und Zahl2 sind gleich");
            //else
            //    Console.WriteLine("Zahl1 und Zahl2 sind ungleich");

            //int zahl3 = zahl1; // Wertekopie

            //if (zahl1 == zahl3)  // Wertevergleich
            //    Console.WriteLine("Zahl1 und Zahl3 sind gleich");
            //else
            //    Console.WriteLine("Zahl1 und Zahl3 sind ungleich");

            //zahl3 = 99;
            //Console.WriteLine(zahl1);

            //Person p1 = new Person();
            //p1.Vorname = "Max Mustermann";
            //Person p2 = new Person();
            //p2.Vorname = "Max Mustermann";

            //if(p1 == p2) // Referenzvergleich
            //{
            //    Console.WriteLine("Person1 und Person2 sind gleich");
            //}
            //else
            //{
            //    Console.WriteLine("Person1 und Person2 sind ungleich");
            //}

            //Person p3 = p2; // Referenzkopie

            //if (p3 == p2) // Referenzvergleich
            //{
            //    Console.WriteLine("Person2 und Person3 sind gleich");
            //}
            //else
            //{
            //    Console.WriteLine("Person2 und Person3 sind ungleich");
            //}

            //// Wertevergleich bei Referenztypen:
            //object o1 = 42;
            //object o2 = 42;

            //if(o1 == o2)
            //    Console.WriteLine("gleich");
            //else
            //    Console.WriteLine("ungleich");

            //if(o1.Equals(o2))
            //    Console.WriteLine("werte gleich");
            //else
            //    Console.WriteLine("werte ungleich");

            //// Für die Person: Eigene Version von Equals() machen (siehe Kapitel "Überschreiben von Methoden")

            ////Console.WriteLine(p3.Nachname);
            ////p2.Nachname = "Demo";
            ////Console.WriteLine(p3.Nachname); 
            #endregion

            #region Methoden

            //Taschenrechner t = new Taschenrechner();

            //t.Machetwas();
            //t.Machetwas();
            //t.Machetwas();
            //t.Machetwas();

            //t.Verdoppeln(12);
            //t.Verdoppeln(7);
            //t.Verdoppeln(3);

            //int erg = t.Addieren(12, 5);
            //Console.WriteLine(erg);
            //int erg2 = t.Addieren(12, 5, 9);

            //t.MachEtwasOptional(5);
            //t.MachEtwasOptional();
            //t.MachEtwasOptional(); 
            #endregion

            #region Properties

            //Person p = new Person();
            //p.Vorname = "Tom";


            //Console.WriteLine(p.Alter);
            //Console.WriteLine(p.Vorname);
            //p.Gebutstag();
            //p.Gebutstag();
            //p.Gebutstag();
            //Console.WriteLine(p.Alter);

            //p = null;
            //// GarbageCollector manuell anstoßen:
            //GC.Collect(); 
            #endregion


            //Mitarbeiter m = new Mitarbeiter();
            //m.Kontostand = -200000;

            Console.WriteLine("---ENDE---");
            Console.ReadKey();
        }
    }
}
