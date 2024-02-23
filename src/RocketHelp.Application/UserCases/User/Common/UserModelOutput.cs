namespace RocketHelp.Application.UserCases.User.Common;

public class UserModelOutput
{
    public Guid Id { get; set; }
    public string Email { get; private set; }
    public string Password { get; set; }
    public string Role { get; private set; }
    public bool IsActive { get; private set; }
    public DateTime CreatedAt { get; private set; }
    public DateTime UpdatedAt { get; private set; }

    public UserModelOutput(
        Guid id, 
        string email, 
        string password, 
        string role, 
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


 
}
