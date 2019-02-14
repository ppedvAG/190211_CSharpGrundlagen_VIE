using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatenUndEvents
{
    class SpezialButton
    {
        public string Text { get; set; }
        public string Farbe { get; set; }

        //// Variante Event "lang"
        //private EventHandler buttonClickEvent;
        //public event EventHandler ButtonClickEvent
        //{
        //    add
        //    {
        //        buttonClickEvent += value;
        //    }
        //    remove
        //    {
        //        buttonClickEvent -= value;
        //    }
        //}

        // Variante "kurz"
        public event EventHandler ButtonClickEvent;
        public void Klick()
        {
            // ButtonClick
            if(ButtonClickEvent != null)
            {
                ButtonClickEvent(this, EventArgs.Empty);
            }
        }
    }
}
