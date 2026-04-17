namespace Tag5
{
    using Fahrzeugpark;
    class Program
    {

        static void Main(string[] args)
        {
            Test test = new Test();
            // Alle Methoden, die von Object sind, sind virtual und können daher überschrieben werden
            // Methoden die von Object geerbt werden:
            // Equals: vergleicht das Object mit einem anderen Objekt
            test.Equals(new Test());
            // ToString: gibt eine String-Repräsentation des Objekts zurück
            Console.WriteLine(test.ToString());
            // Gibt einen Hashcode zurück, der das Objekt repräsentiert
            Console.WriteLine(test.GetHashCode());
            // Gibt den Laufzeit Typ des Objekts zurück
            Console.WriteLine(test.GetType());

            // Typtest mit getType und typeof (Laufzeittyp)
            Fahrzeug pkwAlsFahrzeug = new PKW();
            Console.WriteLine(pkwAlsFahrzeug.GetType() == typeof(Fahrzeug));
            Console.WriteLine(pkwAlsFahrzeug.GetType() == typeof(PKW));
            // Wenn ich auf die Eigenschaft Kraftstoff zugreifen möchte, muss ich das Objekt in PKW umwandeln
            Console.WriteLine(((PKW)pkwAlsFahrzeug).Kraftstoff);
            // Wenn es den Variablentyp PKW hätte, brauch ich die Umwandlung nicht
            PKW pkw = new PKW();
            Console.WriteLine(pkw.Kraftstoff);


            // Typtest mit is (Variablentyp), Analogie: kann als "Klasse" betrachtet werden
            Console.WriteLine(pkwAlsFahrzeug is PKW); // true, da pkwAlsFahrzeug ein PKW ist
            Console.WriteLine(pkwAlsFahrzeug is Fahrzeug); // true, da pkwAlsFahrzeug ein Fahrzeug ist
            Console.WriteLine(pkw is PKW); // true, da pkw ein PKW ist
            Console.WriteLine(pkw is Fahrzeug); // true, da pkw ein Fahrzeug ist
            Fahrzeug fahrzeug = new Fahrzeug();
            Console.WriteLine(fahrzeug is PKW); // false, da fahrzeug kein PKW ist
            Console.WriteLine(fahrzeug is Fahrzeug); // true, da fahrzeug ein Fahrzeug ist
            Console.WriteLine(fahrzeug is object); // true, da jede Klasse von Objekt erbt und somit jedes Objekt ein Objekt ist
        }
    }
    class Test
    {
        override public string ToString()
        {
            return base.ToString()+" Das ist ein Test-Objekt";
        }
     
    }
}