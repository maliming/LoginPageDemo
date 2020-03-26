using LoginPageDemo.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace LoginPageDemo.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(LoginPageDemoEntityFrameworkCoreDbMigrationsModule),
        typeof(LoginPageDemoApplicationContractsModule)
        )]
    public class LoginPageDemoDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
