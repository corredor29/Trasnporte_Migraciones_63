using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace Migraciones_Trasporte.src.Modules.Type_Load.Infrastructure.Entity;

public class TypeLoadEntityConfiguration : IEntityTypeConfiguration<TypeLoadEntity>

{
    public void Configure(EntityTypeBuilder<TypeLoadEntity> builder)
    {
        builder.ToTable("type_load");

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
