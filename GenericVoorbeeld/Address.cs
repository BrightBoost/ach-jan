using System;
namespace GenericAndCollectionsVoorbeeld
{
	public class Address
	{

		public string Street { get; set; }
        public string Number { get; set; }
        public string City { get; set; }
        public string Zipcode { get; set; }

        public Address(string street, string number, string city, string zipcode)
        {
            Street = street;
            Number = number;
            City = city;
            Zipcode = zipcode;
        }

        public void PrintAddress()
        {
            Console.WriteLine(Street + " " + Number + ", " + Zipcode + " " + City);
        }
    }
}

