using ProjectManagement.Domain.Interfaces;
using ProjectManagement.Domain.Models;
using ProjectManagement.Infrastructure.Data;
using ProjectManagement.Infrastructure.Data.Entities;

namespace ProjectManagement.Infrastructure.Repository;

public class EmployeeRepository : IEmployeeRepository
{
    private readonly ProjectManagementContext _db;

    public EmployeeRepository(ProjectManagementContext db)
    {
        _db = db;
    }

    public async Task Add(Employee employee)
    {
        var employeeEntity = new EmployeeEntity
        {
            ProjectId = employee.ProjectId,
            Name = employee.Name.ToString(),
            WorkPass = employee.WorkPass.ToString(),
            Email = employee.Email.ToString(),
            Role = employee.Role,
        };
        await _db.AddAsync(employeeEntity);
        await _db.SaveChangesAsync();
    }
}