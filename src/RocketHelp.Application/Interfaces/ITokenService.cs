using RocketHelp.Domain.Entity;

namespace RocketHelp.Application.Interfaces;

public interface ITokenService
{
    public string GenerateToken(User user, CancellationToken cancellationToken);
}
