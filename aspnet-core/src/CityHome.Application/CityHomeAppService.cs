using CityHome.Localization;
using Volo.Abp.Application.Services;

namespace CityHome;

/* Inherit your application services from this class.
 */
public abstract class CityHomeAppService : ApplicationService
{
    protected CityHomeAppService()
    {
        LocalizationResource = typeof(CityHomeResource);
    }
}
