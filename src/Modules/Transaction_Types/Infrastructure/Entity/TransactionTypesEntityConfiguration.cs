using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace Migraciones_Trasporte.src.Modules.Transaction_Types.Infrastructure.Entity;

public class TransactionTypesEntityConfiguration : IEntityTypeConfiguration<TransactionTypesEntity>

{
    public void Configure(EntityTypeBuilder<TransactionTypesEntity> builder)
    {
        builder.ToTable("transaction_types");

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
