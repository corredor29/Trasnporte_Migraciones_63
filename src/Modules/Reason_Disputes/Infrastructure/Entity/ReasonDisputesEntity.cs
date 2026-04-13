using System;

namespace Migraciones_Trasporte.src.Modules.Reason_Disputes.Infrastructure.Entity;

public class ReasonDisputesEntity
{
public Guid Id {get; set;}
    public string Name { get; set; } = string.Empty;

    public string Description {get; set;} = string.Empty;

    public ICollection<ReasonDisputesEntity> ReasonDisputes {get; set;} = new List<ReasonDisputesEntity>();
}
