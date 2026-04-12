using System;

namespace Migraciones_Trasporte.src.Modules.Companies_Status.Infrastructure.Entity;

public class CompaniesStatusEntity
{
    public Guid Id {get; set;}
    public string Name { get; set; } = string.Empty;

    public string Description {get; set;} = string.Empty;

    public ICollection<CompaniesStatusEntity> CompaniesStatus {get; set;} = new List<CompaniesStatusEntity>();
}
