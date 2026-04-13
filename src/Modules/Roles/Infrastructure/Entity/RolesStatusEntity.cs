using System;

namespace Migraciones_Trasporte.src.Modules.Roles.Infrastructure.Entity;

public class RolesStatusEntity
{
public Guid Id {get; set;}
    public string Name { get; set; } = string.Empty;

    public string Description {get; set;} = string.Empty;

    public ICollection<RolesStatusEntity> RolesStatus {get; set;} = new List<RolesStatusEntity>();
}
