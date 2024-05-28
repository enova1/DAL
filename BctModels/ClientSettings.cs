using System.ComponentModel.DataAnnotations.Schema;
// ReSharper disable EntityFramework.ModelValidation.UnlimitedStringLength
// ReSharper disable InconsistentNaming
// ReSharper disable PropertyCanBeMadeInitOnly.Global
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.

namespace DataAccess.BctModels;

[Table("Admin_ClientSettings")]
public class ClientSettings
{
    public int Id { get; set; }
    public string ClientCode { get; set; }
    public string InvoiceLabel { get; set; }
    public string AccessibilityInfo { get; set; }
    public string WelcomeMessage { get; set; }
    public string SupportEmail { get; set; }
    public string FiscalYearCode { get; set; }
    public bool Active { get; set; }
    public string CreatedBy_Id { get; set; }
    public DateTime? CreatedDate { get; set; }
    public string LastModifiedBy_Id { get; set; }
    public DateTime? LastModifiedDate { get; set; }
    public int HouseDistricts { get; set; }
    public int SenateDistricts { get; set; }
    public int CongressionalDistricts { get; set; }
    public bool ExternalLoginEnabled { get; set; }
    public bool FullSSOEnabled { get; set; }
    public bool AllowNewOrgFromSelfRegistration { get; set; }
    public string SelfRegistrationAltText { get; set; }
    public string DOTContactNumber { get; set; }
}