using LoginPageDemo.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace LoginPageDemo
{
    [DependsOn(
        typeof(LoginPageDemoEntityFrameworkCoreTestModule)
        )]
    public class LoginPageDemoDomainTestModule : AbpModule
    {

    }
}