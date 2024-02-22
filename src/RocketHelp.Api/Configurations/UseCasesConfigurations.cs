using RocketHelp.Application.Interfaces;
using RocketHelp.Application.Interfaces.Cryptography;
using RocketHelp.Application.UserCases.User.CreateUser;
using RocketHelp.Domain.Repository;
using RocketHelp.Infra.Cryptography;
using RocketHelp.Infra.Repositories;
using RocketHelp.Infra.Services;
using RocketHelp.Infra.UnitOfWork;

namespace RocketHelp.Api.Configurations;

public static class UseCasesConfigurations
{
    public static IServiceCollection AddUseCases(this IServiceCollection services)
    {
        services.AddMediatR(config =>
            config.RegisterServicesFromAssemblies(typeof(CreateUser).Assembly)
        );

        services.AddRepository();
        return services;
    }

    private static IServiceCollection AddRepository(this IServiceCollection services)
    {
        services.AddTransient<IUserRepository, UserRepository>();
        services.AddTransient<IUnitOfWork, UnitOfWork>();
        services.AddTransient<ITokenService, TokenService>();
        services.AddTransient<IHashingService, BcryptHasher>();

        return services;
    }
}
