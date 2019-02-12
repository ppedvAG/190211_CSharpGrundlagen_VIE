using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    // Vererbung
    class Mitarbeiter : Person
    {
        public string Vorgesetzter { get; set; }
        public string Abteilung { get; set; }

        public void MachWas()
        {
            Kontostand = 500;
        }
    }
}
