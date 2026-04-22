using ProjectManagement.Domain.Models;

namespace ProjectManagement.Domain.Interfaces;

/// <summary>
/// Определяет контракт для репозитория работы с сотрудниками.
/// </summary>
/// <remarks>
/// Репозиторий предоставляет методы для доступа к данным сотрудника,
/// скрывая детали реализации (EF Core)
/// </remarks>
public interface IEmployeeRepository
{
    /// <summary>
    /// Добавляет нового сотрудника в репозиторий.
    /// </summary>
    /// <param name="employee">Добавляемый сотрудник.</param>
    /// <returns>Задача, представляющая асинхронную операцию.</returns>
    Task Add(Employee employee);

}