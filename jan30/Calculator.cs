using System;
namespace jan30;

public class Calculator
{
	public Calculator()
	{
	}

	public double addNumbers(double a, double b)
	{
		Console.WriteLine("In the double method with 2 params");
		return a + b;
	}

    public int addNumbers(params int[] a)
    {
        Console.WriteLine("In the int[] method with 2 params");
        return a[0];
    }

    public int addNumbers(int a, int b)
    {
        Console.WriteLine("In the int method with 2 params");
        return a + b;
    }

    

    public double addNumbers(double a, double b, double c)
    {
        Console.WriteLine("In the method with 3 params");
        return a + b + c;
    }
}

