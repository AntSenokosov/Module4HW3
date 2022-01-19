using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Module4HW3.Entities;

namespace Module4HW3.EntityConfigurations;

public class OfficeConfiguration : IEntityTypeConfiguration<Office>
{
    public void Configure(EntityTypeBuilder<Office> builder)
    {
        builder.ToTable("Office").HasKey(o => o.Id);
        builder.Property(o => o.Id).HasColumnName("OfficeId").ValueGeneratedOnAdd();
        builder.Property(o => o.Title).IsRequired().HasColumnName("Title").HasMaxLength(100);
        builder.Property(o => o.Location).IsRequired().HasColumnName("Location").HasMaxLength(100);
    }
}