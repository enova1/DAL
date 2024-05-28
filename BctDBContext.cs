using DataAccess.BctModels;
using Microsoft.EntityFrameworkCore;

namespace DataAccess;

/// <inheritdoc />
public class BctDbContext : DbContext
{
    /// <inheritdoc />
    public BctDbContext(DbContextOptions<BctDbContext> options) : base(options)
    {
    }
    /// <summary>
    /// OnConfiguring method to configure the database connection.
    /// </summary>
    /// <param name="optionsBuilder"></param>
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer($"Server=localhost;Database=BlackCatTransit;persist security info=True;Integrated Security=SSPI;Encrypt=True;TrustServerCertificate=True;MultipleActiveResultSets=True");
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
}
