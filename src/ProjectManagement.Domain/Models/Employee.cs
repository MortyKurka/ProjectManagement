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

    public Employee(Name name, Email email, WorkPass workPass, EmployeeRole role, int projectId)
    {
        if (projectId<=0)
        {
            throw new ArgumentException("Id проекта должен быть положительным", nameof(projectId));
        }
        Name = name;
        Email = email;
        WorkPass = workPass;
        Role = role;
        ProjectId = projectId;
        IsHired = false;
    }

    public void MarkAsHired(int projectId)
    {
        if (IsHired) throw new BusinessRuleViolationException("");
    }

    public void MarkAsFree()
    {
        if (!IsHired) throw new BusinessRuleViolationException("");
    }
}