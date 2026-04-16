using ProjectManagement.Domain.Models;
using ProjectManagement.Domain.ValueObjects;

namespace ProjectManagement.Domain.Interfaces;

public interface IEmployeeRepository
{
    Task<Employee> GetById(int id);
    Task<IEnumerable<Employee>> GetAll();
    Task<IEnumerable<Employee>> GetByProjectId();
    Task<bool> ExistsByWorkPass(WorkPass workPass);

    Task Add(Employee employee);
    Task Update(Employee employee);
    Task Delete(int id);

    Task SaveChanges();
}