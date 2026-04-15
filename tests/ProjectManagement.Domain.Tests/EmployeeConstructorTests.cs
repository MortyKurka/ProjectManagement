using ProjectManagement.Domain.Models;
using ProjectManagement.Domain.ValueObjects;
using ProjectManagement.Domain.Enums;

namespace ProjectManagement.Domain.Tests;

public class EmployeeConstructorTests
{
    [Theory]
    [InlineData("Алексей","aleksei@gmail.com","ABCD",EmployeeRole.DevOps,13)]
    [InlineData("Мария","MariAA@YANDEX.RU","ABDC",EmployeeRole.Lead,5)]
    public void Constructor_ValidData_CreateEmployeeWithCorrectState(string nameValue, string emailValue, string workPassValue, EmployeeRole role, int projectId)
    {
        var name = Name.Create(nameValue);
        var email = Email.Create(emailValue);
        var workPass = WorkPass.Create(workPassValue);

        var employee = new Employee(name, email, workPass, role, projectId);

        Assert.Equal(nameValue, employee.Name.Value);
        Assert.Equal(emailValue, employee.Email.Value);
        Assert.Equal(workPassValue, employee.WorkPass.Value);
        Assert.Equal(role, employee.Role);
        Assert.Equal(projectId, employee.ProjectId);
    }

    [Theory]
    [InlineData(0)]
    [InlineData(-1)]
    [InlineData(-15)]
    [InlineData(-10000)]
    public void Constructor_ValidData_ThrowsArgumentException(int invalidProjectId)
    {
        var ex = Assert.Throws<ArgumentException>(() => new Employee(Name.Create("Работник"),Email.Create("rabotnik@mail.com"),WorkPass.Create("ADBC"),EmployeeRole.Developer, invalidProjectId));
    }
}
