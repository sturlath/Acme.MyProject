using System.Threading.Tasks;

namespace Acme.MyProject.Data;

public interface IMyProjectDbSchemaMigrator
{
    Task MigrateAsync();
}
