using System;

namespace Migraciones_Trasporte.src.Modules.Notification_Type.Infrastructure.Entity;

public class NotificationTypeEntity
{
    public Guid Id {get; set;}
    public string Name { get; set; } = string.Empty;

    public string Description {get; set;} = string.Empty;

    public ICollection<NotificationTypeEntity> NotificationType {get; set;} = new List<NotificationTypeEntity>();

}
