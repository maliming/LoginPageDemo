using System.Threading.Tasks;

namespace LoginPageDemo.Data
{
    public interface ILoginPageDemoDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
