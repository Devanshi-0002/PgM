using Volo.Abp.Settings;

namespace CityHome.Settings;

public class CityHomeSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(CityHomeSettings.MySetting1));
    }
}
