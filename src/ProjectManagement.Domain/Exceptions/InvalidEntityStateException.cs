namespace ProjectManagement.Domain.Exceptions;

public class InvalidEntityStateException : DomainException
{
    public InvalidEntityStateException(string entityName, string reason)
    : base ($"Is {entityName} not valid: {reason}", "INVALID_STATE") { }
}