using CityHome.PgMembers;
using System;
using Volo.Abp.Domain.Entities.Auditing;

namespace CityHome.Addresses
{
    public class Address : FullAuditedAggregateRoot<Guid>
    {
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string Pincode { get; set; }
        public string City { get; set; }
        public string State { get; set; }

        public Guid? PgMemberId { get; set; }
        public PgMember PgMember { get; set; }
    }
}
