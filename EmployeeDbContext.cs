using Microsoft.EntityFrameworkCore;
using Models.Employee;

namespace DataAccess
{
    public class EmployeeDbContext : DbContext
    {

        /// <inheritdoc />
        public EmployeeDbContext(DbContextOptions<EmployeeDbContext> options) : base(options)
        {
        }
        /// <summary>
        /// Employees tables in the database.
        /// </summary>
        public DbSet<Employees>? Employees { get; set; }
        public DbSet<EmployeePhones>? EmployeePhones { get; set; }
        public DbSet<EmployeeAddresses>? EmployeeAddresses { get; set; }
    }
}
