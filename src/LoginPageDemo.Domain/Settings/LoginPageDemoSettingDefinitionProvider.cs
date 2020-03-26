using Volo.Abp.Settings;

namespace LoginPageDemo.Settings
{
    public class LoginPageDemoSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(LoginPageDemoSettings.MySetting1));
        }
    }
}
