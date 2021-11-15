using Flunt.Notifications;
using Microsoft.EntityFrameworkCore;

namespace ef_core_6_get_troubleshooting;

public class MyDbContext : DbContext
{
    public MyDbContext() : base()
    {
        
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            var connectionString = "Server=localhost;Database=portfoliomanagement;User ID=sa;Password=1Passw@rd!@;MultipleActiveResultSets=True";
            optionsBuilder.UseSqlServer(connectionString);
        }
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.ApplyConfigurationsFromAssembly(typeof(MyDbContext).Assembly);        
        builder.Ignore<Notification>();
    }

    public DbSet<CustomerIntegrationConfig> CustomerIntegrationConfigs { get; set; }
}

