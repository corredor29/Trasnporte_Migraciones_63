using System;
using Microsoft.EntityFrameworkCore;
using Migraciones_Trasporte.src.Shared.Context;
using Migraciones_Trasporte.src.Modules.Person_Status.Infrastructure.Entity;

namespace Migraciones_Trasporte.src.Modules.Person_Status.Infrastructure.Repository;

public class PersonStatusRepository
{
    private readonly AppDbContext _context;

    public PersonStatusRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<List<PersonStatusEntity>> GetAllAsync()
        => await _context.PersonStatus .ToListAsync();

    public async Task<PersonStatusEntity?> GetByIdAsync(Guid id)
        => await _context.PersonStatus.FindAsync(id);

    public async Task AddAsync(PersonStatusEntity entity)
    {
        await _context.PersonStatus.AddAsync(entity);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(PersonStatusEntity entity)
    {
        _context.PersonStatus.Update(entity);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Guid id)
    {
        var entity = await GetByIdAsync(id);
        if (entity != null)
        {
            _context.PersonStatus.Remove(entity);
            await _context.SaveChangesAsync();
        }
    }
}
