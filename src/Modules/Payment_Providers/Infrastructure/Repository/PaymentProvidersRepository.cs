using System;
using Microsoft.EntityFrameworkCore;
using Migraciones_Trasporte.src.Shared.Context;
using Migraciones_Trasporte.src.Modules.Payment_Providers.Infrastructure.Entity;


namespace Migraciones_Trasporte.src.Modules.Payment_Providers.Infrastructure.Repository;

public class PaymentProvidersRepository
{
    private readonly AppDbContext _context;

    public PaymentProvidersRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<List<PaymentProvidersEntity>> GetAllAsync()
        => await _context. PaymentProviders.ToListAsync();

    public async Task<PaymentProvidersEntity?> GetByIdAsync(Guid id)
        => await _context. PaymentProviders.FindAsync(id);

    public async Task AddAsync(PaymentProvidersEntity entity)
    {
        await _context. PaymentProviders.AddAsync(entity);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(PaymentProvidersEntity entity)
    {
        _context. PaymentProviders.Update(entity);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Guid id)
    {
        var entity = await GetByIdAsync(id);
        if (entity != null)
        {
            _context. PaymentProviders.Remove(entity);
            await _context.SaveChangesAsync();
        }
    }
}
