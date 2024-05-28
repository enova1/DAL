using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccess.BctModels;

[Table("Report_Reminders")]
public class ReportReminder
{

    public int ReportTemplateId { get; set; }
    public int EmailTemplateId { get; set; }
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