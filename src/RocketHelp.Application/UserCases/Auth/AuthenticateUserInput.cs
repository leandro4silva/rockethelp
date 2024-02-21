using MediatR;
using RocketHelp.Application.UserCases.User;

namespace RocketHelp.Application.UserCases.Auth;

public class AuthenticateUserInput : IRequest<AuthenticateUserOutput>
{
    public string Email { get; set; }
    public string Password { get; set; }


    public AuthenticateUserInput(string email, string password)
    {
        Email = email;
        Password = password;
    }
}
