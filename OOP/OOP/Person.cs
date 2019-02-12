using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    // Zugriffsmodifizierer
    // public                 -> Jeder darf darauf zugreifen
    // private                -> Zugriff nur innerhalb der eigenen Klasse möglich
    // protected              -> Zugriff nur innerhalb der eigenen Klasse UND allen Klassen, die davon erben

    // internal               -> Zugriff innerhalb der Assembly wie Public, ausserhalb wie Private
    // protected internal     -> Mischung aus protected und internal => wenn man erbt, ist es auch in einer fremden Assembly verfügbar
    // private protected      -> gegenteil von protected internal => wenn man erbt, ist es nicht wie protected in der fremden Assembly, sondern wie private

    class Person
    {
        // Felder
        //private string Vorname;
        //private string Nachname;
        //private byte Alter;
        //private decimal Kontostand;
        //private bool Geschlecht;



        private string vorname; // Feld immer klein
        public string Vorname   // Properties immer groß
        {
            get // Lesezugriff
            {
                return vorname;
            }
            set // Schreibzugriff
            {
                vorname = value; // value = der neue Wert
            }
        }

        // Property:
        // propfull + TAB + TAB

        private string nachname;
        public string Nachname
        {
            get { return nachname; }
            set { nachname = value; }
        }

        private byte alter;
        public byte Alter
        {
            get { return alter; }
            private set
            {
                if(value > 0 && value < 130)
                    alter = value;
                else
                    Console.WriteLine("Ungültiges Alter");
            }
        }
        public void Gebutstag()
        {
            Alter++;
        }

        // Autoproperty - Kurzschreibweise
        // prop + TAB + TAB
        public bool Geschlecht { get; set; }
        public decimal Kontostand { get; protected set; }

        // Variante "Java"
        //private void VornameSetzen(string neuerVorname)
        //{
        //    // Schreibzugriff
        //    Vorname = neuerVorname;
        //}
        //public string VornameAuslesen()
        //{
        //    return Vorname;
        //}


        // 2 spezielle Methoden
        // Konstruktor
        // Destruktor


        // Konstruktor:
        // ctor + TAB + TAB
        //public Person()
        //{
        //    Vorname = "Max";
        //    Nachname = "Mustermann";
        //    Alter = 100;
        //    Kontostand = 100000;
        //    Geschlecht = true;
        //}

        // Automatisches Erstellen von einem Konstruktor:
        // RechteMaustaste: "QuickActions and Refectoring" -> Generate Constructor
        // Alternative für das Menü: STRG + .

        // Destruktor
        ~Person()
        {
            Console.WriteLine("Ich werde gerade aus dem Heap gelöscht");
        }
    }
}
