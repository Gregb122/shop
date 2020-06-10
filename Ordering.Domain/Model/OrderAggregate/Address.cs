using System;
using System.Collections.Generic;
using System.Text;

namespace Ordering.Domain.OrderAggregate
{
    public class Address
    {
        public int Id;
        string street;
        string postcode;
        public string City;
        string buildingNumber;
        string apartmentNumber;

        public Address()
        {
        }

        public Address(string street, string postcode, string city, string buildingNumber, string apartmentNumber)
        {
            this.street = street;
            this.postcode = postcode;
            City = city;
            this.buildingNumber = buildingNumber;
            this.apartmentNumber = apartmentNumber;
        }
    }
}
