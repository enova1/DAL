using System.ComponentModel.DataAnnotations.Schema;
// ReSharper disable EntityFramework.ModelValidation.UnlimitedStringLength
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.

namespace DataAccess.BctModels;

[Table("FundSource_FundSourceType")]
public class FundSourceType
{
    public int Id { get; set; }

    public bool Active { get; set; }

    public string Type { get; set; }

    public string Name { get; set; }

    public string CommonName { get; set; }

}