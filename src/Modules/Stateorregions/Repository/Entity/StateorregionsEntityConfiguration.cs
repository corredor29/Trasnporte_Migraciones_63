using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace Migraciones_Trasporte.src.Modules.Stateorregions.Repository.Entity;

public class StateorregionsEntityConfiguration : IEntityTypeConfiguration<StateorregionsEntity>

{
    public void Configure(EntityTypeBuilder<StateorregionsEntity> builder)
        {
            builder.ToTable("stateorregions");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .HasColumnName("id")
                .IsRequired();

            builder.Property(x => x.Name)
                .HasColumnName("name")
                .HasMaxLength(60)
                .IsRequired();

            builder.Property(x => x.CountryId)
                .HasColumnName("countryId")
                .IsRequired();

            builder.Property(x => x.Code)
                .HasColumnName("code")
                .HasMaxLength(10)
                .IsRequired();

            builder.HasOne(x => x.Country)
                .WithMany()
                .HasForeignKey(x => x.CountryId)
                .OnDelete(DeleteBehavior.Restrict);
        }
}
