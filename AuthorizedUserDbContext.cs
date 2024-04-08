using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
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
        optionsBuilder.UseSqlite($"Data Source={AppDomain.CurrentDomain.BaseDirectory}WebApi.db");
        base.OnConfiguring(optionsBuilder);
    }

    /// <summary>
    /// AuthUser table in the database.
    /// </summary>
    public DbSet<AuthUser>? AuthUser { get; set; }

}