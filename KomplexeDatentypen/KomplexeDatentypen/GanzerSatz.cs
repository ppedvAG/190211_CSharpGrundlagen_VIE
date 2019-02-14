using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomplexeDatentypen
{
    class GanzerSatz
    {
        public GanzerSatz(string satz)
        {
            Satz = satz;
        }

        public string Satz { get; set; }


        // indexer + TAB + TAB

        public string this[int index]
        {
            get
            {
                string[] wörter = Satz.Split();
                return wörter[index];
            }
            set
            {
                string[] wörter = Satz.Split();
                wörter[index] = value;

                Satz = string.Join(" ", wörter);
            }
        }
    }
}
