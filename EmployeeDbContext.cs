using Microsoft.EntityFrameworkCore;
using Models.Employee;

namespace DataAccess
{
    public class EmployeeDbContext : DbContext
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
        /// Employees tables in the database.
        /// </summary>
        public DbSet<Employees>? Employees { get; set; }
        public DbSet<EmployeePhones>? EmployeePhones { get; set; }
        public DbSet<EmployeeAddresses>? EmployeeAddresses { get; set; }
    }
}
