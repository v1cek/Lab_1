using System;

namespace Lab_1
{
    public class Address
    {
        public int Index { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string House { get; set; }
        public string Apartment { get; set; }

        public Address(int index, string country, string city, string street, string house, string apartment)
        {
            Index = index;
            Country = country;
            City = city;
            Street = street;
            House = house;
            Apartment = apartment;
        }

        public void PrintAddress()
        {
            Console.WriteLine($"Address: {Index}, {Country}, {City}, {Street}, {House}, {Apartment}");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Address address = new Address(12345, "Ukraine", "Kyiv", "Main St", "10", "25");
            address.PrintAddress();
        }
    }
}
