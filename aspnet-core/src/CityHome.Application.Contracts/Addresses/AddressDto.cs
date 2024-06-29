using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace CityHome.Addresses
{
    public class AddressDto : AuditedEntityDto<Guid>
    {
        public string AddressLine1 { get; set; }
        public string? AddressLine2 { get; set; }
        public string Pincode { get; set; }
        public string City { get; set; }
        public string State { get; set; }
    }
}
