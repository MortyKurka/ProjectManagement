using ProjectManagement.Domain.Models;
using ProjectManagement.Domain.ValueObjects;
using ProjectManagement.Domain.Enums;

namespace ProjectManagement.Domain.Tests;

public class EmployeeConstructorTests
{
    [Theory]
    [InlineData(5,"Алексей","aleksei@gmail.com","ABCD",EmployeeRole.DevOps)]
    [InlineData(4,"Мария","MariAA@YANDEX.RU","ABDC",EmployeeRole.Lead)]
    public void Constructor_ValidData_CreateEmployeeWithCorrectState(int id, string nameValue, string emailValue, string workPassValue, EmployeeRole role)
    {
        var name = Name.Create(nameValue);
        var email = Email.Create(emailValue);
        var workPass = WorkPass.Create(workPassValue);

        var employee = new Employee(id,name, email, workPass, role);

        Assert.Equal(id, employee.Id);
        Assert.Equal(nameValue, employee.Name.Value);
        Assert.Equal(emailValue, employee.Email.Value);
        Assert.Equal(workPassValue, employee.WorkPass.Value);
        Assert.Equal(role, employee.Role);
    }

    [Theory]
    [InlineData(0)]
    [InlineData(-1)]
    [InlineData(-15)]
    [InlineData(-10000)]
    public void Constructor_InvalidId_ThrowsArgumentException(int invalidId)
    {
        var ex = Assert.Throws<ArgumentException>(() => new Employee(invalidId, Name.Create("Работник"),Email.Create("rabotnik@mail.com"),WorkPass.Create("ADBC"),EmployeeRole.Developer));
        Assert.Equal("id",ex.ParamName);
    }
}
