using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphie
{
    class Lottozahlengenerator
    {
        public void Generate(int amountOfNumbers,int min,int max)
        {
            Random r = new Random();
            int[] lottozahlen = new int[amountOfNumbers];

            for (int i = 0; i < amountOfNumbers; i++)
            {
                int zufallszahl = r.Next(min, max);
                if(lottozahlen.Contains(zufallszahl))
                {
                    // doppelt
                    // i darf nicht weitergehen, damit wir die zahl X neu generieren
                    i--;
                }
                else
                {   // nicht doppelt
                    lottozahlen[i] = zufallszahl;
                }
            }

        }
    }
}
