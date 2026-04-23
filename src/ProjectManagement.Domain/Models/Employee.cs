using ProjectManagement.Domain.Enums;
using ProjectManagement.Domain.ValueObjects;
using ProjectManagement.Domain.Exceptions;

namespace ProjectManagement.Domain.Models;

/// <summary>
/// Представляет сотрудника в системе управления проектами.
/// </summary>
public class Employee
{
    /// <summary>
    /// Уникальный идентификатор сотрудника
    /// </summary>
    public int Id { get; private set; }
    /// <summary>
    /// Адрес электронной почты сотрудника
    /// </summary>
    /// <example>
    /// alekseev@example.ru
    /// </example>
    public Email Email { get; private set; }
    /// <summary>
    /// Имя сотрудника
    /// </summary>
    /// <example>
    /// Алексеев Алексей Алексеевич
    /// </example>
    public Name Name { get; private set; }
    /// <summary>
    /// Рабочий пропуск сотрудника
    /// </summary>
    /// <remarks>
    /// Одновременно не может быть 2 одинаковых пропусков,
    /// но позже пропуск может бысть присвоен ранее уволенному сотруднику
    /// </remarks>
    /// <example>
    /// "A2C-3G9-G7H"
    /// </example>
    public WorkPass WorkPass { get; private set; }
    /// <summary>
    /// Должность сотрудника в компании
    /// </summary>
    /// <example>
    /// DevOps
    /// </example>
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