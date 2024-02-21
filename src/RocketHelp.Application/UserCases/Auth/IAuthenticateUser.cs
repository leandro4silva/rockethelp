using MediatR;
using RocketHelp.Application.UserCases.Auth;

namespace RocketHelp.Application.UserCases.User;

public interface IAuthenticateUser 
    : IRequestHandler<AuthenticateUserInput, AuthenticateUserOutput> { }
