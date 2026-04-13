using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Migraciones_Trasporte.src.Modules.Disputes_Status.Infrastructure.Entity;

public class DisputesStatusEntityConfiguration : IEntityTypeConfiguration<DisputesStatusEntity>

{
    public void Configure(EntityTypeBuilder<DisputesStatusEntity> builder)
    {
        builder.ToTable("disputes_status");

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
