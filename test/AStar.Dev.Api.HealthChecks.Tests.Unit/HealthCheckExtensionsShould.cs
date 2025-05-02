using JetBrains.Annotations;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Diagnostics.HealthChecks;

namespace AStar.Dev.Api.HealthChecks;

[TestSubject(typeof(HealthCheckExtensions))]
public class HealthCheckExtensionsShould
{
    [Fact]
    public void ConfigureTheHealthCheckEndpoints()
    {
        var webApplication = WebApplication.CreateBuilder();
        webApplication.Services.AddHealthChecks();

        var sut =  webApplication.Build().ConfigureHealthCheckEndpoints();

        sut.Services.GetServices< HealthCheckService>().Count().ShouldBe(1);
    }
}
