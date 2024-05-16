using Microsoft.EntityFrameworkCore;

namespace DataAccess
{
    /// <inheritdoc />
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options)
    {
    }
}