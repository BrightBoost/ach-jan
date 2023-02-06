using System;
namespace GenericAndCollectionsVoorbeeld
{
	public class Customer
	{
        public string Name { get; set; }
        public List<Address> Addresses { get; set; }
        public List<Order> Orders { get; set; }

        public Customer(string name, List<Address> addresses, List<Order> orders)
        {
            Name = name;
            Addresses = addresses;
            Orders = orders;
        }

        public Customer(string name, List<Address> addresses): this(name, addresses, new List<Order>())
        {
        }

        public void AddAddress(Address a)
        {
            Addresses.Add(a);
        }
    }
}

