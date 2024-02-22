using MediatR;

namespace RocketHelp.Application.UserCases.User.AuthenticateUser;

public interface IAuthenticateUser
    : IRequestHandler<AuthenticateUserInput, AuthenticateUserOutput>
{ }
