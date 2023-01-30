using System;
namespace jan30;

public class Calculator
{
	public Calculator()
	{
	}

	public double addNumbers(double a, double b)
	{
		Console.WriteLine("In the method with 2 params");
		return a + b;
	}

        public double addNumbers(double a, double b, double c)
        {
            Console.WriteLine("In the method with 3 params");
            return a + b + c;
        }
    }

