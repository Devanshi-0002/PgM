using Volo.Abp.Modularity;

namespace CityHome;

public abstract class CityHomeApplicationTestBase<TStartupModule> : CityHomeTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
