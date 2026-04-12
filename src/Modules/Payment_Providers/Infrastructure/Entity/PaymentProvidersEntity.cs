using System;

namespace Migraciones_Trasporte.src.Modules.Payment_Providers.Infrastructure.Entity;

public class PaymentProvidersEntity
{
    public Guid Id {get; set;}
    public string Name { get; set; } = string.Empty;


    public ICollection<PaymentProvidersEntity> PaymentProviders {get; set;} = new List<PaymentProvidersEntity>();

}
