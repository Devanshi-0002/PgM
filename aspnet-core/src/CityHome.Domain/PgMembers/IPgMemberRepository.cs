using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;

namespace CityHome.PgMembers
{
    public interface IPgMemberRepository : IRepository<PgMember, Guid>
    {
        Task<List<PgMember>> GetListAsync(
            int skipCount,
            int maxResultCount,
            string sorting,
            string filter = null
        );
    }
}
