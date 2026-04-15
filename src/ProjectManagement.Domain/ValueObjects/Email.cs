using ProjectManagement.Domain.Exceptions;

namespace ProjectManagement.Domain.ValueObjects;

public record Email
{
    public string Value { get; }
    private Email (string value) => Value = value;

    public static Email Create (string value)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            throw new InvalidEntityStateException(nameof(Email),$"{nameof(Email)} cannot be empty");
        }

        if (!value.Contains("@"))
        {
            throw new InvalidEntityStateException(nameof(Email),$"{nameof(Email)} cannot be empty");
        }
        return new Email(value);
    }
    public override string ToString() => Value;
}