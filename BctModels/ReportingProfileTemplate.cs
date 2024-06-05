using System.ComponentModel.DataAnnotations.Schema;
// ReSharper disable EntityFramework.ModelValidation.UnlimitedStringLength
// ReSharper disable InconsistentNaming
// ReSharper disable PropertyCanBeMadeInitOnly.Global
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.

namespace DataAccess.BctModels;

[Table("Reporting_ReportingProfileTemplates")]
public class ReportingProfileTemplate
{
    public int Id { get; set; }
    public string? DisplayName { get; set; }
    public int Client_Id { get; set; }
    public string? ReportingFrequency { get; set; }
    public bool Active { get; set; }
    public string Status { get; set; }
}