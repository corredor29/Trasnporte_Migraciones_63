using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Migraciones_Trasporte.src.Modules.Person_Status.Infrastructure.Entity;

public class PersonStatusEntityConfiguration : IEntityTypeConfiguration<PersonStatusEntity>
{
    public void Configure(EntityTypeBuilder<PersonStatusEntity> builder)
    {
        builder.ToTable("person_status");

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
