using System.ComponentModel.DataAnnotations.Schema;
// ReSharper disable InconsistentNaming

namespace DataAccess.BctModels;


[Table("Project_Contract")]
public class Contract
{
    public int Id { get; set; }

    public int Organization_Id { get; set; }

    public int Client_Id { get; set; }

    public DateTime? ExpirationDate { get; set; }

    public int ContractYear { get; set; }

    public int FundSourceType_Id { get; set; }

    public int ContractType_Id { get; set; }
}