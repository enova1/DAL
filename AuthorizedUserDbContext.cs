using Microsoft.EntityFrameworkCore;
using Models;

namespace DataAccess;

public class AuthorizedUserDbContext : DbContext
{

    /// <inheritdoc />
    public AuthorizedUserDbContext(DbContextOptions<AuthorizedUserDbContext> options) : base(options)
    {
    }
    /// <summary>
    /// AuthUser table in the database.
    /// </summary>
    public DbSet<AuthUser>? AuthUser { get; set; }

}