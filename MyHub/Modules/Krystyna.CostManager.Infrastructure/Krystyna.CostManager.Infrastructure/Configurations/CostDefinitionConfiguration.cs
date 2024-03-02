using Krystyna.CostManager.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Krystyna.CostManager.Infrastructure.Configurations;

public class CostDefinitionConfiguration : IEntityTypeConfiguration<CostDefinition>
{
    public void Configure(EntityTypeBuilder<CostDefinition> builder)
    {
        builder.HasKey(cd => cd.Id);
        builder.Property(cd => cd.Id).IsRequired().ValueGeneratedOnAdd();
        
        builder.Property(cd => cd.Name).IsRequired().HasMaxLength(255);
    }
}