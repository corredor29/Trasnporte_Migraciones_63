using System;

namespace Migraciones_Trasporte.src.Modules.Message_Type.Infrastructure.Entity;

public class MessageTypeEntity
{

    public Guid Id {get; set;}
    public string Name { get; set; } = string.Empty;

    public string Description {get; set;} = string.Empty;

    public ICollection<MessageTypeEntity> MessageType {get; set;} = new List<MessageTypeEntity>();
}
