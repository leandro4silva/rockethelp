using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RocketHelp.Domain.Entity;

namespace RocketHelp.Infra.Configurations;

internal class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.HasKey(user => user.Id);
        builder.Property(user => user.Username).HasMaxLength(128);
        builder.Property(user => user.Password).HasMaxLength(255);
        builder.Property(user => user.Email).HasMaxLength(255);
    }
}
