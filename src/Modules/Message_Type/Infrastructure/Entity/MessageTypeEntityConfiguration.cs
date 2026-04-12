using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Migraciones_Trasporte.src.Modules.Message_Type.Infrastructure.Entity;

public class MessageTypeEntityConfiguration : IEntityTypeConfiguration<MessageTypeEntity>
{
    public void Configure(EntityTypeBuilder<MessageTypeEntity> builder)
    {
        builder.ToTable("message_type");

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
