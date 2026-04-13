using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Migraciones_Trasporte.src.Modules.Reason_Disputes.Infrastructure.Entity;

public class ReasonDisputesEntityConfiguration : IEntityTypeConfiguration<ReasonDisputesEntity>

{
    public void Configure(EntityTypeBuilder<ReasonDisputesEntity> builder)
    {
        builder.ToTable("reason_disputes");

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
