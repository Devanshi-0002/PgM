using Volo.Abp.Modularity;

namespace Pg.CityHome;

public abstract class CityHomeApplicationTestBase<TStartupModule> : CityHomeTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
