using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Migraciones_Trasporte.src.Modules.Payment_Providers.Infrastructure.Entity;

public class PaymentProviderEntityConfiguration : IEntityTypeConfiguration<PaymentProvidersEntity>
{
    public void Configure(EntityTypeBuilder<PaymentProvidersEntity> builder)
    {
        builder.ToTable("payment_providers");

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
