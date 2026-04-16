using System;
using System.Collections.Generic;
using System.Text;


namespace Tag4.Fahrzeugpark
{
    internal class PKW: Fahrzeug
    {
        public enum Treibstoff  {
            Benzin,
            Diesel,
            Elektro,
            Hybrid
        };

        public Treibstoff Kraftstoff { get; private set; }

        public PKW() : base() // ist nicht verplfichten, leerer Basiskonstruktor wird automatisch aufgerufen
        {
            Kraftstoff = Treibstoff.Benzin;
        }

        // Konstruktor mit Parametern
        public PKW(string name, int anzRaeder, Treibstoff kraftstoff) : base(name, anzRaeder)
        {
            Kraftstoff = kraftstoff;
        }
        // Konstruktor mit mehr Parameter+
        public PKW(string name, int anzRaeder, double maxGeschwindigkeit, Treibstoff kraftstoff) : base(name, anzRaeder, maxGeschwindigkeit)
        {
            Kraftstoff = kraftstoff;
        }

        // Methode Hupen
        public void Hupen()
        {
            Console.WriteLine("Hup Hup!");
        }


        public override string Info()
        {
            return base.Info() + " Kraftstoff: " + Kraftstoff;
        }
    }
}
