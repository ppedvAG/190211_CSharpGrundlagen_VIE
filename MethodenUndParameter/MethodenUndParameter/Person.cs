using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodenUndParameter
{
    enum Geschlecht
    {
        Männlich,
        Weiblich,
        Sächlich,
        Kampfhubschrauber
    }

    class Person
    {
        public string Vorname { get; set; }
        public string Nachname { get; set; }
        public byte Alter { get; set; }
        public decimal Kontostand { get; set; }
        public Geschlecht Geschlecht { get; set; }
    }
}
