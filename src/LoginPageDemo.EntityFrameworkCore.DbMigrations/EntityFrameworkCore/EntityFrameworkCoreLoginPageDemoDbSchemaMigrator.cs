using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using LoginPageDemo.Data;
using Volo.Abp.DependencyInjection;

namespace LoginPageDemo.EntityFrameworkCore
{
    public class EntityFrameworkCoreLoginPageDemoDbSchemaMigrator
        : ILoginPageDemoDbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCoreLoginPageDemoDbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            /* We intentionally resolving the LoginPageDemoMigrationsDbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<LoginPageDemoMigrationsDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}