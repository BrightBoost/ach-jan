using System;
namespace jan30
{
	public class Vehicle
	{
		private double _weight;

		public double weight
		{
			get; set;
		}

		public Vehicle()
		{
		}

		public void Start()
		{
			Console.WriteLine("Start vehicle");
		}
	}
}

