using System;
namespace GenericAndCollectionsVoorbeeld
{
	public class Order
	{
		public Dictionary<Product, int> Items
		{
			get; set;
		}

		public Order(Dictionary<Product, int> items)
		{
			Items = items;
		}
	}
}

