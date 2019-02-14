using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DelegatenUndEvents
{
    class Maschine
    {
        public event EventHandler Aufgabe50Prozent;
        public event EventHandler Aufgabe80Prozent;
        public event EventHandler Aufgabe100Prozent;
        public void SuperlangeAufgabe()
        {
            // berechnungen ....
            Thread.Sleep(2000);
            Aufgabe50Prozent?.Invoke(this, EventArgs.Empty);
            Thread.Sleep(5000);
            Aufgabe80Prozent?.Invoke(this, EventArgs.Empty);
            Thread.Sleep(10000);
            Aufgabe100Prozent?.Invoke(this, EventArgs.Empty);
        }
    }
}
