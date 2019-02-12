using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphie
{
    class Program
    {
        static void Main(string[] args)
        {
            Lottozahlengenerator lg = new Lottozahlengenerator();
            lg.Generate(6,1,45); // Österreich
            lg.Generate(6,1,49); // Deutschland

            Grafik g1 = new Grafik();
            g1.Farbe = "Rot";

            Kreis k1 = new Kreis();
            k1.Farbe = "Gelb";
            k1.Radius = 10;

            Rechteck r1 = new Rechteck();
            r1.Farbe = "Grün";
            r1.Höhe = 12;
            r1.Breite = 30;

            g1.Zeichnen();
            k1.Zeichnen();
            r1.Zeichnen();

            // Polymorphie -> Vielgestaltigkeit von Objekten
            // Polymorphie bedeutet, dass Objekte der Subklasse wie Objekte der Basisklasse verwendet werden können
            Console.WriteLine("---------------------- Überschreiben --------------------");

            Grafik g2 = new Kreis();
            g2.Farbe = "Violett";
            g2.Zeichnen();

            // Casten
            Kreis k2 = (Kreis)g2;
            k2.Radius = 50;
            g2.Zeichnen();

            Console.WriteLine("---------------------- Verstecken --------------------");

            Grafik g3 = new Rechteck();
            g3.Farbe = "Orange";
            g3.Zeichnen();

            Console.WriteLine("---------------------- Anwendungsfall --------------------");

            #region Arrays

            //int zahl1 = 42;
            //int[] eindimensionalesArray = new int[10]; // 0,1,2,3...9
            //eindimensionalesArray[0] = 21;
            //eindimensionalesArray[1] = 3;
            //eindimensionalesArray[2] = 99;

            //// Alternative Schreibweisen:
            //string[,] mehrdimensional = new string[10, 5];
            //mehrdimensional[0, 0] = "Hallo";
            //mehrdimensional[0, 1] = "Welt";

            //int[] zahlen = new int[] { 12, 5, 8, 4, 2, 54, 7, 9 };
            //int[] zahlen2 = { 12, 5, 8, 4, 2, 54, 7, 9 };

            //Console.WriteLine(eindimensionalesArray[1]); 
            #endregion

            Grafik[] alleGrafiken = new Grafik[5]; // Liste/Array der Basisklasse kann auch elemente der Subklasse beinhalten
            alleGrafiken[0] = k1;
            alleGrafiken[1] = r1;
            alleGrafiken[2] = g1;
            alleGrafiken[3] = k2;
            alleGrafiken[4] = g2;
            //for (int i = 0; i < alleGrafiken.Length; i++)
            //{
            //    alleGrafiken[i].Zeichnen();
            //}
            foreach(Grafik item in alleGrafiken)
            {
                item.Zeichnen();
            }

            Console.WriteLine("---ENDE---");
            Console.ReadKey();
        }
    }

}
