using System;

namespace Migraciones_Trasporte.src.Modules.Type_Load.Infrastructure.Entity;

public class TypeLoadEntity
{

    public Guid Id {get; set;}
    public string Name { get; set; } = string.Empty;

    public string Description {get; set;} = string.Empty;

    public ICollection<TypeLoadEntity> TypeLoad {get; set;} = new List<TypeLoadEntity>();
}
