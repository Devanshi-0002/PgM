using CityHome.Pgs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace CityHome.PgMembers
{
    public interface IPgMemberAppService : ICrudAppService<
        PgMemberDto,
        Guid,
        PagedAndSortedResultRequestDto,
        CreateUpdatePgMemberDto,
        CreateUpdatePgMemberDto>
    {
    }
}
