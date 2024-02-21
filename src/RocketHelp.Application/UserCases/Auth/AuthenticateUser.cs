using RocketHelp.Application.Exceptions;
using RocketHelp.Application.Interfaces;
using RocketHelp.Application.Interfaces.Cryptography;
using RocketHelp.Application.UserCases.Auth;
using RocketHelp.Domain.Repository;

namespace RocketHelp.Application.UserCases.User;

public class AuthenticateUser : IAuthenticateUser
{
    private readonly IUserRepository _userRepository;
    private readonly IUnitOfWork _unitOfWork;
    private readonly ITokenService _tokenService;
    private readonly IHashCompare _hashCompare;

    public AuthenticateUser(
        IUserRepository userRepository, 
        ITokenService tokenService, 
        IUnitOfWork unitOfWork,
        IHashCompare hashCompare
    )
    {
        _userRepository = userRepository;
        _unitOfWork = unitOfWork;
        _tokenService = tokenService;
        _hashCompare = hashCompare;
    }

    public async Task<AuthenticateUserOutput> Handle(
        AuthenticateUserInput input, 
        CancellationToken cancellationToken
    )
    {
        var user = await _userRepository.GetByEmail(input.Email, cancellationToken);
        
        WrongCredentialsException.ThrowIfNull(user, "Credentials are not valid");

        var comparePassword = _hashCompare.Compare(input.Password,user.Password);

        WrongCredentialsException.ThrowIfFalse(comparePassword, "Credentials are not valid");

        var token = _tokenService.GenerateToken(user, cancellationToken);

        return new AuthenticateUserOutput(user.Email, token);
    }
}
