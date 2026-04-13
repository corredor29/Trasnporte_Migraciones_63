using System;
using Microsoft.EntityFrameworkCore;
using Migraciones_Trasporte.src.Shared.Context;
using Migraciones_Trasporte.src.Modules.Reason_Disputes.Infrastructure.Entity;
namespace Migraciones_Trasporte.src.Modules.Reason_Disputes.Infrastructure.Repository;

public class ReasonDisputesRepository
{
    private readonly AppDbContext _context;

    public ReasonDisputesRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<List<ReasonDisputesEntity>> GetAllAsync()
        => await _context. ReasonDisputes.ToListAsync();

    public async Task<ReasonDisputesEntity?> GetByIdAsync(Guid id)
        => await _context. ReasonDisputes.FindAsync(id);

    public async Task AddAsync(ReasonDisputesEntity entity)
    {
        await _context. ReasonDisputes.AddAsync(entity);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(ReasonDisputesEntity entity)
    {
        _context. ReasonDisputes.Update(entity);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Guid id)
    {
        var entity = await GetByIdAsync(id);
        if (entity != null)
        {
            _context. ReasonDisputes.Remove(entity);
            await _context.SaveChangesAsync();
        }
    }
}
