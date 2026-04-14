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
        Weekday today = Weekday.Tuesday;

        switch (today)
        {
            case Weekday.Monday:
                Console.WriteLine("Wochenstart.");
                break;
            case Weekday.Friday:
            case Weekday.Sunday:
            case Weekday.Saturday:
                Console.WriteLine("Wochenende.");
                break;
            default: 
                Console.WriteLine("Wochentag.");
                break;
        }

        // Enum Integer ansprechen
        Console.WriteLine((int)Weekday.Thursday); // type casten, um den Integer-Wert zu erhalten

        // Enum Element 0 ausgeben
        Console.WriteLine((Weekday)0);
    }
}