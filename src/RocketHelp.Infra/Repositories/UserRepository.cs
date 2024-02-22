using Microsoft.EntityFrameworkCore;
using RocketHelp.Domain.Entity;
using RocketHelp.Domain.Repository;

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
        var user = await _context.User.AsNoTracking()
            .FirstOrDefaultAsync(
                x => x.Email == email,
                cancellationToken
            );

        return user!;
  }

    public async Task Insert(User user, CancellationToken cancellationToken)
    {
        await _context.AddAsync(user, cancellationToken);
    }
}