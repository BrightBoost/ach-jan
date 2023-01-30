﻿using System;
namespace jan_course2
{
	public class Cat
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

		// custom constructor
		public Cat(int aantalLevens, string naam)
		{
			_aantalLevens = aantalLevens;
			_naam = naam;
		}

		public Cat(string naam)
		{
			_aantalLevens = 9;
			_naam = naam;
		}
	}
}

