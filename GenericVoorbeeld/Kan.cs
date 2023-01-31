using System;
namespace GenericVoorbeeld
{
	public class Kan<T>
	{
		public T Inhoud { get; set; }

		public Kan(T inhoud)
		{
			Inhoud = inhoud;
		}
	}
}

