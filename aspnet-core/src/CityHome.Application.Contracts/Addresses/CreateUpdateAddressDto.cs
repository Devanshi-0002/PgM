using System;
using System.Collections.Generic;
using System.Text;

namespace CityHome.Addresses
{
    public class CreateUpdateAddressDto
    {
        public string AddressLine1 { get; set; }
        public string? AddressLine2 { get; set; }
        public string Pincode { get; set; }
        public string City { get; set; }
        public string State { get; set; }
    }
}
