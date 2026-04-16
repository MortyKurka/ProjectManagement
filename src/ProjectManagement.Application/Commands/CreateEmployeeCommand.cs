namespace ProjectManagement.Application.Commands;


public class CreateEmployeeCommand
{
    public int EmployeeId { get; set; }
    public string? EmployeeName;
    public string? EmployeeEmail;
    public string? EmployeeWorkPass;
    public string? EmployeeRole;
}
