using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace CityHome.Pgs
{
    public class PgAppService : CrudAppService<
        Pg,
        PgDto,
        Guid,
        PagedAndSortedResultRequestDto,
        CreateUpdatePgDto,
        CreateUpdatePgDto>,
        IPgAppService
    {
        public PgAppService(IRepository<Pg, Guid> repository)
            : base(repository)
        {
        }
    }
}
