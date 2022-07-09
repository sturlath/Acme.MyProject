using Acme.MyProject.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Acme.MyProject.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class MyProjectController : AbpControllerBase
{
    protected MyProjectController()
    {
        LocalizationResource = typeof(MyProjectResource);
    }
}
