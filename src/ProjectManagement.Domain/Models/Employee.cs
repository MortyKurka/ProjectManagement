using ProjectManagement.Domain.Enums;
using ProjectManagement.Domain.ValueObjects;
using ProjectManagement.Domain.Exceptions;

namespace ProjectManagement.Domain.Models;

public class Employee
{
    public int Id { get; private set; }
    public Email Email { get; private set; }
    public Name Name { get; private set; }
    public WorkPass WorkPass { get; private set; }
    public EmployeeRole Role { get; private set; }
    public int ProjectId { get; private set; }
    public bool IsHired { get; private set; }
    private int _idCounter = 0;

    public Employee(Name name, Email email, WorkPass workPass, EmployeeRole role)
    {
        Id = ++_idCounter;
        Name = name;
        Email = email;
        WorkPass = workPass;
        Role = role;
        IsHired = false;
    }

    public void MarkAsHired(int projectId)
    {
        if (IsHired) throw new BusinessRuleViolationException("Работник уже работает");
        if (projectId <= 0) throw new DomainException("Id проекта должен быть положительным");
        IsHired = true;
        ProjectId = projectId;
    }

    public void MarkAsFree()
    {
        if (!IsHired) throw new BusinessRuleViolationException("Работник уже свободен");
        IsHired = false;
        ProjectId = 0;
    }

    public void UpdateEmail(Email email)
    {
        if (email==Email) throw new BusinessRuleViolationException("Адрес не изменился");
        Email = email;
    }
}