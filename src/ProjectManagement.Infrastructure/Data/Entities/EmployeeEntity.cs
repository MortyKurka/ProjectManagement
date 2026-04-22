using ProjectManagement.Domain.ValueObjects;
using ProjectManagement.Domain.Enums;

namespace ProjectManagement.Infrastructure.Data.Entities;

public class EmployeeEntity
{
    //Первичный ключ
    public int Id { get; set; }
    //Внешний ключ
    public int ProjectId { get; set; }
    //Навигационное свойство 
    //public ProjectEntity Project { get; set; }

    //Простые свойства
    public string Name { get; set; } = string.Empty;
    public string WorkPass { get; set; } = string.Empty;
    public EmployeeRole Role { get; set; }
    public string Email { get; set; } = string.Empty;
}