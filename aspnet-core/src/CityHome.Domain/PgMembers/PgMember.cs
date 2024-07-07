using CityHome.Addresses;
using CityHome.Documents;
using CityHome.Pgs;
using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using Volo.Abp.Domain.Entities.Auditing;

namespace CityHome.PgMembers
{
    public class PgMember : FullAuditedAggregateRoot<Guid>
    {
        public string FullName { get; set; }
        public string MobileNumber { get; set; }
        public string Email { get; set; }
        public decimal RentAmount { get; set; }
        public decimal DepositedAmount { get; set; }
        public string Education { get; set; }
        public string JobCollegeOtherOption { get; set; }
        public Address JobCollegeAddress { get; set; }
        public DateTime DateOfJoining { get; set; }
        public Address PermanentAddress { get; set; }
        public string EmergencyMobileNumber { get; set; }

        public Guid? PgId { get; set; }
        public Pg Pg { get; set; }

        public ICollection<UserDocument> UserDocuments { get; set; }
    }
}
