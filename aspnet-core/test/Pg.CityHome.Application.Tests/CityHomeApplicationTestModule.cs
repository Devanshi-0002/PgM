using Volo.Abp.Modularity;

namespace Pg.CityHome;

[DependsOn(
    typeof(CityHomeApplicationModule),
    typeof(CityHomeDomainTestModule)
)]
public class CityHomeApplicationTestModule : AbpModule
{

}
