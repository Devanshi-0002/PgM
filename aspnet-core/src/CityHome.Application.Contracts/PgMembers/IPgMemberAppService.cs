using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace CityHome.PgMembers
{
    public interface IPgMemberAppService: IApplicationService
    {
        Task<PgMemberDto> CreateAsync(CreateUpdatePgMemberDto input);
        Task DeleteAsync(Guid id);
        //Task<PgMemberDto> GetAsync(Guid id);
        Task<PagedResultDto<PgMemberDto>> GetListAsync(GetPgMemberListDto input);
        Task<PgMemberDto> UpdateAsync(Guid id, CreateUpdatePgMemberDto input);

    }
}
