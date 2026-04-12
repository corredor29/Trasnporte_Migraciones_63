using System;

namespace Migraciones_Trasporte.src.Modules.Assignment_Role.Infrastructure.Entity;

public class AssignmentRoleEntity
{
public Guid Id {get; set;}
    public string Name { get; set; } = string.Empty;

    public string Description {get; set;} = string.Empty;

    public ICollection<AssignmentRoleEntity> AssignmentRole {get; set;} = new List<AssignmentRoleEntity>();

}
