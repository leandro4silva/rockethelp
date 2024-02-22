using RocketHelp.Domain.Enum;
using DomainEntity = RocketHelp.Domain.Entity;

namespace RocketHelp.Application.UserCases.User.CreateUser;

public class CreateUserOutput
{
    public Guid Id { get; set; }
    public string Email { get; private set; }
    public string Password { get; private set; }
    public Role Role { get; private set; }
    public bool IsActive { get; private set; }
    public DateTime CreatedAt { get; private set; }
    public DateTime UpdatedAt { get; private set; }

    public CreateUserOutput(
        Guid id,
        string email, 
        string password, 
        Role role, 
        bool isActive, 
        DateTime createdAt, 
        DateTime updatedAt
    )
    {
        Id = id;
        Email = email;
        Password = password;
        Role = role;
        IsActive = isActive;
        CreatedAt = createdAt;
        UpdatedAt = updatedAt;
    }


    public static CreateUserOutput FromUser(DomainEntity.User user)
    {
        return new CreateUserOutput(
            user.Id,
            user.Email,
            user.Password,
            user.Role,
            user.IsActive,
            user.CreatedAt,
            user.UpdatedAt
        );
    }
}
