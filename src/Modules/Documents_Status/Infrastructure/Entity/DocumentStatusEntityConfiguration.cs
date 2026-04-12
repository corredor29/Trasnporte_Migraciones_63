using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Migraciones_Trasporte.src.Modules.Documents_Status.Infrastructure.Entity;

public class DocumentStatusEntityConfiguration : IEntityTypeConfiguration<DocumentStatusEntity>
{
public void Configure(EntityTypeBuilder<DocumentStatusEntity> builder)
    {
        builder.ToTable("document_status");

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
