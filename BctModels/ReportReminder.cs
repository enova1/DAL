using System.ComponentModel.DataAnnotations.Schema;
// ReSharper disable EntityFramework.ModelValidation.UnlimitedStringLength
// ReSharper disable InconsistentNaming
// ReSharper disable PropertyCanBeMadeInitOnly.Global
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.

namespace DataAccess.BctModels;

[Table("Report_Reminders")]
public class ReportReminder
{

    public int ReportTemplateId { get; set; }
    public int EmailTemplateId { get; set; }
    public string EmailNotificationType { get; set; }

    public int NumberOfDays { get; set; }
    public string WhenToSend { get; set; }
    public string Months { get; set; }
    public string JobName { get; set; }


    public int Id { get; set; }
    public bool Active { get; set; }
    public string CreatedBy_Id { get; set; }
    public DateTime? CreatedDate { get; set; }
    public string LastModifiedBy_Id { get; set; }
    public DateTime? LastModifiedDate { get; set; }
}