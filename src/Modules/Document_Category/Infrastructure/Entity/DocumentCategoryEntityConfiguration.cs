using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Migraciones_Trasporte.src.Modules.Document_Category.Infrastructure.Entity;

public class DocumentCategoryEntityConfiguration : IEntityTypeConfiguration<DocumentCategoryEntity>
{
    public void Configure(EntityTypeBuilder<DocumentCategoryEntity> builder)
    {
        builder.ToTable("document_category");

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
