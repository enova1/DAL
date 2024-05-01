using Microsoft.EntityFrameworkCore;

namespace DataAccess
{
    public class ApplicationDbContext44 : DbContext
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

    }
}