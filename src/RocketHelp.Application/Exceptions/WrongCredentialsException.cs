namespace RocketHelp.Application.Exceptions;


public class WrongCredentialsException : ApplicationException
{
    public WrongCredentialsException(string? message) : base(message)
    {
    }

    public static void ThrowIfNull(object? @object, string exceptionMessage)
    {
        if (@object == null)
        {
            throw new NotFoundException(exceptionMessage);
        }
    }

    public static void ThrowIfFalse(object? @object, string exceptionMessage)
    {
        if (@object == null)
        {
            throw new NotFoundException(exceptionMessage);
        }
    }
}
