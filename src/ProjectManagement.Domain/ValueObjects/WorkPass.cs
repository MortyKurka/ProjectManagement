using ProjectManagement.Domain.Exceptions;

namespace ProjectManagement.Domain.ValueObjects;

public record WorkPass
{
    public string Value;
    private WorkPass(string value) => Value = value;
    public static WorkPass Create(string value)
    {
        if (string.IsNullOrWhiteSpace(value)) 
        {
            throw new InvalidEntityStateException(nameof(WorkPass),$"{nameof(WorkPass)} cannot be empty");
        }
        return new WorkPass(value);
    }    
    public override string ToString() => Value;
}