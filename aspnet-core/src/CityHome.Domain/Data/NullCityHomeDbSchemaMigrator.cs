using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace CityHome.Data;

/* This is used if database provider does't define
 * ICityHomeDbSchemaMigrator implementation.
 */
public class NullCityHomeDbSchemaMigrator : ICityHomeDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
