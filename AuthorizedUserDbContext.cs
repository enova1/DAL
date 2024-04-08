using Microsoft.EntityFrameworkCore;
using Models;

namespace DataAccess;

public class AuthorizedUserDbContext : DbContext
{

    /// <summary>
    /// OnConfiguring method to configure the database connection.
    /// </summary>
    /// <param name="optionsBuilder"></param>
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite($"Data Source=C:\\Users\\kozlo\\source\\GitHub\\DAL\\DataAccess\\bin\\Debug\\net8.0\\WebApi.db");
        base.OnConfiguring(optionsBuilder);
    }

    /// <summary>
    /// AuthUser table in the database.
    /// </summary>
    public DbSet<AuthUser>? AuthUser { get; set; }

}