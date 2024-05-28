using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccess.BctModels;

[Table("Email_NotificationType")]
public class EmailNotificationType
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public bool IsComplianceNotification { get; set; }
    public string ClientCode { get; set; }
    public bool Active { get; set; }
    public string CreatedBy_Id { get; set; }
    public DateTime? CreatedDate { get; set; }
    public string LastModifiedBy_Id { get; set; }
    public DateTime? LastModifiedDate { get; set; }
    public string NotificationType { get; set; }
}