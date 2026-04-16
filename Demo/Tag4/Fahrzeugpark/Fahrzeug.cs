using System;
using System.Collections.Generic;
using System.Text;

namespace Tag4.Fahrzeugpark
{
    // Klasse Fahrzeug im Namespace Tag3.Fahrzeugpark
    // Eigenschaften: Anzahl Räder, Aktuelle Geschwindigkeit, Maximale Geschwindigkeit, Name
    // Funktionen: Beschleunigen, Bremsen, Hupen
    class Fahrzeug
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

        #region statische Member
        // Statisches Feld, um die Anzahl der erstellten Fahrzeuge zu zählen
        // Standardwerte bei statischen Feldern müssen hier gesetzt werden, da sie nicht im Konstruktor gesetzt werden können
        public static int AnzahlFahrzeuge { get; private set; } = 0;

        // Statische Methode, um die Anzahl der erstellten Fahrzeuge als Text auszugeben
        public static void AusgabeAnzahlFahrzeuge()
        {
            Console.WriteLine($"Anzahl der erstellten Fahrzeuge: {AnzahlFahrzeuge}");
        }
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
            // Erhöht die Anzahl der erstellten Fahrzeuge um 1 bei jedem Aufruf des Konstruktors
            AnzahlFahrzeuge++;
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

        #region destruktor
        // Wird aufgerufen, wenn ein Objekt der Klasse Fahrzeug zerstört wird
        ~Fahrzeug()
        {
            AnzahlFahrzeuge--; // Verringert die Anzahl der erstellten Fahrzeuge um 1 bei jedem Aufruf des Destruktors
        }
        #endregion

        #region Methoden
        public virtual string Info()
        {
            return $"Name: {Name}, Anzahl Räder: {getAnzahlRaeder()}, Aktuelle Geschwindigkeit: {AktGeschwindigkeit} km/h, Maximale Geschwindigkeit: {MaxGeschwindigkeit} km/h";
        }
        #endregion




    }
}
