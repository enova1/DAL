using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccess.BctModels;

[Table("Project_ContractType")]
public class ContractType
{
    public int Id { get; set; }

    public bool Active { get; set; }

    public string Name { get; set; }
}