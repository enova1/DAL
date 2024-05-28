using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccess.BctModels;

[Table("Reporting_ReportingProfileTemplates")]
public class ReportingProfileTemplate
{
    public int Id { get; set; }
    public string? DisplayName { get; set; }
    public int Client_Id { get; set; }
    public string? ReportingFrequency { get; set; }
    public bool Active { get; set; }
}