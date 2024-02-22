using RocketHelp.Domain.Entity;
using RocketHelp.Domain.SeedWork;


namespace RocketHelp.Domain.Repository;

public interface IUserRepository : IRepository
{
    public Task<User> GetByEmail(string email, CancellationToken cancellationToken);
    public Task Insert(User user, CancellationToken cancellationToken);

}
