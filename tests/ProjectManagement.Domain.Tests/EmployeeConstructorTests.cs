using ProjectManagement.Domain.Models;
using ProjectManagement.Domain.ValueObjects;
using ProjectManagement.Domain.Enums;

namespace ProjectManagement.Domain.Tests;

public class EmployeeConstructorTests
{
    [Theory]
    [InlineData("Алексей","aleksei@gmail.com","ABCD",EmployeeRole.DevOps)]
    [InlineData("Мария","MariAA@YANDEX.RU","ABDC",EmployeeRole.Lead)]
    public void Constructor_ValidData_CreateEmployeeWithCorrectState( string nameValue, string emailValue, string workPassValue, EmployeeRole role)
    {
        var name = Name.Create(nameValue);
        var email = Email.Create(emailValue);
        var workPass = WorkPass.Create(workPassValue);

        var employee = new Employee(name, email, workPass, role);

        Assert.Equal(nameValue, employee.Name.Value);
        Assert.Equal(emailValue, employee.Email.Value);
        Assert.Equal(workPassValue, employee.WorkPass.Value);
        Assert.Equal(role, employee.Role);
    }

}
