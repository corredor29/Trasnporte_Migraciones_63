using System;

namespace Migraciones_Trasporte.src.Modules.Document_Category.Infrastructure.Entity;

public class DocumentCategoryEntity
{
    public Guid Id {get; set;}
    public string Name { get; set; } = string.Empty;

    public string Description {get; set;} = string.Empty;

    public ICollection<DocumentCategoryEntity> DocumentCategory {get; set;} = new List<DocumentCategoryEntity>();

}
