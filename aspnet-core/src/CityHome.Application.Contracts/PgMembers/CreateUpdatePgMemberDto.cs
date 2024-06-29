using CityHome.Addresses;
using CityHome.Pgs;
using System;
using System.Collections.Generic;
using System.Text;

namespace CityHome.PgMembers
{
    public class CreateUpdatePgMemberDto
    {
        //public Guid Id { get; set; }
        public string Name { get; set; }
        public string MobileNumber { get; set; }
        public string Email { get; set; }
        public decimal Rent { get; set; }
        public decimal DepositAmount { get; set; }
        public Guid? JobLocationId { get; set; }
        public AddressDto? JobLocation { get; set; }
        public Guid? PermanentAddressId { get; set; }
        public AddressDto? PermanentAddress { get; set; }
        public DateTime DateOfJoining { get; set; }
        public string ParentNumber { get; set; }
       // public byte[] Signature { get; set; }
        public Guid? PgId { get; set; }
        public CreateUpdatePgDto? Pgs { get; set; }
    }
}
