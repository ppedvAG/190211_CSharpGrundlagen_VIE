using System;
using System.Globalization;
using System.Text;

namespace HalloWelt
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode; // Output als Unicode ausgeben

            #region Hallo Welt und Tastenkürzel
            //Console.WriteLine("Hallo Welt"); // Das ist ein Kommentar
            //                                 // Ein Kommentar am Anfang einer Zeile ...
            ///* Mehrzeiliges Kommentar
            // * abcde
            // * abcde
            // */
            //// Console.WriteLine("Meine Zahl ist {0:C4}", 42);


            //// Snippets:
            //// cw + TAB + TAB
            //// STRG + C  / V / X ohne Markierung betrifft die gesamte Zeile !

            //// Zeile duplizieren: STRG + D
            //Console.WriteLine("Hallo Welt in dieser Zeile");
            //Console.WriteLine("Hallo Welt in dieser Zeile");
            //Console.WriteLine("Hallo Welt in dieser Zeile");
            //Console.WriteLine("Hallo Welt in dieser Zeile");
            //Console.WriteLine("Hallo Welt in dieser Zeile");
            //Console.WriteLine("Hallo Welt in dieser Zeile");
            //Console.WriteLine("Hallo Welt in dieser Zeile");

            //Console.WriteLine("Test");
            //Console.WriteLine("Test");
            //Console.WriteLine("Test");
            //Console.WriteLine("Test");
            //Console.WriteLine("Test");
            //Console.WriteLine("Test");
            //// In mehreren Zeilen gleichzeitig schreiben ALT + Maus (Bereich markieren)
            //// Einrücken:
            //// 1) "Letzte" Klammer löschen und neu Einfügen
            //// 2) STRG + K + D

            //// Kommentare:
            //// STRG + K + C -> Auskommentieren
            //// STRG + K + U -> Kommentar entfernen

            //// Codezeilen verschieben
            //// ALT + Pfeiltaste (rauf/runter)
            //Console.WriteLine("Hallo Welt 1");
            //Console.WriteLine("Hallo Welt 2");
            //Console.WriteLine("Hallo Welt 3");
            #endregion

            // Einschließen in einem Codeblock:
            // STRG + K + S
            #region  Variablen
            //// Deklaration
            //int zahl1;
            //int z1, z2, z3;
            //string text;
            //string t1, t2, t3;

            //// Deklaration + Initialisierung
            //int zahl2 = 20; // gleich einen Startwert vergeben


            //zahl1 = 5;
            //Console.WriteLine(zahl1);

            //// Mini-Übung: erstellts 2 Variablen: zahl1 und zahl2 ( zb mit 10, 20)
            //// cw -> summe

            //// var
            //var zahl10 = 20.5;
            //var text10 = "Hallo Welt"; 
            #endregion

            #region Konvertieren
            ////Console.WriteLine("Bitte geben Sie eine Zahl ein:");
            ////string eingabe = Console.ReadLine();
            ////Console.WriteLine("Deine Eingabe war: " + eingabe);

            //// Implizites Konvertieren

            //int zahl1 = 5;      // Int32
            //long zahl2 = 10;    // Int64

            //// implizit int zu long konvertieren
            //zahl2 = zahl1;      // Wertebereich von Int32 passt komplett in Int64 hinein

            //zahl2 = 2000000000000000L;
            ////zahl1 = zahl2;      // "Technisch gesehen" könnte etwas drinnen stehen, was nicht in Int32 hineinpasst
            //// Casten => Konvertieren
            //zahl1 = (int)zahl2;

            //// Explizit Konvertieren

            //string text = "12345";
            //int zahl3 = Convert.ToInt32(text);
            ////Console.WriteLine(zahl3 + 20); 
            #endregion

            #region Überlauf
            //int z1 = Int32.MinValue;
            //int z2 = z1 - 1;

            //Console.WriteLine(z1);
            //Console.WriteLine(z2);

            //checked // Prüft auf arithmetischen Überlauf
            //{
            //    int z3 = Int32.MinValue;
            //    int z4 = z3 - 1;
            //}
            //long zahl = 1231231231231231231L;
            //int zahl20 = Convert.ToInt32(zahl); 
            #endregion

            #region Suffix
            //short zahl_1 = 5;
            //long zahl0 = 5;
            //var zahl1 = 5;

            //var zahl2 = 5.5;

            //float zahl123 = 5.5F;
            //// Suffix:
            //// F -> Float
            //// M -> Decimal
            //// L -> Long
            //// D -> Double
            //// U -> UnsignedInt32
            //// UL -> UnsignedInt64

            //var x = 12UL;
            //decimal pi = 3.14m;
            //decimal xyz = 12.3M;

            //// ....
            //xyz = Convert.ToDecimal(zahl123 + zahl_1); 
            #endregion

            #region Übung: 2 Zahlen einlesen und Summe ausgeben
            //Console.WriteLine("Bitte geben Sie Ihre erste Zahl ein");
            //string eingabe1 =  Console.ReadLine();
            //Convert.ToDouble("12.5", CultureInfo.CurrentCulture); 
            #endregion

            #region Verzweigung mit If
            //int zahl1 = 5;
            //int zahl2 = 5;

            //if(zahl1 > zahl2)
            //{   // True
            //    Console.WriteLine("größer");
            //}
            //else if(zahl1 == zahl2)
            //{
            //    Console.WriteLine("gleich groß");
            //}
            //else
            //{   // False
            //    Console.WriteLine("kleiner ❤❤❤");
            //}


            // Mini-Übung:
            // > "Bitte geben Sie Ihr Passwort ein":
            // -> Benutzer gibt was in die Konsole ein
            // -> Wenn das Passwort exakt "geheim" ist, dann kommt über CW("Login erfolgreich")
            // -> Wenn nicht, dann CW("Passwort ungültig");

            // Mini-Übung:

            // Random generator = new Random(); // Zufallszahlengenerator erstellen
            // int zufallsZahl = generator.Next(0, 10);

            // Erstellts eine Zufallszahl zwischen 0 und 10
            // Benutzer gibt eine Zahl ein
            // größer, kleiner oder "richtig erraten" 
            #endregion

            #region  Fallauswahl: Switch

            //float note = 5.1F;
            //switch(note)
            //{
            //    case 1:
            //        Console.WriteLine("Sehr gut");
            //        break;
            //    case 2:
            //        Console.WriteLine("Gut");
            //        break;
            //    case 3:
            //        Console.WriteLine("Befriediegend");
            //        break;
            //    case 4:
            //        Console.WriteLine("Genügend");
            //        // goto case 2;
            //        break;
            //    case 5:
            //        Console.WriteLine("Nicht Genügend");
            //        break;
            //    case 6:
            //    case 7:
            //    case 8:
            //        Console.WriteLine("6,7 oder 8");
            //        break;
            //    default:  // else
            //        Console.WriteLine("Unbekannte Note");
            //        break;
            //} 
            #endregion

            #region Zählergesteuerte Schleife: For
            ////for (initialisierung;bedingung;aktualisierung)

            //// Increment/Decrement
            //int zahl = 0;
            //// 1)
            //zahl = zahl + 1;
            //// 2) Erhöht sich selbst um X
            //zahl += 1;
            //// 3) Immer um 1 erhöhen
            //zahl++;

            //for(float zähler = 0;zähler < 10;zähler+=0.5F)
            //{
            //    Console.WriteLine("Hallo Welt " + zähler);
            //}

            //// for + TAB + TAB -> Reguläre For-Schleife
            //// forr + TAB + TAB -> Rückwärts-zählende For-Schleife
            //for (int i = 10 - 1; i >= 0; i--)
            //{
            //    Console.WriteLine(i);
            //} 
            #endregion

            #region Bedingungsgesteuerte Schleife: While

            //int zahl1 = 5;
            //int zahl2 = 10;

            //// Kopfgesteuert
            //// while + TAB + TAB
            //while (zahl1 < zahl2) // Entweder garnicht oder öfters ausgeführt
            //{
            //    Console.WriteLine(zahl1);
            //    zahl1++;
            //}

            //// Fußgesteuert
            //// do + TAB + TAB
            //do // entweder 1 mal oder öfters
            //{
            //    Console.WriteLine(zahl1);
            //    zahl1--;
            //} while (zahl1 >= 0);

            // Übung:
            // Solange raten, bis die Zahl erraten wurde :)

            // Schlüsselwörter für Schleifen
            // continue; -> nächster Schleifendurchgang
            // break; -> Schleife beenden

            //Random generator = new Random();

            //int zufallszahl = generator.Next(0, 10);
            //int versuch = -1;
            //do
            //{
            //    Console.WriteLine("Bitte geben Sie eine Zahl ein:");
            //    versuch = Convert.ToInt32(Console.ReadLine());
            //    if(versuch == zufallszahl)
            //        Console.WriteLine("Bingo !");
            //    else
            //        Console.WriteLine("Leider falsch!");
            //} while (versuch != zufallszahl); 
            #endregion

            #region Verknüpfungsoperatoren
            //// | , || - OR
            //// & , && - AND
            //// ^      - XOR (werte müssen unterschiedlich sein)
            //// !      - NOT

            ////int zahl1 = 5;
            ////if (zahl1 > 0 && zahl1 < 100)
            ////    ;

            //// Anwendungsfall "Kurzschlussvariante"

            //StringBuilder sb = null;
            ////sb.Append("Hallo");
            ////sb.Append("Welt");
            ////sb.Append("!");

            //if (sb != null && sb.Length > 10)
            //    ;
            //else
            //    ;
            //Console.WriteLine(sb); 
            #endregion

            #region Tenärer Operator

            ////int zahl = 5;
            ////string text;

            ////if (zahl > 10)
            ////    text = "größer";
            ////else
            ////    text = "kleiner";

            ////-----
            //int zahl = 5;
            ////            (Bedingung) ? TRUE     : FALSE;
            //string text = (zahl > 10) ? "größer" : "kleiner"; 
            #endregion

            // Fehlerbehandlung mit Try/Catch

            Console.WriteLine("Bitte geben Sie eine Zahl ein:");
            string eingabe = Console.ReadLine();

            int zahl;
            try
            {
                zahl = Convert.ToInt32(eingabe);
            }
            //catch(FormatException)
            //{
            //    zahl = -1;
            //    Console.WriteLine("Bitte keinen Buchstabensalat eingeben!");
            //}
            catch(OverflowException)
            {
                zahl = -1;
                Console.WriteLine("Ihre Zahl war zu groß oder zu klein");
            }
            catch (Exception ex) // Jede Exception
            {
                // var x = ex.StackTrace;  <-- Rückverfolgung, welche Methode den Fehler geworfen hat
                zahl = -1;
                Console.WriteLine("Es gibt einen Fehler !");
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine(zahl);

            Console.ReadKey();
        }
    }
}
