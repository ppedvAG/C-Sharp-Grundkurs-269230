namespace Fahrzeugpark
{
	class Program
	{
		static void Main(string[] args)
		{
			// Ich kann kein Objekt der abstrakten Klasse Fahrzeug erstellen
			//Fahrzeug fahrzeug = new Fahrzeug();
			Fahrzeug[] fahrzeuge = new Fahrzeug[10];
			

			for (int i = 0; i <10; i++)
			{
				fahrzeuge[i] = Fahrzeug.GeneriereFahreug(i.ToString());
            }

            foreach (Fahrzeug f in fahrzeuge)
            {
                f.Hupe();
				Console.WriteLine(f.Info());
                Console.WriteLine(f.GetType() == typeof(Fahrzeug));
                Console.WriteLine(f is Fahrzeug);
                Console.WriteLine(f.GetType());
            }

        }
    }
}