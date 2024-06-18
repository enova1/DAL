using DataAccess.BctModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace DataAccess;

/// <inheritdoc />
/// <inheritdoc />
public class BctDbContext(DbContextOptions<BctDbContext> options) : DbContext(options)
{
    private readonly IConfiguration _configuration = ConfigurationHelper.GetConfiguration();
    /// <summary>
    /// OnConfiguring method to configure the database connection.
    /// </summary>
    /// <param name="optionsBuilder"></param>
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(_configuration.GetConnectionString("BCTConnection"));
        base.OnConfiguring(optionsBuilder);
    }

    public DbSet<Client> Clients { get; set; }
    public DbSet<ClientSettings> ClientSettings { get; set; } 
    public DbSet<ReportingProfileTemplate> ReportingProfileTemplates { get; set; }
    public DbSet<ReportReminder> ReportReminders { get; set; }
    public DbSet<SystemEmail> SystemEmails { get; set; }
    public DbSet<EmailAttachment> EmailAttachments { get; set; }
    public DbSet<EmailSetting> EmailSettings { get; set; }
    public DbSet<EmailTemplate> EmailTemplates { get; set; }
    public DbSet<EmailNotificationType> EmailNotificationTypes { get; set; }
    public DbSet<SecurityRoles> SecurityRoles { get; set; }
    public DbSet<SecurityUsers> SecurityUsers { get; set; }
    public DbSet<SecurityUserRoles> SecurityUserRoles { get; set; }
    public DbSet<Contact> Contacts { get; set; }

    public DbSet<Contract> Contracts { get; set; }
    public DbSet<Organization> Organizations { get; set; }
    public DbSet<FundSourceType> FundSourceTypes { get; set; }
    public DbSet<ContractType> ContractTypes { get; set; }
}
