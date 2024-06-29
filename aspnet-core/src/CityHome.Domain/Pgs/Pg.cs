using CityHome.Addresses;
using System;
using Volo.Abp.Domain.Entities.Auditing;


namespace CityHome.Pgs
{
    public class Pg : AuditedAggregateRoot<Guid>
    {
        public string PgName { get; set; }
        public int Vacancy { get; set; }
        public string OwnerName { get; set; }
        public string OwnerPhoneNumber { get; set; }
        public Guid PgAddressId { get; set; }
        public Address PgAddress { get; set; }
    }
}
