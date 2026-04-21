using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fahrzeugpark
{
	//Schiff erbt von der Fahrzeug-Klasse und übernimmt deren Member
	public class Schiff : Fahrzeug
	{
		//Klasseneigener Enum
		public enum SchiffsTreibstoff { Diesel = 0, Dampf, Wind, Muskelkraft }

		//Klasseneigene Property
		public SchiffsTreibstoff Treibstoff { get; set; }

		public Schiff(): base()
		{
			this.Treibstoff = SchiffsTreibstoff.Diesel;
        }

		//Konstruktor mit Bezug auf den Konstruktor der Mutterklasse (base)
		public Schiff(string name, int maxG, double preis, SchiffsTreibstoff treibstoff) : base(name, maxG, preis)
		{
			this.Treibstoff = treibstoff;
		}

		//Überschreibung der Info()-Methode mit Bezug auf die Methode der Mutterklasse (base)
		public override string Info()
		{
			return "Das Schiff " + base.Info() + $" Es fährt mit {this.Treibstoff}.";
		}

		//Überschreibung der abstrakten Hupe()-Methode
		public override void Hupe()
		{
			Console.WriteLine("Das Schiff hupt");
		}
	}
}
