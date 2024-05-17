namespace DataAccess.BctModels;

public partial class AdminClient
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Code { get; set; }
    public string Email { get; set; }
    public int TwoFactorSetting { get; set; }
    public bool Active { get; set; }
    public string CreatedBy_Id { get; set; }
    public DateTime? CreatedDate { get; set; }
    public string LastModifiedBy_Id { get; set; }
    public DateTime? LastModifiedDate { get; set; }
    public int? ClientSettings_Id { get; set; }
    public string LogoFileName { get; set; }
    public string LogoUrl { get; set; }
    public string StateName { get; set; }
}