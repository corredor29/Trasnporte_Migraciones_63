using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Migraciones_Trasporte.src.Modules.Companies_Status.Infrastructure.Entity;

public class CompaniesStatusEntityConfiguration : IEntityTypeConfiguration<CompaniesStatusEntity>
{
   public void Configure(EntityTypeBuilder<CompaniesStatusEntity> builder)
    {
        builder.ToTable("companies_status");

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
