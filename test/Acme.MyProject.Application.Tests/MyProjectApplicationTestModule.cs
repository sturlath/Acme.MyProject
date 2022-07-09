using Volo.Abp.Modularity;

namespace Acme.MyProject;

[DependsOn(
    typeof(MyProjectApplicationModule),
    typeof(MyProjectDomainTestModule)
    )]
public class MyProjectApplicationTestModule : AbpModule
{

}
