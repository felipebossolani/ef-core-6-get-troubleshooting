using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ef_core_6_get_troubleshooting;

public class CustomerIntegrationConfigMap : IEntityTypeConfiguration<CustomerIntegrationConfig>
{
    
    public void Configure(EntityTypeBuilder<CustomerIntegrationConfig> builder)
    {
        builder.HasKey(e => e.TenantId);

        builder.ToTable("CustomerIntegrationConfigs");
    }
}

