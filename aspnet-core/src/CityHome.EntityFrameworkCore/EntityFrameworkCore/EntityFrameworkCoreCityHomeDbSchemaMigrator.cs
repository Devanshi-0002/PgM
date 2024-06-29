using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using CityHome.Data;
using Volo.Abp.DependencyInjection;

namespace CityHome.EntityFrameworkCore;

public class EntityFrameworkCoreCityHomeDbSchemaMigrator
    : ICityHomeDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreCityHomeDbSchemaMigrator(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolve the CityHomeDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<CityHomeDbContext>()
            .Database
            .MigrateAsync();
    }
}
