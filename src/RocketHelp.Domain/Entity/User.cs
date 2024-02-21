using RocketHelp.Domain.Enum;

namespace RocketHelp.Domain.Entity;

public class User : SeedWork.Entity
{
    public string Username { get; private set; }
    public string Email { get; private set; }
    public string Password { get; private set; }
    public Role Role { get; private set; }
    public bool IsActive { get; private set; }
    public DateTime CreatedAt { get; private set; }
    public DateTime UpdatedAt { get; private set; }


    public User(string username, string email, string password, Role role, bool isActive = true) : base()
    {
        Username = username;
        Email = email;
        Password = password;
        Role = role;
        IsActive = isActive;
    }


    public void Update(string email, string? username = null, string? password = null)
    {
        Email = email;
        Username = username ?? Username;
        Password = password ?? Password;
    }

}
