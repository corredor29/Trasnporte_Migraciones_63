using System;

namespace Migraciones_Trasporte.src.Modules.Person_Status.Infrastructure.Entity;

public class PersonStatusEntity
{
    public Guid Id {get; set;}
    public string Name { get; set; } = string.Empty;

    public string Description {get; set;} = string.Empty;

    public ICollection<PersonStatusEntity> PersonStatus{get; set;} = new List<PersonStatusEntity>();

}
