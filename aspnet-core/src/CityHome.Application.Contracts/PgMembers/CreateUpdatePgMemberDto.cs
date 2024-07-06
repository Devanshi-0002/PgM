using CityHome.Addresses;
using CityHome.Pgs;
using System;
using System.Collections.Generic;
using System.Text;

namespace CityHome.PgMembers
{
    public class CreateUpdatePgMemberDto
    {
        public string FullName { get; set; }

        public string MobileNumber { get; set; }

        public string Email { get; set; }

        public decimal RentAmount { get; set; }

        public decimal DepositedAmount { get; set; }

        public string? Education { get; set; }

        public string? JobCollegeOtherOption { get; set; }

        public CreateUpdateAddressDto JobCollegeAddress { get; set; }

        public DateTime DateOfJoining { get; set; }

        public CreateUpdateAddressDto PermanentAddress { get; set; }

        public string EmergencyMobileNumber { get; set; }

        public Guid? PgId { get; set; }

    }
}
