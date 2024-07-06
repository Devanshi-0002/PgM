using Volo.Abp.Modularity;

namespace CityHome;

[DependsOn(
    typeof(CityHomeApplicationModule),
    typeof(CityHomeDomainTestModule)
)]
public class CityHomeApplicationTestModule : AbpModule
{

}
