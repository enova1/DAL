using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccess.BctModels;

[Table("Email_SystemEmails")]
public class SystemEmail
{
    public int Id { get; set; }
    public string Recepient { get; set; }
    public string Subject { get; set; }
    public string Body { get; set; }
    public bool Sent { get; set; }
    public string TenantCode { get; set; }
    public bool Active { get; set; }
    public string CreatedBy_Id { get; set; }
    public DateTime? CreatedDate { get; set; }
    public string LastModifiedBy_Id { get; set; }
    public DateTime? LastModifiedDate { get; set; }
}