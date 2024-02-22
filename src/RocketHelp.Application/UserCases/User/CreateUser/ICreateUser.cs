using MediatR;

namespace RocketHelp.Application.UserCases.User.CreateUser;

public interface ICreateUser 
    : IRequestHandler<CreateUserInput, CreateUserOutput>
{ }
