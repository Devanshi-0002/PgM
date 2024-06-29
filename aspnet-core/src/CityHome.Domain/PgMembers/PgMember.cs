using CityHome.Addresses;
using CityHome.Pgs;
using System;
using Volo.Abp.Domain.Entities.Auditing;

namespace CityHome.PgMembers
{
    public class PgMember : FullAuditedAggregateRoot<Guid>
    {
        public string Name { get; set; }
        public string MobileNumber { get; set; }
        public string Email { get; set; }
        public decimal Rent { get; set; }
        public decimal DepositAmount { get; set; }
        public Guid JobLocationId { get; set; }
        public Address JobLocation { get; set; }
        public Guid PermanentAddressId { get; set; }
        public Address PermanentAddress { get; set; }
        public DateTime DateOfJoining { get; set; }
        public string ParentNumber { get; set; }
        // public byte[] Signature { get; set; }
        public Guid PgId { get; set; }
        public Pg Pgs { get; set; }
}
}
