using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Migraciones_Trasporte.src.Modules.Type_Documents.Infrastructure.Entity;

public class TypeDocumentsEntityConfiguration : IEntityTypeConfiguration<TypeDocumentsEntity>
{
    public void Configure(EntityTypeBuilder<TypeDocumentsEntity> builder)
        {
            builder.ToTable("type_documents");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .HasColumnName("id")
                .IsRequired();

            builder.Property(x => x.Name)
                .HasColumnName("name")
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(x => x.Category)
                .HasColumnName("Category")
                .IsRequired();

            builder.HasOne(x => x.DocumentCategory)
                .WithMany()
                .HasForeignKey(x => x.Category)
                .OnDelete(DeleteBehavior.Restrict);
        }
}
