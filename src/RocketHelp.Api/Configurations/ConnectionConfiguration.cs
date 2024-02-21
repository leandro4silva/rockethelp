using Microsoft.EntityFrameworkCore;
using RocketHelp.Infra;

namespace RocketHelp.Api.Configurations;

public static class ConnectionConfiguration
{
    public static IServiceCollection AddAppConnections(
        this IServiceCollection services,
        IConfiguration configuration
    )
    {
        services.AddDbConnection(configuration);
        return services;
    }


    private static IServiceCollection AddDbConnection(
        this IServiceCollection services,
        IConfiguration configuration
    )
    {
        var connectionString = configuration.GetConnectionString("RocketHelpDb");
        services.AddDbContext<RocketHelpDbContext>(
            options => options.UseMySql(
                connectionString,
                ServerVersion.AutoDetect(connectionString)
            )
        );
        return services;
    }
}
