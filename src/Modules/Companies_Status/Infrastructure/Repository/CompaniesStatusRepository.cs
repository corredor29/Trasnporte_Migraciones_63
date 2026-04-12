using System;
using Microsoft.EntityFrameworkCore;
using Migraciones_Trasporte.src.Shared.Context;
using Migraciones_Trasporte.src.Modules.Companies_Status.Infrastructure.Entity;
namespace Migraciones_Trasporte.src.Modules.Companies_Status.Infrastructure.Repository;

public class CompaniesStatusRepository
{
    private readonly AppDbContext _context;

    public CompaniesStatusRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<List<CompaniesStatusEntity>> GetAllAsync()
        => await _context.CompaniesStatus.ToListAsync();

    public async Task<CompaniesStatusEntity?> GetByIdAsync(Guid id)
        => await _context.CompaniesStatus.FindAsync(id);

    public async Task AddAsync(CompaniesStatusEntity entity)
    {
        await _context.CompaniesStatus.AddAsync(entity);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(CompaniesStatusEntity entity)
    {
        _context.CompaniesStatus.Update(entity);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Guid id)
    {
        var entity = await GetByIdAsync(id);
        if (entity != null)
        {
            _context.CompaniesStatus.Remove(entity);
            await _context.SaveChangesAsync();
        }
    }
}
