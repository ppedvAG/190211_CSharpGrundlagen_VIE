using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schnittstellen
{
    interface IProdukt // Definiert alles, was public ist -> KEINE Gültigkeitsspezifizierer
    {
        string Name { get; set; }
        decimal Preis { get; set; }
    }
}
