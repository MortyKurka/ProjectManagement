namespace ProjectManagement.Domain.Exceptions;

public class BusinessRuleViolationException : DomainException
{
    public BusinessRuleViolationException(string message, string? errorCode=null)
    : base (message, errorCode) { }
}