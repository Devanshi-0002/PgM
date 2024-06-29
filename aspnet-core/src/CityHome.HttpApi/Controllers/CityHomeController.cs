using CityHome.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace CityHome.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class CityHomeController : AbpControllerBase
{
    protected CityHomeController()
    {
        LocalizationResource = typeof(CityHomeResource);
    }
}
