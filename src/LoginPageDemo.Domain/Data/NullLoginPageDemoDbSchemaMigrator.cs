using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace LoginPageDemo.Data
{
    /* This is used if database provider does't define
     * ILoginPageDemoDbSchemaMigrator implementation.
     */
    public class NullLoginPageDemoDbSchemaMigrator : ILoginPageDemoDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}