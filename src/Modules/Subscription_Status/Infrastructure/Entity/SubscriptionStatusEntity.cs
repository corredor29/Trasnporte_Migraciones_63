using System;

namespace Migraciones_Trasporte.src.Modules.Subscription_Status.Infrastructure.Entity;

public class SubscriptionStatusEntity
{
    public Guid Id {get; set;}
    public string Name { get; set; } = string.Empty;

    public string Description {get; set;} = string.Empty;

    public ICollection<SubscriptionStatusEntity> SubscriptionStatus {get; set;} = new List<SubscriptionStatusEntity>();

}