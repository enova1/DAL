using System.ComponentModel.DataAnnotations.Schema;

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
}   