using RocketHelp.Application.Interfaces;
using RocketHelp.Domain.Repository;
using RocketHelp.Infra.Repositories;
using RocketHelp.Infra.UnitOfWork;

namespace RocketHelp.Api.Configurations;

public static class UseCasesConfigurations
{
    public static IServiceCollection AddUseCases(this IServiceCollection services)
    {
        services.AddMediatR(config =>
            config.RegisterServicesFromAssemblies()
        );

        services.AddRepository();
        return services;
    }

    private static IServiceCollection AddRepository(this IServiceCollection services)
    {
        services.AddTransient<IUserRepository, UserRepository>();
        services.AddTransient<IUnitOfWork, UnitOfWork>();

        return services;
    }
}
