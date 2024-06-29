using CityHome.Addresses;
using System;
using System.Collections.Generic;
using System.Text;

namespace CityHome.Pgs
{
    public class CreateUpdatePgDto
    {
        public string PgName { get; set; }
        public int Vacancy { get; set; }
        public string OwnerName { get; set; }
        public string OwnerPhoneNumber { get; set; }
        public Guid PgAddressId { get; set; }
        public AddressDto PgAddress { get; set; }
    }
}
