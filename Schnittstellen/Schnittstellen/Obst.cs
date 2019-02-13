namespace Schnittstellen
{
    // Unterschied zwischen Interface implementieren und Vererbung:
    // Erben: 1 Klasse
    // Interfaces: So viele, wie man mag
    class Obst : IProdukt
    {
        public string Name { get; set; }
        public string Herkunft { get; set; }
        public decimal Preis { get; set; }
        public int Kcal { get; set; }
    }

}
