using ef_core_6_get_troubleshooting;

var tenantId = Guid.Parse("C39324CF-9DCC-4A0B-A31A-E41334336573");

using var context = new MyDbContext();
var configs = 
    context.CustomerIntegrationConfigs
        .Where(x => tenantId.Equals(x.TenantId))
        .FirstOrDefault();
Console.WriteLine($"RangeDate: {configs.RangeDate}");

    