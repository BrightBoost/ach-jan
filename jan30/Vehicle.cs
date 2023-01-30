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

		public Vehicle(double weight)
		{
			_weight = weight;
			Console.WriteLine("In the vehicle constructor");
		}

		public void Start()
		{
			Console.WriteLine("Start vehicle");
		}
	}
}

