using System.ComponentModel.DataAnnotations.Schema;
// ReSharper disable EntityFramework.ModelValidation.UnlimitedStringLength
// ReSharper disable PropertyCanBeMadeInitOnly.Global
// ReSharper disable InconsistentNaming
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.

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