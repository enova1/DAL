namespace DataAccess.BctModels;

public class EmailTemplate
{
    public int Id { get; set; }
    public string Subject { get; set; }
    public string Description { get; set; }
    public string Template { get; set; }
    public string TenantCode { get; set; }
    public bool Active { get; set; }
    public string CreatedBy_Id { get; set; }
    public DateTime? CreatedDate { get; set; }
    public string LastModifiedBy_Id { get; set; }
    public DateTime? LastModifiedDate { get; set; }
    public int? EmailType_Id { get; set; }
}