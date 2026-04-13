using System;
using Microsoft.EntityFrameworkCore;
using Migraciones_Trasporte.src.Shared.Context;
using Migraciones_Trasporte.src.Modules.Stateorregions.Repository.Entity;

namespace Migraciones_Trasporte.src.Modules.Stateorregions.Repository.Repository;

public class StateorregionsRepositoy
{
    private readonly AppDbContext _context;

    public StateorregionsRepositoy(AppDbContext context)
    {
        _context = context;
    }

    public async Task<List<StateorregionsEntity>> GetAllAsync()
        => await _context.Stateorregions.Include(x => x.Country).ToListAsync();

    public async Task<StateorregionsEntity?> GetByIdAsync(Guid id)
        => await _context.Stateorregions.Include(x => x.Country)
            .FirstOrDefaultAsync(x => x.Id == id);

    public async Task AddAsync(StateorregionsEntity entity)
    {
        await _context.Stateorregions.AddAsync(entity);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(StateorregionsEntity entity)
    {
        _context.Stateorregions.Update(entity);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Guid id)
    {
        var entity = await GetByIdAsync(id);
        if (entity != null)
        {
            _context.Stateorregions.Remove(entity);
            await _context.SaveChangesAsync();
        }
    }
}
