﻿using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccess.BctModels;

[Table("Admin_Client")]
public partial class Client
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Code { get; set; }
    public string? Email { get; set; }
    public bool Active { get; set; }

}