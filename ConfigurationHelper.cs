using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Hosting.Internal;


namespace DataAccess;

public static class ConfigurationHelper
{
    private static readonly IHostEnvironment HostEnvironment = new HostingEnvironment();
    public static IConfigurationRoot GetConfiguration()
    {
        var strEnv = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");
        var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile($"appsettings.{strEnv}.json", optional: true, reloadOnChange: true);

        return builder.Build();
    }
}
