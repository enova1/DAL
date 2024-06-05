using System.ComponentModel.DataAnnotations.Schema;
// ReSharper disable EntityFramework.ModelValidation.UnlimitedStringLength
// ReSharper disable InconsistentNaming
// ReSharper disable PropertyCanBeMadeInitOnly.Global
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.


namespace DataAccess.BctModels;

[Table("Contact_Contact")]
public class Contact 
{
    public int Id { get; set; }
    public bool Active { get; set; }

    public string AppUser_Id { get; set; }

    public string Salutation { get; set; }

    public string FirstName { get; set; }

    public string MiddleInitial { get; set; }

    public string LastName { get; set; }

    public string Title { get; set; }

    public string PrimaryPhone { get; set; }

    public string PrimaryPhoneExt { get; set; }

    public string AlternatePhone { get; set; }

    public string AlternatePhoneExt { get; set; }

    public string PrimaryEmail { get; set; }

    public string SecondaryEmail { get; set; }

    public string Notes { get; set; }

    public string Fax { get; set; }

    public string ContactType { get; set; }

    public bool IsCreateUser { get; set; }
}