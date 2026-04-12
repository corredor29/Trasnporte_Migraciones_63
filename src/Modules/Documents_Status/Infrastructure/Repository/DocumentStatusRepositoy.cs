using Microsoft.EntityFrameworkCore;
using Migraciones_Trasporte.src.Shared.Context;
using Migraciones_Trasporte.src.Modules.Documents_Status.Infrastructure.Entity;

namespace Migraciones_Trasporte.src.Modules.Documents_Status.Infrastructure.Repository;

public class DocumentStatusRepository
{
    private readonly AppDbContext _context;

    public DocumentStatusRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<List<DocumentStatusEntity>> GetAllAsync()
        => await _context.DocumentStatuses.ToListAsync();

    public async Task<DocumentStatusEntity?> GetByIdAsync(Guid id)
        => await _context.DocumentStatuses.FindAsync(id);

    public async Task AddAsync(DocumentStatusEntity entity)
    {
        await _context.DocumentStatuses.AddAsync(entity);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(DocumentStatusEntity entity)
    {
        _context.DocumentStatuses.Update(entity);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Guid id)
    {
        var entity = await GetByIdAsync(id);
        if (entity != null)
        {
            _context.DocumentStatuses.Remove(entity);
            await _context.SaveChangesAsync();
        }
    }
}