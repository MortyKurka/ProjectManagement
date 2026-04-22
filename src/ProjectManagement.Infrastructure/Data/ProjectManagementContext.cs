using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using ProjectManagement.Infrastructure.Data.Configurations;
using ProjectManagement.Infrastructure.Data.Entities;

namespace ProjectManagement.Infrastructure.Data;

public class ProjectManagementContext : DbContext
{
    public DbSet<EmployeeEntity> Employees { get; set; }
    public ProjectManagementContext(DbContextOptions<ProjectManagementContext> options) 
        : base(options) 
    { }
    public ProjectManagementContext() {}
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var config = new ConfigurationBuilder()
                         .AddJsonFile("appsettings.json")
                         .SetBasePath(Directory.GetCurrentDirectory())
                         .Build();
        optionsBuilder.UseNpgsql(config.GetConnectionString("DefaultConnection"));
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new EmployeeConfiguration());
    }
}