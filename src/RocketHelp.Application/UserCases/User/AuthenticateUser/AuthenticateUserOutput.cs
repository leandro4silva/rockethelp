namespace RocketHelp.Application.UserCases.User.AuthenticateUser;

public class AuthenticateUserOutput
{
    public string Email { get; set; }
    public string Token { get; set; }

    public AuthenticateUserOutput(string email, string token)
    {
        Email = email;
        Token = token;
    }
}
