using ProjectManagement.Application.Commands;
using ProjectManagement.Application.DTO;
using ProjectManagement.Domain.Enums;
using ProjectManagement.Domain.Interfaces;
using ProjectManagement.Domain.Models;
using ProjectManagement.Domain.ValueObjects;

namespace ProjectManagement.Application.Handlers;

public class CreateEmployeeHandler
{
    private readonly IEmployeeRepository _employeeRepository;

    public CreateEmployeeHandler (IEmployeeRepository employeeRepository)
    {
        _employeeRepository = employeeRepository;
    }

    public async Task<EmployeeResult> Handle(CreateEmployeeCommand command)
    {
        Name employeeName = Name.Create(command.EmployeeName!);
        Email employeeEmail = Email.Create(command.EmployeeEmail!);
        WorkPass employeeWorkPass = WorkPass.Create(command.EmployeeWorkPass!);
        EmployeeRole employeeRole = Enum.Parse<EmployeeRole>(command.EmployeeRole!);

        //if(await _employeeRepository.ExistsByWorkPass(employeeWorkPass)) return EmployeeResult.Fail("WORKPASS_ALREADY_TAKEN","Данный WorkPass уже занят другим сотрудником");

        var employee = new Employee(command.EmployeeId, employeeName, employeeEmail, employeeWorkPass, employeeRole);

        await _employeeRepository.Add(employee);

        return EmployeeResult.Success(employee.Id);
    }
}