
namespace Tag4
{
    using Fahrzeugpark;
    class Program
    {
        static void Main()
        {
            //// Garbage Collection Test
            //Test test;
            //while (true)
            //{
            //    // Create a new Test object in each iteration
            //    // Will be destroyed, because it is not needed anymore
            //    test = new Test();
            //}
            //Console.WriteLine(test);

            // Statische Member
            //Fahrzeug pkw = new Fahrzeug();
            ////Console.WriteLine(pkw.AnzahlFahrzeuge); // geht nicht, da AnzahlFahrzeuge statisch ist und über die Klasse aufgerufen werden muss
            //Console.WriteLine(Fahrzeug.AnzahlFahrzeuge);
            //for(int i = 0; i <= 1_000_000; i++)
            //{
            //    pkw = new Fahrzeug();
            //}
            //Fahrzeug.AusgabeAnzahlFahrzeuge();

            //// Test Werttyp Referenztyp - lässt sich string vergleichen, wenn sie verschiedene Speicheradressen haben?
            //string text1 = "Hallo";
            //string text2 = "Hallo";
            //Console.WriteLine(text1 == text2); // true, da der Inhalt gleich ist#
            //// adresse vergleichen
            //Console.WriteLine(Object.ReferenceEquals(text1, text2));
            //// true, da Compiler String-Literale intern optimiert und beide Variablen auf dasselbe Objekt im Speicher verweisen


            //// aufrufen mit ref Parameter (muss davor initialisiert werden)
            //int zahl = 5;
            //plusZwei(ref zahl);
            //Console.WriteLine("Zahl erhöht: "+zahl);
            
            //int ergebnis = plusDreiMitQuersumme(123, out int quersumme);

            Fahrzeug fz1 = new Fahrzeug("fz1", 4, 70);
            PKW pkw1 = new PKW();
            Console.WriteLine(pkw1.Kraftstoff);

            Console.WriteLine(fz1.Info());
            Console.WriteLine(pkw1.Info());



        }
        // Funktion, die einen Wert um 2 erhöht, über Referenzübergabe
        static void plusZwei(ref int a)
        {
            a += 2;
        }
        // vergleich zu out, PlusDrei macht mit out keinen sinn, weil out-Parameter initalisiert werden müssen.
        //static void plusDrei(out int a)
        //{
        //    a += 2; // geht nicht, da out-Parameter vor der Verwendung initialisiert werden müssen
        //}

        // wo out sinn macht:
        static int plusDreiMitQuersumme(int a, out int quersumme)
        {
            quersumme = 0;
            char[] aCharArray = a.ToString().ToCharArray();
            foreach(char c in aCharArray)
                quersumme+=int.Parse(c.ToString());
            return a+3;
        }

    }

    

    class Test
    {
        public Test() { }
        ~Test()
        {
            // Info when the object is destroyed
            Console.WriteLine("Test object destroyed");
        }

    }
}