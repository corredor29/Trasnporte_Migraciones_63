using System;

namespace Migraciones_Trasporte.src.Modules.Countries.Infrastructure.Entity;

public class CountriesEntity
{
    public Guid Id {get; set;}
    public string IsoCode {get; set;} = string.Empty;
    public string Name { get; set; } = string.Empty;

    public string phone_code {get; set;} = string.Empty;

    public ICollection<CountriesEntity> Countries {get; set;} = new List<CountriesEntity>();
}
