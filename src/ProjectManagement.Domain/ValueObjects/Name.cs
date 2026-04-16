using ProjectManagement.Domain.Exceptions;

namespace ProjectManagement.Domain.ValueObjects;

public record Name
{
    private const int MAX_LENGTH_NAME = 100;
    public string Value { get; }
    private Name(string value) => Value=value;
    public static Name Create(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            throw new InvalidEntityStateException("Name","Name cannot be empty");
        }
        if (value.Any(char.IsDigit))
        {
            throw new InvalidEntityStateException(nameof(Name), $"{nameof(Name)} cannot contain digit");
        }
        if (value.Length>MAX_LENGTH_NAME)
        {
            throw new InvalidEntityStateException(nameof(Name),$"{nameof(Name)} cannot be more than {MAX_LENGTH_NAME}");
        }
        return new Name(value);
    }
    public override string ToString() => Value;
}