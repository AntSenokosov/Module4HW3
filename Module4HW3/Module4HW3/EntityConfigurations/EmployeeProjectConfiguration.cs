using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Module4HW3.Entities;

namespace Module4HW3.EntityConfigurations;

public class EmployeeProjectConfiguration : IEntityTypeConfiguration<EmployeeProject>
{
    public void Configure(EntityTypeBuilder<EmployeeProject> builder)
    {
        builder.HasKey(e => e.Id);
        builder.Property(e => e.Id).HasColumnName("EmployeeProjectId").ValueGeneratedOnAdd();
        builder.Property(e => e.Rate).IsRequired().HasColumnName("Rate");
        builder.Property(e => e.StartedDate).HasColumnName("StartedDate").HasMaxLength(7);
        builder.HasOne(e => e.Employee)
            .WithMany(o => o.EmployeeProjects)
            .HasForeignKey(h => h.EmployeeId);
        builder.HasOne(e => e.Project)
            .WithMany(p => p.EmployeeProjects)
            .HasForeignKey(h => h.ProjectId);
    }
}