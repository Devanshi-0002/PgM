using CityHome.Addresses;
using CityHome.Pgs;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace CityHome.PgMembers
{
    public class PgMemberDto : CreateUpdatePgMemberDto
    {
        public Guid Id { get; set; }
        public Guid? PgId { get; set; }
    }
}
