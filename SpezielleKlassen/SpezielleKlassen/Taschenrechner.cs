using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpezielleKlassen
{
    static class Taschenrechner
    {
        // Setter Weglöschen -> "Readonly-Property"
        public static double PI { get; } = 3.14;
        public static int Addieren(int z1, int z2)
        {
            return z1 + z2;
        }
        public static int Subtrahieren(int z1, int z2)
        {
            return z1 - z2;
        }

        #region Anwendungsfall für Read-Only Properties
        //private static string vorname;
        //private static string nachname;

        //public static string GanzerName
        //{
        //    get
        //    {
        //        return vorname + " " + nachname;
        //    }
        //} 
        #endregion
    }
}
