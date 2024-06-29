using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace CityHome;

[Dependency(ReplaceServices = true)]
public class CityHomeBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "CityHome";
}
