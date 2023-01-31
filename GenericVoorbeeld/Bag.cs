using System;
namespace GenericAndCollectionsVoorbeeld
{
	public class Bag<T>
	{
		public T Inhoud { get; set; }

		public Bag(T inhoud)
		{
			Inhoud = inhoud;
		}


	}
}

