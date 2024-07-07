using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace CityHome.PgMembers
{
    public class GetPgMemberListDto : PagedAndSortedResultRequestDto
    {
        public string? Filter { get; set; }
    }
}
