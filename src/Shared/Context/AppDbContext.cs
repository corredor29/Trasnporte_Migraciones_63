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
using Migraciones_Trasporte.src.Modules.Payment_Providers.Infrastructure.Entity;
using Migraciones_Trasporte.src.Modules.Transaction_Types.Infrastructure.Entity;
using Migraciones_Trasporte.src.Modules.Message_Type.Infrastructure.Entity;
using Migraciones_Trasporte.src.Modules.Assignment_Role.Infrastructure.Entity;
using Migraciones_Trasporte.src.Modules.Reason_Disputes.Infrastructure.Entity;
using Migraciones_Trasporte.src.Modules.Disputes_Status.Infrastructure.Entity;
using Migraciones_Trasporte.src.Modules.Type_Load.Infrastructure.Entity;
using Migraciones_Trasporte.src.Modules.Roles.Infrastructure.Entity;
using Migraciones_Trasporte.src.Modules.Countries.Infrastructure.Entity;
using Migraciones_Trasporte.src.Modules.Stateorregions.Repository.Entity;



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
    public DbSet<PaymentProvidersEntity> PaymentProviders {get; set;}
    public DbSet<TransactionTypesEntity> TransactionTypes {get; set;}
    public DbSet<MessageTypeEntity> MessageType{get; set;}
    public DbSet<AssignmentRoleEntity> AssignmentRole {get; set;}
    public DbSet<ReasonDisputesEntity> ReasonDisputes {get; set;}
    public DbSet<DisputesStatusEntity> DisputesStatus {get; set;}
    public DbSet<TypeLoadEntity> TypeLoad {get; set;}
    public DbSet<RolesStatusEntity> RolesStatus {get; set;}
    public DbSet<CountriesEntity> Countries {get; set;}
    public DbSet<StateorregionsEntity> Stateorregions {get; set;}
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
    }
}