using Krystyna.CostManager.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Krystyna.CostManager.Infrastructure.Configurations;

public class CostConfiguration : IEntityTypeConfiguration<Cost>
{
    public void Configure(EntityTypeBuilder<Cost> builder)
    {
        builder.HasKey(c => c.Id);
        builder.Property(c => c.Id).IsRequired().ValueGeneratedOnAdd();
        
        builder.Property(c => c.Month).IsRequired();
        builder.Property(c => c.Year).IsRequired();

        builder.HasOne(c => c.CostDefinition)
            .WithMany() 
            .HasForeignKey("CostDefinitionId");

        builder.HasMany(c => c.Invoices)
            .WithOne(i => i.Cost)
            .HasForeignKey("CostId");
    }
}