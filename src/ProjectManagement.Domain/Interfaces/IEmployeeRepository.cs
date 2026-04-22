using ProjectManagement.Domain.Models;
using ProjectManagement.Domain.ValueObjects;

namespace ProjectManagement.Domain.Interfaces;

public interface IEmployeeRepository
{

    Task Add(Employee employee);

}