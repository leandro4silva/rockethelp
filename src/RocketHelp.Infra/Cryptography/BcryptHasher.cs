using RocketHelp.Application.Interfaces.Cryptography;

namespace RocketHelp.Infra.Cryptography;

public class BcryptHasher : IHashingService
{
    public bool Compare(string plain, string hash)
    {
        return BCrypt.Net.BCrypt.Verify(plain, hash);
    }

    public string Hash(string plain)
    {
        return BCrypt.Net.BCrypt.HashPassword(plain);
    }
}
