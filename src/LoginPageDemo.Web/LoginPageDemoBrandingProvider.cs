using Volo.Abp.AspNetCore.Mvc.UI.Theme.Shared.Components;
using Volo.Abp.DependencyInjection;

namespace LoginPageDemo.Web
{
    [Dependency(ReplaceServices = true)]
    public class LoginPageDemoBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "LoginPageDemo";
    }
}
