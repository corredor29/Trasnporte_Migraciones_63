using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace Migraciones_Trasporte.src.Modules.Assignment_Role.Infrastructure.Entity;

public class AssignmentRoleEntityConfiguration : IEntityTypeConfiguration<AssignmentRoleEntity>
{
    public void Configure(EntityTypeBuilder<AssignmentRoleEntity> builder)
    {
        builder.ToTable("assignment_role");

        builder.HasKey(x => x.Id);

        builder.Property(x => x.Id)
            .HasColumnName("id")
            .HasMaxLength(64)
            .IsRequired();

        builder.Property(x => x.Name)
            .HasColumnName("name")
            .HasMaxLength(50)
            .IsRequired();
        builder.Property(x => x.Description)
            .HasColumnName("description")
            .HasMaxLength(50)
            .IsRequired();
    }
}
