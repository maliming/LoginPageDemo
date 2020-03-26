using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace LoginPageDemo.EntityFrameworkCore
{
    [DependsOn(
        typeof(LoginPageDemoEntityFrameworkCoreModule)
        )]
    public class LoginPageDemoEntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<LoginPageDemoMigrationsDbContext>();
        }
    }
}
