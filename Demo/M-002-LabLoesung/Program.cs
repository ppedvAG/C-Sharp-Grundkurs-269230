class Program
{
    static void Main()
    {
        int meter, hours, minutes, seconds, totalSeconds;
        double meterPerSecond, kilometerPerHour, milePerHour;

        Console.Write("Entfernung (in Meter): ");
        meter = int.Parse(Console.ReadLine());
        Console.Write("Stunden: ");
        hours = int.Parse(Console.ReadLine());
        Console.Write("Minuten: ");
        minutes = int.Parse(Console.ReadLine());
        Console.Write("Sekunden: ");
        seconds = int.Parse(Console.ReadLine());

        totalSeconds = hours * 3600 + minutes * 60 + seconds;
        meterPerSecond = (double)meter / totalSeconds;
        kilometerPerHour = meterPerSecond * 3.6;
        milePerHour = kilometerPerHour * 0.62137119; // 1 Kilometer = 0.62137119 Meilen

        Console.WriteLine("Meter/Sekunde: \t\t" + Math.Round(meterPerSecond, 2));
        Console.WriteLine("Kilometer/Stunde: \t" + Math.Round(kilometerPerHour, 2));
        Console.WriteLine("Meilen/Stunde: \t\t" + Math.Round(milePerHour, 2));
    }
}