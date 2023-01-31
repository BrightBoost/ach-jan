using System;
namespace OOPexercise
{
	public static class Extension//: Square mag niet inheritance van sealed class, wel uitbreiden mogelijk mbv extension methods
	{
		public static int TellNrOfSides(this Square s)
		{
			return 4;
		}
	}
}

