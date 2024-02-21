using Microsoft.EntityFrameworkCore;
using RocketHelp.Domain.Entity;
using RocketHelp.Infra.Configurations;

namespace RocketHelp.Infra;

public class RocketHelpDbContext : DbContext
{
    public DbSet<User> User => Set<User>();
    
    public RocketHelpDbContext(
        DbContextOptions<RocketHelpDbContext> options
    ) : base(options) { }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.ApplyConfiguration(new UserConfiguration());
    }
}
