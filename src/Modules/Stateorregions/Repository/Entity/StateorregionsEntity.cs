using System;
using Migraciones_Trasporte.src.Modules.Countries.Infrastructure.Entity;
namespace Migraciones_Trasporte.src.Modules.Stateorregions.Repository.Entity;

public class StateorregionsEntity
{
    public Guid Id {get; set;}
    public string Name { get; set; } = string.Empty;
    public Guid CountryId { get; set; }
    public string Code { get; set; } = string.Empty;

    public CountriesEntity Country { get; set; } = null!;

}
