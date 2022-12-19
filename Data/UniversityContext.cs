using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System.Diagnostics;
using tp4dotnet.Models;

namespace tp4dotnet.Data
{
    public class UniversityContext : DbContext
    {
         public DbSet<Student> Student { get; set; }

        private static UniversityContext instance;
        private UniversityContext(DbContextOptions options) : base(options) { }

        public static UniversityContext Instantiate_UniversityContext()
        {
            var optionsBuilder = new DbContextOptionsBuilder<UniversityContext>();

            optionsBuilder.UseSqlite("Data Source = C:\\Users\\safaw\\source\\repos\\tp4dotnet\\2022 GL3 .NET Framework TP4 - SQLite database.db");

            if (instance == null)
            {
                Debug.WriteLine("First and last instantiation.....");
                instance = new UniversityContext(optionsBuilder.Options);
            }
            else
            {
                Debug.WriteLine("UniversityContext class has been already instantiated");
            }

            return instance;
        }

    }
}
