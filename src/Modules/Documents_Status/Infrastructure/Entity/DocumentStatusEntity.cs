using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Migraciones_Trasporte.src.Modules.Documents_Status.Infrastructure.Entity;

public class DocumentStatusEntity
{
 public Guid Id {get; set;}
    public string Name { get; set; } = string.Empty;

    public string Description {get; set;} = string.Empty;

    public ICollection<DocumentStatusEntity> DocumentsStatus {get; set;} = new List<DocumentStatusEntity>();
}
