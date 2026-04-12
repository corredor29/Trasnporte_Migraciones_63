using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Migraciones_Trasporte.src.Modules.Notification_Type.Infrastructure.Entity;

public class NotificationTypeEntityConfiguration: IEntityTypeConfiguration<NotificationTypeEntity>
{
    public void Configure(EntityTypeBuilder<NotificationTypeEntity> builder)
    {
        builder.ToTable("notification_type");

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
