using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Migraciones_Trasporte.src.Modules.Countries.Infrastructure.Entity;

public class CountriesEntityConfiguration : IEntityTypeConfiguration<CountriesEntity>
{
    public void Configure(EntityTypeBuilder<CountriesEntity> builder)
    {
        builder.ToTable("countries");

        builder.HasKey(x => x.Id);

        builder.Property(x => x.Id)
            .HasColumnName("id")
            .HasMaxLength(64)
            .IsRequired();
        
        builder.Property(x => x.IsoCode)
            .HasColumnName("isocode")
            .HasMaxLength(3)
            .IsRequired();
        builder.Property(x => x.Name)
            .HasColumnName("name")
            .HasMaxLength(60)
            .IsRequired();
        builder.Property(x => x.phone_code)
            .HasColumnName("phone_code")
            .HasMaxLength(5)
            .IsRequired();
    }
}
