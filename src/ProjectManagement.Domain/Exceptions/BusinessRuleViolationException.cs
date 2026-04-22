namespace ProjectManagement.Domain.Exceptions;

/// <summary>
/// Исключение, которое выбрасывается, когда нарушаются бизнес правила в Domain-слое
/// </summary>
public class BusinessRuleViolationException : DomainException
{
    /// <summary>
    /// Инициализирует новый экземпляр исключения с сообщением и кодом ошибки
    /// </summary>
    /// <param name="message">Сообщение ошибки</param>
    /// <param name="errorCode">Код ошибки</param>
    public BusinessRuleViolationException(string message, string? errorCode=null)
    : base (message, errorCode) { }
}