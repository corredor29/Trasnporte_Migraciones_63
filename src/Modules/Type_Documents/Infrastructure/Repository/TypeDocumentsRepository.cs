using System;
using Microsoft.EntityFrameworkCore;
using Migraciones_Trasporte.src.Shared.Context;
using Migraciones_Trasporte.src.Modules.Type_Documents.Infrastructure.Entity;

namespace Migraciones_Trasporte.src.Modules.Type_Documents.Infrastructure.Repository;

public class TypeDocumentsRepository
{
    private readonly AppDbContext _context;

    public TypeDocumentsRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<List<TypeDocumentsEntity>> GetAllAsync()
        => await _context.TypeDocuments.Include(x => x.Category).ToListAsync();

    public async Task<TypeDocumentsEntity?> GetByIdAsync(Guid id)
        => await _context.TypeDocuments.Include(x => x.Category)
            .FirstOrDefaultAsync(x => x.Id == id);

    public async Task AddAsync(TypeDocumentsEntity entity)
    {
        await _context.TypeDocuments.AddAsync(entity);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(TypeDocumentsEntity entity)
    {
        _context.TypeDocuments.Update(entity);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Guid id)
    {
        var entity = await GetByIdAsync(id);
        if (entity != null)
        {
            _context.TypeDocuments.Remove(entity);
            await _context.SaveChangesAsync();
        }
    }
}
