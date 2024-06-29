using System.Threading.Tasks;

namespace CityHome.Data;

public interface ICityHomeDbSchemaMigrator
{
    Task MigrateAsync();
}
