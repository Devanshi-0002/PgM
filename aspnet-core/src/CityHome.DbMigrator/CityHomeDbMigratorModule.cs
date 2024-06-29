using CityHome.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace CityHome.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(CityHomeEntityFrameworkCoreModule),
    typeof(CityHomeApplicationContractsModule)
)]
public class CityHomeDbMigratorModule : AbpModule
{
}
