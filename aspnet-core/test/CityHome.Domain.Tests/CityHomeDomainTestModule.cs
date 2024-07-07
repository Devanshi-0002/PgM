using Volo.Abp.Modularity;

namespace CityHome;

[DependsOn(
    typeof(CityHomeDomainModule),
    typeof(CityHomeTestBaseModule)
)]
public class CityHomeDomainTestModule : AbpModule
{

}
