using System;

namespace Migraciones_Trasporte.src.Modules.Disputes_Status.Infrastructure.Entity;

public class DisputesStatusEntity
{
public Guid Id {get; set;}
    public string Name { get; set; } = string.Empty;

    public string Description {get; set;} = string.Empty;

    public ICollection<DisputesStatusEntity> DisputesStatus {get; set;} = new List<DisputesStatusEntity>();
}
