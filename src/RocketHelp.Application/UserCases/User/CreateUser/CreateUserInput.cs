using MediatR;
using RocketHelp.Application.UserCases.User.AuthenticateUser;
using RocketHelp.Domain.Enum;

namespace RocketHelp.Application.UserCases.User.CreateUser;

public class CreateUserInput : IRequest<CreateUserOutput>
{
    public string Username { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public Role Role { get; set; }
    public bool IsActive { get; set; }


    public CreateUserInput(string username, string email, string password, Role role, bool isActive)
    {
        Username = username;
        Email = email;
        Password = password;
        Role = role;
        IsActive = isActive;
    }
}
