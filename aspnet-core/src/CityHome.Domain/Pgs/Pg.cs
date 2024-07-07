using CityHome.Addresses;
using CityHome.PgMembers;
using System;
using System.Collections.Generic;
using Volo.Abp.Domain.Entities.Auditing;


namespace CityHome.Pgs
{
    public class Pg : FullAuditedAggregateRoot<Guid>
    {
        public string PgName { get; set; }
        public int Vacancy { get; set; }
        public int Capacity { get; set; }
        public string OwnerName { get; set; }
        public string PgAddress { get; set; }
        public string OwnerPhoneNumber { get; set; }
        public decimal PgRent { get; set; }
        public DateTime PgOpeningDate { get; set; }

        public ICollection<PgMember> PgMembers { get; set; }
    }
}
