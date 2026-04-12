using System;

namespace Migraciones_Trasporte.src.Modules.Transaction_Types.Infrastructure.Entity;

public class TransactionTypesEntity
{
    public Guid Id {get; set;}
    public string Name { get; set; } = string.Empty;


    public ICollection<TransactionTypesEntity> TransactionTypes {get; set;} = new List<TransactionTypesEntity>();

}
