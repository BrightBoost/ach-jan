using System;
namespace jan30
{
	public class Car: Vehicle
	{
		public Car(double weight): base(weight)
		{
            Console.WriteLine("In the car constructor met weight");
        }

		public Car(): this(1000)
		{
            Console.WriteLine("In the car constructor zonder weight");
        }
    }
}

