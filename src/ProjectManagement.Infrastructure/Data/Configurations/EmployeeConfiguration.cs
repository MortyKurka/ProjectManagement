using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjectManagement.Infrastructure.Data.Entities;

namespace ProjectManagement.Infrastructure.Data.Configurations;

public class EmployeeConfiguration : IEntityTypeConfiguration<EmployeeEntity>
{
    public void Configure(EntityTypeBuilder<EmployeeEntity> builder)
    {
        // Первичный ключ
        builder.HasKey(e => e.Id);

        // Простые колонки
        builder.Property(e => e.Id)
               .ValueGeneratedOnAdd()
               .HasColumnName("EmployeeId");

        builder.Property(e => e.Name)
               .IsRequired()
               .HasColumnName("Name")
               .HasMaxLength(50);
        
        builder.Property(e => e.Email)
               .IsRequired()
               .HasMaxLength(100)
               .HasColumnName("Email");

        builder.Property(e => e.WorkPass)
               .IsRequired()
               .HasMaxLength(10)
               .HasColumnName("WorkPass");

        builder.Property(e => e.Role)
               .HasConversion<string>()
               .IsRequired()
               .HasColumnName("Role")
               .HasMaxLength(20);
        
    }
}