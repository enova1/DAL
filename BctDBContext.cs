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


    public DbSet<AdminClient> AdminClients { get; set; }
    public DbSet<AdminClientSettings> AdminClientSettings { get; set; } 
    public DbSet<ReportingProfileTemplate> ReportingProfileTemplates { get; set; }
    public DbSet<ReportReminder> ReportReminders { get; set; }
    public DbSet<SystemEmail> SystemEmails { get; set; }
    public DbSet<EmailAttachment> EmailAttachments { get; set; }
    public DbSet<EmailSetting> EmailSettings { get; set; }
    public DbSet<EmailTemplate> EmailTemplates { get; set; }

    public DbSet<EmailNotificationType> EmailNotificationTypes { get; set; }
}
