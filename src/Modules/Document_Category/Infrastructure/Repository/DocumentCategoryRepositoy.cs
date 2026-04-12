using Microsoft.EntityFrameworkCore;
using Migraciones_Trasporte.src.Shared.Context;
using Migraciones_Trasporte.src.Modules.Document_Category.Infrastructure.Entity;

namespace Migraciones_Trasporte.src.Modules.Document_Category.Infrastructure.Repository;

public class DocumentCategoryRepository
{
    private readonly AppDbContext _context;

    public DocumentCategoryRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<List<DocumentCategoryEntity>> GetAllAsync()
        => await _context.DocumentCategories.ToListAsync();

    public async Task<DocumentCategoryEntity?> GetByIdAsync(Guid id)
        => await _context.DocumentCategories.FindAsync(id);

    public async Task AddAsync(DocumentCategoryEntity entity)
    {
        await _context.DocumentCategories.AddAsync(entity);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(DocumentCategoryEntity entity)
    {
        _context.DocumentCategories.Update(entity);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Guid id)
    {
        var entity = await GetByIdAsync(id);
        if (entity != null)
        {
            _context.DocumentCategories.Remove(entity);
            await _context.SaveChangesAsync();
        }
    }
}