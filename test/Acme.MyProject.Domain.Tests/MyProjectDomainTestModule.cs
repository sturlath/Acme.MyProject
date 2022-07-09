using Acme.MyProject.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Acme.MyProject;

[DependsOn(
    typeof(MyProjectEntityFrameworkCoreTestModule)
    )]
public class MyProjectDomainTestModule : AbpModule
{

}
