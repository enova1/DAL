namespace DataAccess.BctModels;

public class EmailSetting
{
    public int Id { get; set; }
    public int Port { get; set; }
    public string SmtpServer { get; set; }
    public string UserName { get; set; }
    public string Password { get; set; }
    public string TestAddress { get; set; }
    public bool IsLive { get; set; }
    public string EnvKey { get; set; }
    public string TenantCode { get; set; }
    public string TimeZone { get; set; }
    public DateTime CreatedDateTime { get; set; }
    public string ModifiedDateTime { get; set; }
    public bool Active { get; set; }
    public string CreatedBy_Id { get; set; }
    public DateTime? CreatedDate { get; set; }
    public string LastModifiedBy_Id { get; set; }
    public DateTime? LastModifiedDate { get; set; }
    public string Sender { get; set; }
}