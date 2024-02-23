using MediatR;


namespace RocketHelp.Application.UserCases.User.CreateUser;

public class CreateUserInput : IRequest<CreateUserOutput>
{
    public string Username { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }


    public CreateUserInput(string username, string email, string password)
    {
        Username = username;
        Email = email;
        Password = password;
    }
}
