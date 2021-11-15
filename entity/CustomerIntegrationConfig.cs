using Flunt.Notifications;

namespace ef_core_6_get_troubleshooting;

public class CustomerIntegrationConfig : Notifiable
{
    public CustomerIntegrationConfig(Guid tenantId, int rangeDate)
    {
        TenantId = tenantId;
        RangeDate = rangeDate;
    }

    public Guid TenantId { get; private set; }
    public int RangeDate { get; private set; }
}

