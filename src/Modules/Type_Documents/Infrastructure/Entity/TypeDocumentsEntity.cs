using System;
using Migraciones_Trasporte.src.Modules.Document_Category.Infrastructure.Entity;

namespace Migraciones_Trasporte.src.Modules.Type_Documents.Infrastructure.Entity;

public class TypeDocumentsEntity
{
    public Guid Id {get; set;}
    public string Name { get; set; } = string.Empty;
    public Guid Category { get; set; }

    public DocumentCategoryEntity DocumentCategory {get; set;} = null!;
}
