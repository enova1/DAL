using System.ComponentModel.DataAnnotations.Schema;
// ReSharper disable EntityFramework.ModelValidation.UnlimitedStringLength
// ReSharper disable InconsistentNaming
// ReSharper disable PropertyCanBeMadeInitOnly.Global
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.

namespace DataAccess.BctModels;

[Table("Email_Template")]
public class EmailTemplate
{
    public int Id { get; set; }
    public string? Subject { get; set; }
    public string? Description { get; set; }
    public string? Template { get; set; }
    public string TenantCode { get; set; }
    public bool Active { get; set; }

    public int EmailType_Id { get; set; }
}   