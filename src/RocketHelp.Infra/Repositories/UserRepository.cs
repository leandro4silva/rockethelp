using RocketHelp.Domain.Entity;
using RocketHelp.Domain.Repository;
using RocketHelp.Application.Exceptions;

namespace RocketHelp.Infra.Repositories;

public class UserRepository : IUserRepository
{
  private readonly RocketHelpDbContext _context;

  public UserRepository(RocketHelpDbContext context)
  {
    _context = context;
  }

  public async Task<User> GetByEmail(string email, CancellationToken cancellationToken)
  {
    var user = await _context.User.AsNoTracking().FirstOrDefaultAsync(
        x => x.Email == email,
        cancellationToken
    );

    return user!;
  }

}