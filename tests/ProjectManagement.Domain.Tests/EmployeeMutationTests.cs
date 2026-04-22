using ProjectManagement.Domain.Models;
using ProjectManagement.Domain.ValueObjects;
using ProjectManagement.Domain.Enums;

namespace ProjectManagement.Domain.Tests;

public class EmployeeMutationTests
{
    [Theory]
    [InlineData(1)]
    [InlineData(2000000000)]
    public void MarkAsHired_ValidData_ChangeCorrectState(int projectId)
    {
        var employee = new Employee(Name.Create("Алексей"),Email.Create("aleksei@mail.ru"),WorkPass.Create("ADC"),EmployeeRole.Developer);
        employee.MarkAsHired(projectId);
    }
}