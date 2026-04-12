using System;

namespace Migraciones_Trasporte.src.Modules.Subscription_Type.Infrastructure.Entity;

public class SubscriptionTypeEntity
{
    public Guid Id {get; set;}
    public string Name { get; set; } = string.Empty;

    public string Description {get; set;} = string.Empty;

    public ICollection<SubscriptionTypeEntity> SubscriptionType {get; set;} = new List<SubscriptionTypeEntity>();

}
