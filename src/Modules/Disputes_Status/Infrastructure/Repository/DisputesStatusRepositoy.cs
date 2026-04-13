using System;
using Microsoft.EntityFrameworkCore;
using Migraciones_Trasporte.src.Shared.Context;
using Migraciones_Trasporte.src.Modules.Disputes_Status.Infrastructure.Entity;

namespace Migraciones_Trasporte.src.Modules.Disputes_Status.Infrastructure.Repository;

public class DisputesStatusRepositoy
{
    private readonly AppDbContext _context;

    public DisputesStatusRepositoy(AppDbContext context)
    {
        _context = context;
    }

    public async Task<List<DisputesStatusEntity>> GetAllAsync()
        => await _context. DisputesStatus.ToListAsync();

    public async Task<DisputesStatusEntity?> GetByIdAsync(Guid id)
        => await _context. DisputesStatus.FindAsync(id);

    public async Task AddAsync(DisputesStatusEntity entity)
    {
        await _context. DisputesStatus.AddAsync(entity);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(DisputesStatusEntity entity)
    {
        _context. DisputesStatus.Update(entity);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Guid id)
    {
        var entity = await GetByIdAsync(id);
        if (entity != null)
        {
            _context. DisputesStatus.Remove(entity);
            await _context.SaveChangesAsync();
        }
    }
}
