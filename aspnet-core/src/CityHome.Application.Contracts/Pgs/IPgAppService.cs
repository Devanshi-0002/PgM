using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace CityHome.Pgs
{
    public interface IPgAppService : ICrudAppService<
          PgDto,
          Guid,
          PagedAndSortedResultRequestDto,
          CreateUpdatePgDto,
          CreateUpdatePgDto>
    {
    }
}
