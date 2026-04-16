using System.Reflection.Metadata;
using ProjectManagement.Domain.Models;

public interface IEmployeeRepository
{
    Task<Employee> GetById(int id);
    Task<IEnumerable<Employee>> GetAll();
    Task<IEnumerable<Employee>> GetByProjectId();

    Task Add(Employee employee);
    Task Update(Employee employee);
    Task Delete(int id);
}