using RocketHelp.Domain.Utils;
using Enums = RocketHelp.Domain.Enum;


namespace RocketHelp.Domain.Entity;

public class User : SeedWork.Entity
{
    public string Username { get; private set; }
    public string Email { get; private set; }
    public string Password { get; private set; }
    public string Role { get; private set; }
    public bool IsActive { get; private set; }
    public DateTime CreatedAt { get; private set; }
    public DateTime UpdatedAt { get; private set; }


    public User(string username, string email, string password, string? role = null, bool isActive = true) : base()
    {
        Username = username;
        Email = email;
        Password = password;
        Role = Enums.Role.Employee.GetDescription()!;
        IsActive = isActive;
        CreatedAt = DateTime.Now;
        UpdatedAt = DateTime.Now;
    }

    public void Update(string email, string? username = null, string? password = null, string? role = null)
    {
        Email = email;
        Username = username ?? Username;
        Password = password ?? Password;
        Role = role ?? Role;
        UpdatedAt = DateTime.Now;
    }

    public void Activate()
    {
        IsActive = true;
    }

    public void Deactivate()
    {
        IsActive = false;
    }
}
