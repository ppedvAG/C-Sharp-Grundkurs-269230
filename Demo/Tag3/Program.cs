
namespace Tag3
{
    using Fahrzeugpark;
    class Program
    {
        static void Main()
        {
            Fahrzeug pkw = new Fahrzeug();
            Fahrzeug lkw = new Fahrzeug();
            Fahrzeug bus = new Fahrzeug("Bus", 4, 80);
            Fahrzeug bagger = new Fahrzeug("Bagger", 0);

            Console.WriteLine("Anzahl Räder PKW: " + pkw.getAnzahlRaeder());
            pkw.setAnzahlRaeder(4);
            lkw.setAnzahlRaeder(6);
            Console.WriteLine("Anzahl Räder PKW: " + pkw.getAnzahlRaeder() + " Geschwindigkeit: " + pkw.AktGeschwindigkeit);
            Console.WriteLine("Anzahl Räder LKW: " + lkw.getAnzahlRaeder());
            
         
        }
    }
}