public class EmployeeResult
{
    public bool IsSuccess { get; private set; }
    public int? OrderId { get; private set; }
    public string? ErrorCode { get; private set; }
    public string? ErrorMessage { get; private set; }

    private EmployeeResult () {}

    public static EmployeeResult Success(int orderId) =>
        new () {IsSuccess = true, OrderId = orderId};
    
    public static EmployeeResult Fail(string errorCode, string errorMessage) =>
        new () {IsSuccess = false, ErrorCode = errorCode, ErrorMessage = errorMessage };
}