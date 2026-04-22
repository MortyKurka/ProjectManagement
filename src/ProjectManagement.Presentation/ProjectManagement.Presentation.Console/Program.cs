using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using ProjectManagement.Application.Handlers;
using ProjectManagement.Domain.Interfaces;
using ProjectManagement.Infrastructure.Data;
using ProjectManagement.Infrastructure.Repository;

namespace ProjectManagement.Presentation.Console;

class Program
{
    static async Task Main(string[] args)
    {
        var services = new ServiceCollection();

        services.AddDbContext<ProjectManagementContext>();
        services.AddScoped<IEmployeeRepository, EmployeeRepository>();
        services.AddScoped<CreateEmployeeHandler>();
        services.AddScoped<App>();

        var serviceProvider = services.BuildServiceProvider();

        var app = serviceProvider.GetRequiredService<App>();
        await app.RunAsync();
    }
}