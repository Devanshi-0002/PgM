using CityHome.Addresses;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace CityHome.Pgs
{
    public class PgDto : AuditedEntityDto<Guid>
    {
        public string PgName { get; set; }
        public int Vacancy { get; set; }
        public string OwnerName { get; set; }
        public string OwnerPhoneNumber { get; set; }
        public Guid PgAddressId { get; set; }
        public AddressDto PgAddress { get; set; }
    }
}
