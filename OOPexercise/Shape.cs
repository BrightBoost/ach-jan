using System;
namespace OOPexercise
{
	public abstract class Shape
	{
		public string Color
		{
			get; set;
		}

		public double Surface
		{
			get; set;
		}

		public double Circumference
		{
			get; set;
		}

		public abstract double CalcSurface();
		public abstract double CalcCircumference();

		public Shape(string color)
		{
			this.Color = color;
		}

		public Shape(string color, double surface, double circumference)
		{
			this.Color = color;
			this.Surface = surface;
			this.Circumference = circumference;
		}
	}
}

