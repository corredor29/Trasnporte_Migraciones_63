using System;
using Microsoft.EntityFrameworkCore;
using Migraciones_Trasporte.src.Shared.Context;
using Migraciones_Trasporte.src.Modules.Roles.Infrastructure.Entity;
namespace Migraciones_Trasporte.src.Modules.Roles.Infrastructure.Repository;

public class RolesRepositoy
{
    private readonly AppDbContext _context;

    public RolesRepositoy(AppDbContext context)
    {
        _context = context;
    }

    public async Task<List<RolesStatusEntity>> GetAllAsync()
        => await _context.RolesStatus.ToListAsync();

    public async Task<RolesStatusEntity?> GetByIdAsync(Guid id)
        => await _context.RolesStatus.FindAsync(id);

    public async Task AddAsync(RolesStatusEntity entity)
    {
        await _context.RolesStatus.AddAsync(entity);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(RolesStatusEntity entity)
    {
        _context.RolesStatus.Update(entity);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Guid id)
    {
        var entity = await GetByIdAsync(id);
        if (entity != null)
        {
            _context.RolesStatus.Remove(entity);
            await _context.SaveChangesAsync();
        }
    }
}
