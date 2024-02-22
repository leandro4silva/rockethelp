using RocketHelp.Application.Exceptions;
using RocketHelp.Application.Interfaces;
using RocketHelp.Application.Interfaces.Cryptography;
using RocketHelp.Domain.Repository;

namespace RocketHelp.Application.UserCases.User.AuthenticateUser;

public class AuthenticateUser : IAuthenticateUser
{
    private readonly IUserRepository _userRepository;
    private readonly ITokenService _tokenService;
    private readonly IHashingService _bcryptHasher;

    public AuthenticateUser(
        IUserRepository userRepository,
        ITokenService tokenService,
        IHashingService bcryptHasher
    )
    {
        _userRepository = userRepository;
        _tokenService = tokenService;
        _bcryptHasher = bcryptHasher;
    }

    public async Task<AuthenticateUserOutput> Handle(
        AuthenticateUserInput input,
        CancellationToken cancellationToken
    )
    {
        var user = await _userRepository.GetByEmail(input.Email, cancellationToken);

        WrongCredentialsException.ThrowIfNull(user, "Credentials are not valid");

        var comparePassword = _bcryptHasher.Compare(input.Password, user.Password);

        WrongCredentialsException.ThrowIfFalse(comparePassword, "Credentials are not valid");

        var token = _tokenService.GenerateToken(user, cancellationToken);

        return new AuthenticateUserOutput(user.Email, token);
    }
}
