using System;
namespace GenericAndCollectionsVoorbeeld
{
	public class Customer
	{
        public string Name { get; set; }
        public List<Address> Addresses { get; set; }

        public Customer(string name, List<Address> addresses)
        {
            Name = name;
            Addresses = addresses;
        }

        public void AddAddress(Address a)
        {
            Addresses.Add(a);
        }
    }
}

