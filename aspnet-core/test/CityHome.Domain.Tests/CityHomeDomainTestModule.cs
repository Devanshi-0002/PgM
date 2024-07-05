using Volo.Abp.Modularity;

namespace Pg.CityHome;

[DependsOn(
    typeof(CityHomeDomainModule),
    typeof(CityHomeTestBaseModule)
)]
public class CityHomeDomainTestModule : AbpModule
{

}
