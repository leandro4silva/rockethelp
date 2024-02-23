using RocketHelp.Application.Interfaces;
using RocketHelp.Application.Interfaces.Cryptography;
using RocketHelp.Domain.Repository;
using RocketHelp.Domain.Utils;
using DomainEntity = RocketHelp.Domain.Entity;
using Enums = RocketHelp.Domain.Enum;


namespace RocketHelp.Application.UserCases.User.CreateUser;

public class CreateUser : ICreateUser
{
    private readonly IUserRepository _userRepository;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IHashingService _bcryptHasher;


    public CreateUser(
        IUserRepository userRepository, 
        IUnitOfWork unitOfWork,
        IHashingService bcryptHasher
    )
    {
        _userRepository = userRepository;
        _unitOfWork = unitOfWork;
        _bcryptHasher = bcryptHasher;
    }

    public async Task<CreateUserOutput> Handle(
        CreateUserInput input, 
        CancellationToken cancellationToken
    )
    {
        var hashedPassword = _bcryptHasher.Hash(input.Password);

        var user = new DomainEntity.User(
            input.Username, 
            input.Email,
            hashedPassword,
            Enums.Role.Employee.GetDescription(),
            true
        );

        await _userRepository.Insert(user, cancellationToken);
        await _unitOfWork.Commit(cancellationToken);

        return CreateUserOutput.FromUser(user);
    }
}
