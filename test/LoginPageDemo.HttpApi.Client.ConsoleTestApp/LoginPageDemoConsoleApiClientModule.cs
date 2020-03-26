using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace LoginPageDemo.HttpApi.Client.ConsoleTestApp
{
    [DependsOn(
        typeof(LoginPageDemoHttpApiClientModule),
        typeof(AbpHttpClientIdentityModelModule)
        )]
    public class LoginPageDemoConsoleApiClientModule : AbpModule
    {
        
    }
}
