using Acme.MyProject.Localization;
using Volo.Abp.Application.Services;

namespace Acme.MyProject;

/* Inherit your application services from this class.
 */
public abstract class MyProjectAppService : ApplicationService
{
    protected MyProjectAppService()
    {
        LocalizationResource = typeof(MyProjectResource);
    }
}
