using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomplexeDatentypen
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Array
            //int[] zahlen = new int[5];
            //int[] zahlen2 = new int[] { 12, 4, 7, 9, 4 };
            //int[] zahlen3 = { 1, 2, 3, 4, 5, 6, 7 }; 
            #endregion

            #region List<T>
            //List<int> zahlen = new List<int>();
            //List<int> zweiteListe = new List<int>() { 99, 88, 77 };

            //zahlen.Add(12);
            //zahlen.Add(3);
            //zahlen.Add(7);

            //zahlen.AddRange(zweiteListe); // Fügt alle Zahlen von zweiteListe in zahlen ein

            //Console.WriteLine($"Das erste Element ist: {zahlen[0]}");
            //zahlen.Sort();
            //foreach (var item in zahlen)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #region Stack<T>:  LIFO
            //Stack<string> meineWörter = new Stack<string>();

            //meineWörter.Push("Hallo");
            //meineWörter.Push("Welt");
            //meineWörter.Push("!");

            //Console.WriteLine(meineWörter.Pop());
            //Console.WriteLine(meineWörter.Pop());
            //Console.WriteLine(meineWörter.Pop()); 
            #endregion

            #region Queue<T>: FIFO
            //Queue<double> meineZahlen = new Queue<double>();

            //meineZahlen.Enqueue(3.14);
            //meineZahlen.Enqueue(0.12345);
            //meineZahlen.Enqueue(9999);

            //Console.WriteLine(meineZahlen.Dequeue());
            //Console.WriteLine(meineZahlen.Dequeue());
            //Console.WriteLine(meineZahlen.Dequeue()); 
            #endregion

            #region Dictionary<TKey,TValue>
            //Dictionary<string, string> Länder = new Dictionary<string, string>();
            //// Key darf nur 1 mal vorkommen
            //Länder.Add("Österreich", "Wien");
            //Länder.Add("Ungarn", "Budapest");
            //Länder.Add("Tschechei", "Prag");
            //Länder.Add("Slowakei", "Pressburg");
            //Länder.Add("Slowenien", "Laibach");
            //Länder.Add("Rumänien", "Bukarest");

            //if(Länder.ContainsKey("Deutschland"))
            //    Console.WriteLine(Länder["Deutschland"]);
            //else
            //    Console.WriteLine("Gibts nicht..."); 
            #endregion

            #region Hashset<T>: Liste, die nichts doppelt haben darf
            //HashSet<string> vornamen = new HashSet<string>();

            //vornamen.Add("Max");
            //vornamen.Add("Moritz");
            //vornamen.Add("Tom");
            //vornamen.Add("Franz");
            //vornamen.Add("Max");

            //foreach (var item in vornamen)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #region Übung:
            // User kann in der Konsole mehrere Zahlen eingeben

            // > "Bitte geben Sie eine Zahl ein:"
            // > 12
            // > "Bitte geben Sie eine Zahl ein:"
            // > 9
            // > ..... bis irgendwann der User "q" eingibt
            // "Die Summe aller bisher eingegebenen Zahlen ist : ....

            //string eingabe = "123123";
            //string falscheEingabe = "123123asd";

            //if(Int32.TryParse(eingabe,out var konvertierteZahl))
            //{
            //    // true -> gültige zahl
            //}
            //else
            //{
            //    // keine gültige zahl
            //} 
            #endregion

            #region Indexer
            //int[] zahlen = { 123123, 5, 7, 4, 233, 6, 79, 95, 3 };

            //zahlen[0] = 12;                     // Schreibzugriff auf Index 0
            //Console.WriteLine(zahlen[0]);       // Lesezugriff auf Index 0



            //GanzerSatz meinSatz = new GanzerSatz("Das ist ein Satz...");

            //Console.WriteLine(meinSatz.Satz);
            //meinSatz[2] = "kein";
            //Console.WriteLine(meinSatz.Satz);

            ////Console.WriteLine(meinSatz[1]); 
            #endregion

            #region Operatoren
            //Bruch b1 = new Bruch(1, 4);
            //Bruch b2 = new Bruch(2,1);

            //var erg = b1 * b2;

            //Console.WriteLine($"{erg.Zähler}/{erg.Nenner}"); 
            #endregion

            #region Erweiterungsmethoden
            //string text = "Hallo Welt !";

            //string umgedreht = text.Umdrehen();
            //Console.WriteLine(umgedreht);

            //Console.WriteLine("---ENDE---");

            //int zahl = 42;
            //Console.WriteLine(zahl.Verdoppeln()); 
            #endregion

            Console.ReadKey();

            // Programm schließen:
            // Environment.Exit(0);

            // Environment.FailFast("schnell zumachen :)");
        }
    }

    class ListenContainer
    {
        public ListenContainer()
        {
            Zahlenliste = new List<int>();
            Tickets = new Queue<string>();
        }
        public List<int> Zahlenliste { get; set; }
        public Queue<string> Tickets { get; set; }
    }
}
