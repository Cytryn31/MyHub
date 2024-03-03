using Microsoft.EntityFrameworkCore;
using MyHub.Modules.Krystyna.CostManager.Core.Entities;

namespace MyHub.Modules.Krystyna.CostManager.Infrastructure;
internal class CostManagerDbContext : DbContext
{
    public DbSet<Invoice> Invoices { get; set; }
    public DbSet<CostDefinition> CostDefinitions { get; set; }
    public DbSet<Cost> Costs { get; set; }

    public CostManagerDbContext(DbContextOptions<CostManagerDbContext> options) : base(options)
    {
    }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
    }
}