using System;
using System.Collections.Generic;
using System.Text;

namespace Tag3.Fahrzeugpark
{
    // Klasse Fahrzeug im Namespace Tag3.Fahrzeugpark
    // Eigenschaften: Anzahl Räder, Aktuelle Geschwindigkeit, Maximale Geschwindigkeit, Name
    // Funktionen: Beschleunigen, Bremsen, Hupen
    internal class Fahrzeug
    {
        #region Eigenschaften
        // Alte Variante um Eigenschaften zu implementieren
        // Feld der Klasse Fahrzeug // Felder sind private
        // anzahlrRaeder hat einen Standardwert von 0
        private int anzahlRaeder = 0;

        // Eigenschaft zu dem Feld anzahlRaeder // Eigenschaften sind öffentlich
        public int getAnzahlRaeder() 
        { 
            return anzahlRaeder; 
        }
        public void setAnzahlRaeder(int value) 
        { 
            if(value>=0)
                anzahlRaeder = value; 
        }

        // Neue Variante um Eigenschaften zu implementieren
        public double AktGeschwindigkeit { get; private set; } // Auto-Property

        public double MaxGeschwindigkeit { get; private set; } // Auto-Property

        public string Name { get; private set; }
        #endregion

        #region Konstruktor
        // Wird beim Erstellen eines Objekts der Klasse Fahrzeug aufgerufen
        // Konstruktor ohne Parameter
        public Fahrzeug()
        {
            // Standardwerte können auch im Konstruktor gesetzt werden, am besten man macht es einheitlich
            Name = "Unbekanntes Fahrzeug";
            AktGeschwindigkeit = 0;
            MaxGeschwindigkeit = 100;
        }

        // Konstruktor mit Parametern
        public Fahrzeug(string name, int anzRaeder): this()
        {
            Name = name;
            setAnzahlRaeder(anzRaeder);
        }
        // Konstruktor mit mehr Parameter+
        public Fahrzeug(string name, int anzRaeder, double maxGeschwindigkeit): this(name, anzRaeder)
        {
            MaxGeschwindigkeit = maxGeschwindigkeit;
        }
        #endregion




    }
}
