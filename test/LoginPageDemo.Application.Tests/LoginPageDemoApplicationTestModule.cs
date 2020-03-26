using Volo.Abp.Modularity;

namespace LoginPageDemo
{
    [DependsOn(
        typeof(LoginPageDemoApplicationModule),
        typeof(LoginPageDemoDomainTestModule)
        )]
    public class LoginPageDemoApplicationTestModule : AbpModule
    {

    }
}