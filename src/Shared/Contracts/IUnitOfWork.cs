using System;

namespace Migraciones_Trasporte.src.Shared.Contracts;

public interface IUnitOfWork
{
    Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);

}
