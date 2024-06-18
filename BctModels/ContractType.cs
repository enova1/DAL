using System.ComponentModel.DataAnnotations.Schema;
// ReSharper disable PropertyCanBeMadeInitOnly.Global
// ReSharper disable EntityFramework.ModelValidation.UnlimitedStringLength
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.

namespace DataAccess.BctModels;

[Table("Project_ContractType")]
public class ContractType
{
    public int Id { get; set; }

    public bool Active { get; set; }

    public string Name { get; set; }
}