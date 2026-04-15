class Program
{
    enum Weekday
    {
        // Standardmäßig beginnt die Zählung bei 0, aber wir können auch explizit Werte zuweisen
        Monday = 1, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday
    }
    static void Main()
    {
        // Schleifen

        // foreach-Schleife
        //string[] names = { "Alice", "Bob", "Charlie" };
        //string[] reverseNames = new string[3];

        //int i = 0; // foreach hat keinen index, deshalb müssen wir einen eigenen Zähler verwenden (um auf den anderen Array zuzugreifen)
        //foreach (string name in names)
        //{ // bei jedem Durchlauf wird die Variable "name" mit dem aktuellen Element des Arrays "names" belegt
        //    Console.WriteLine(name.ToUpper());

        //    char[] charArray = name.ToCharArray();
        //    Array.Reverse(charArray);
        //    reverseNames[i] = new string(charArray);
        //    i++;
        //}

        //foreach (var item in reverseNames)
        //{
        //    Console.WriteLine(item);
        //}

        // Enums und Switch-Case
        //Weekday today = Weekday.Tuesday;

        //switch (today)
        //{
        //    case Weekday.Monday:
        //        Console.WriteLine("Wochenstart.");
        //        break;
        //    case Weekday.Friday:
        //    case Weekday.Sunday:
        //    case Weekday.Saturday:
        //        Console.WriteLine("Wochenende.");
        //        break;
        //    default: 
        //        Console.WriteLine("Wochentag.");
        //        break;
        //}

        //// Enum Integer ansprechen
        //Console.WriteLine((int)Weekday.Thursday); // type casten, um den Integer-Wert zu erhalten

        //// Enum Element 0 ausgeben
        //Console.WriteLine((Weekday)0);

        // Methoden
        int[] a = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        Console.WriteLine(add(a));
        Console.WriteLine(add(new int[] {1,2,3,4,5}));
        Console.WriteLine(add(3, 4));
        Console.WriteLine(add(3, 4, 12, 53));
        Console.WriteLine(add(3.1, 4));
        string firstName = "Max";
        string lastName = " Mustermann";
        Console.WriteLine(add(firstName, lastName));
    }

    // Methoden überladen

    static double add (double x, double y)
    {
        return x + y;
    }
     static string add (string x, string y)
    {
        return x + y;
    }
    static int add(params int[] numbers)
    {
        int sum = 0;
        foreach (var item in numbers)
        {
            sum+=item;
        }
        return sum;
    }
}