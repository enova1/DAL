namespace DataAccess.BctModels;

public class ReportingProfileTemplate
{
    public int Id { get; set; }
    public string DisplayName { get; set; }
    public string ReportingFrequency { get; set; }
    public string ApprovalSteps { get; set; }
    public bool Active { get; set; }
    public string CreatedBy_Id { get; set; }
    public DateTime? CreatedDate { get; set; }
    public string LastModifiedBy_Id { get; set; }
    public DateTime? LastModifiedDate { get; set; }
    public int? Client_Id { get; set; }
    public int? ReportingCycle_Id { get; set; }
    public int? ReportingProfile_Id { get; set; }
    public bool Published { get; set; }
    public bool HasContract { get; set; }
    public string Status { get; set; }
    public bool HasCertificationRequirement { get; set; }
    public string CertificationLanguage { get; set; }
    public int? ReportReminders_Id { get; set; }
}