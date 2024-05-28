using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccess.BctModels;

[Table("Email_Setting")]
public class EmailSetting
{
    public int Id { get; set; }
    public int Port { get; set; }
    public string? SmtpServer { get; set; }
    public string? UserName { get; set; }
    public string? Password { get; set; }
    public string? TestAddress { get; set; }
    public bool IsLive { get; set; }
    public string? EnvKey { get; set; }
    public string? TenantCode { get; set; }
    public string? TimeZone { get; set; }
    public bool Active { get; set; }
    public string? Sender { get; set; }
}