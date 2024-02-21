namespace RocketHelp.Application.Interfaces.Cryptography;


public interface IHashCompare
{
    public bool Compare(string plain, string hash);
}
