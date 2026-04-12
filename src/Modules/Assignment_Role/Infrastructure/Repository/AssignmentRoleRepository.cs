using System;
using Microsoft.EntityFrameworkCore;
using Migraciones_Trasporte.src.Shared.Context;
using Migraciones_Trasporte.src.Modules.Assignment_Role.Infrastructure.Entity;

namespace Migraciones_Trasporte.src.Modules.Assignment_Role.Infrastructure.Repository;

public class AssignmentRoleRepository
{
private readonly AppDbContext _context;

    public AssignmentRoleRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<List<AssignmentRoleEntity>> GetAllAsync()
        => await _context.AssignmentRole.ToListAsync();

    public async Task<AssignmentRoleEntity?> GetByIdAsync(Guid id)
        => await _context.AssignmentRole.FindAsync(id);

    public async Task AddAsync(AssignmentRoleEntity entity)
    {
        await _context.AssignmentRole.AddAsync(entity);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(AssignmentRoleEntity entity)
    {
        _context.AssignmentRole.Update(entity);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Guid id)
    {
        var entity = await GetByIdAsync(id);
        if (entity != null)
        {
            _context.AssignmentRole.Remove(entity);
            await _context.SaveChangesAsync();
        }
    }
}
