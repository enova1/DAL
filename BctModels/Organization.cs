using System.ComponentModel.DataAnnotations.Schema;
// ReSharper disable EntityFramework.ModelValidation.UnlimitedStringLength
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.

namespace DataAccess.BctModels;


[Table("Organization_Organization")]
public class Organization
{
    public int Id { get; set; }
    public bool Active { get; set; }

    public string LegalName { get; set; }

    public string CommonName { get; set; }
}