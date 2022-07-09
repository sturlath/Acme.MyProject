using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace Acme.MyProject;

public class MyProjectWebTestStartup
{
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddApplication<MyProjectWebTestModule>();
    }

    public void Configure(IApplicationBuilder app, ILoggerFactory loggerFactory)
    {
        app.InitializeApplication();
    }
}
