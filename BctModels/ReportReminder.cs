namespace DataAccess.BctModels;

public class ReportReminder
{
    public int Id { get; set; }
    public int ReportId { get; set; }
    public string Reminder { get; set; }
    public int NumberOfDays { get; set; }
    public string WhenToSend { get; set; }
    public string Months { get; set; }
    public bool Active { get; set; }
    public string CreatedBy_Id { get; set; }
    public DateTime? CreatedDate { get; set; }
    public string LastModifiedBy_Id { get; set; }
    public DateTime? LastModifiedDate { get; set; }
}