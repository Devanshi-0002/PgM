using CityHome.Addresses;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace CityHome.Pgs
{
    public class PgDto : CreateUpdatePgDto
    {
        public Guid Id { get; set; }
    }
}
