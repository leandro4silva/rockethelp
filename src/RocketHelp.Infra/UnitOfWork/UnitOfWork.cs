
using RocketHelp.Application.Interfaces;

namespace RocketHelp.Infra.UnitOfWork;

public class UnitOfWork : IUnitOfWork
{
    private readonly RocketHelpDbContext _context;

    public UnitOfWork(RocketHelpDbContext context)
    {
        _context = context;
    }

    public async Task Commit(CancellationToken cancellationToken)
    {
        await _context.SaveChangesAsync(cancellationToken);
    }

    public Task Rollback(CancellationToken cancellationToken)
    {
        return Task.CompletedTask;
    }
}
