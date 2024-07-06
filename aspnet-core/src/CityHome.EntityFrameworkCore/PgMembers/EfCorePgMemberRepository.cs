using CityHome.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;
using System.Linq.Dynamic.Core;
using Microsoft.EntityFrameworkCore;

namespace CityHome.PgMembers
{
    public class EfCorePgMemberRepository : EfCoreRepository<CityHomeDbContext, PgMember, Guid>,
        IPgMemberRepository
    {
        public EfCorePgMemberRepository(
       IDbContextProvider<CityHomeDbContext> dbContextProvider)
       : base(dbContextProvider)
        {
        }

        public async Task<List<PgMember>> GetListAsync(
       int skipCount,
       int maxResultCount,
       string sorting,
       string filter = null)
        {
            var dbSet = await GetDbSetAsync();
            return await dbSet
                .WhereIf(
                    !filter.IsNullOrWhiteSpace(),
                    PgMember => PgMember.FullName.Contains(filter)
                    )
                .OrderBy(sorting)
                .Skip(skipCount)
                .Take(maxResultCount)
                .ToListAsync();
        }
    }
}
