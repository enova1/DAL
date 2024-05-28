using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccess.BctModels;

[Table("Email_Attachments")]
public class EmailAttachment
{
    public int Id { get; set; }
    public string Path { get; set; }
    public string ClientCode { get; set; }
    public bool Active { get; set; }
    public string CreatedBy_Id { get; set; }
    public DateTime? CreatedDate { get; set; }
    public string LastModifiedBy_Id { get; set; }
    public DateTime? LastModifiedDate { get; set; }
    public int? SystemEmail_Id { get; set; }
}