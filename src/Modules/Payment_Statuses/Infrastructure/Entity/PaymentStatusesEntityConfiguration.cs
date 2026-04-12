using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Migraciones_Trasporte.src.Modules.Payment_Statuses.Infrastructure.Entity;

public class PaymentStatusesEntityConfiguration : IEntityTypeConfiguration<PaymentStatusesEntity>
{
    public void Configure(EntityTypeBuilder<PaymentStatusesEntity> builder)
    {
        builder.ToTable("payment_statuses");

        builder.HasKey(x => x.Id);

        builder.Property(x => x.Id)
            .HasColumnName("id")
            .HasMaxLength(64)
            .IsRequired();

        builder.Property(x => x.Name)
            .HasColumnName("name")
            .HasMaxLength(50)
            .IsRequired();
    }
}
