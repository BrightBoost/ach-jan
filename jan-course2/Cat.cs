using System;
namespace jan_course2
{
	public class Cat: Animal
	{
		private int _aantalLevens;
		private string _naam;

		public int aantalLevens
		{
			get => _aantalLevens;
			set
			{
				if(value >= 0)
				{
					_aantalLevens = value;
				}
			}
		}

		public string naam
		{
			get => _naam;
			set => _naam = value;
		}

		public void BijtInTV()
		{
			Console.WriteLine("Mijn baasje gaat niet blij zijn... HAP HAP KRAB");
			aantalLevens--;
			Console.WriteLine("Aantal levens over: " + aantalLevens);
		}

		public string GeefCadeautje()
		{
			return "Bluhg... Haarbal";
		}

		public void GeefEten(string eten)
		{
			if(eten.Contains("brokken"))
			{
				Console.WriteLine("Brokken... zegt " + naam + ". En haalt zijn neus op en loopt weg.");
			}
			else
			{
				Console.WriteLine("Jam jam, zegt " + naam + ": " + eten);
			}
		}

		public void GeefEten(string eten, double aantal)
		{
			for(int i = 0; i < aantal; i++)
			{
				Console.WriteLine("Jammie " + eten);
			}
		}

        public override void Eat()
        {
			//base.Eat();
			Console.WriteLine("Cat eats");
        }

        // custom constructor
        public Cat(int aantalLevens, string naam) : base("beige")
		{
			this.aantalLevens = aantalLevens;
			this.naam = naam;
		}


		public Cat(string naam) : this(9, naam)
        {
		
		}

		public Cat() : this("Minoes")
		{

		}

	}
}

