using System;

namespace Migraciones_Trasporte.src.Modules.Vehicules_Status.Infrastructure.Entity;

public class VehiculesStatusEntity
{
    public Guid Id {get; set;}
    public string Name { get; set; } = string.Empty;

    public string Description {get; set;} = string.Empty;

    public ICollection<VehiculesStatusEntity> VehiculesStatus{get; set;} = new List<VehiculesStatusEntity>();

}
