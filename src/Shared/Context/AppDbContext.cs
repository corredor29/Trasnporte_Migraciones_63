using System;
using Microsoft.EntityFrameworkCore;
using Migraciones_Trasporte.src.Modules.Document_Category.Infrastructure.Entity;
using Migraciones_Trasporte.src.Modules.Documents_Status.Infrastructure.Entity;
using Migraciones_Trasporte.src.Modules.Vehicules_Status.Infrastructure.Entity;
using Migraciones_Trasporte.src.Modules.Person_Status.Infrastructure.Entity;
using Migraciones_Trasporte.src.Modules.Companies_Status.Infrastructure.Entity;
using Migraciones_Trasporte.src.Modules.Notification_Type.Infrastructure.Entity;
using Migraciones_Trasporte.src.Modules.Subscription_Type.Infrastructure.Entity;
using Migraciones_Trasporte.src.Modules.Subscription_Status.Infrastructure.Entity;
using Migraciones_Trasporte.src.Modules.Payment_Statuses.Infrastructure.Entity;
namespace Migraciones_Trasporte.src.Shared.Context;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public DbSet<DocumentCategoryEntity> DocumentCategories { get; set; }
    public DbSet<DocumentStatusEntity> DocumentStatuses {get; set;}
    public DbSet<VehiculesStatusEntity> VehiculesStatus {get; set;}
    public DbSet<PersonStatusEntity> PersonStatus {get; set;}
    public DbSet<CompaniesStatusEntity> CompaniesStatus {get; set;}
    public DbSet<NotificationTypeEntity> NotificationType {get; set;}
    public DbSet<SubscriptionTypeEntity> SubscriptionType {get; set;}
    public DbSet<SubscriptionStatusEntity> SubscriptionStatus {get; set;}
    public DbSet<PaymentStatusesEntity> PaymentStatuses {get; set;}
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
    }
}