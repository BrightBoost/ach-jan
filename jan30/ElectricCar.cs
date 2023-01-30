using System;
namespace jan30
{
	public class ElectricCar: Car
	{
		public ElectricCar(double weight): base(weight)
		{
            Console.WriteLine("In the electric car constructor");
        }
    }
}

