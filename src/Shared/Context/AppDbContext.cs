using System;
using Microsoft.EntityFrameworkCore;
using Migraciones_Trasporte.src.Modules.Document_Category.Infrastructure.Entity;
using Migraciones_Trasporte.src.Modules.Documents_Status.Infrastructure.Entity;


namespace Migraciones_Trasporte.src.Shared.Context;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public DbSet<DocumentCategoryEntity> DocumentCategories { get; set; }
    public DbSet<DocumentStatusEntity> DocumentStatuses {get; set;}

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
    }
}