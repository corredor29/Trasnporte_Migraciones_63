using System;

namespace Migraciones_Trasporte.src.Modules.Payment_Statuses.Infrastructure.Entity;

public class PaymentStatusesEntity
{
    public Guid Id {get; set;}
    public string Name { get; set; } = string.Empty;
    public ICollection<PaymentStatusesEntity> PaymentStatuses{get; set;} = new List<PaymentStatusesEntity>();

}
