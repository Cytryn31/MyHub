using Krystyna.CostManager.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Krystyna.CostManager.Infrastructure.Configurations;

public class InvoiceConfiguration : IEntityTypeConfiguration<Invoice>
{
    public void Configure(EntityTypeBuilder<Invoice> builder)
    {
        builder.HasKey(i => i.Id);
        builder.Property(i => i.Id).IsRequired().ValueGeneratedOnAdd();
        
        builder.HasOne(i => i.Cost)
            .WithMany(c => c.Invoices)
            .HasForeignKey("CostId");

        builder.Property(i => i.InvoiceStatus).IsRequired();
    }
}