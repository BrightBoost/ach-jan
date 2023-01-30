using System;
namespace jan30
{
	public class ElectricCar: Car, IAmphibious
	{
		public ElectricCar(double weight) : base(weight)
		{
			Console.WriteLine("In the electric car constructor");
		}

		public void Transition()
		{
			Console.WriteLine("Plons");
		}
    }
}

