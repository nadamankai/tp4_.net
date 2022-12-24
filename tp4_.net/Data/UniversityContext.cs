using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using tp4_.net.Models;

namespace tp4_.net.Data
{
    public class UniversityContext: DbContext
    {
        private static UniversityContext Singleton = null;

            public UniversityContext(DbContextOptions o) : base(o)
            {
               
            }
            public static UniversityContext Instantiate_UniversityContext()
            {
                var optionsBuilder = new DbContextOptionsBuilder<UniversityContext>();
                optionsBuilder.UseSqlite("Data source=C:\\Users\\nadam\\OneDrive\\Bureau\\tp 3 .net\\tp4_.net\\tp4_.net\\database.db");

                return new UniversityContext(optionsBuilder.Options);
            }
            public static UniversityContext getInstance()
            {
                if (Singleton == null)
                {
                    Singleton = Instantiate_UniversityContext();

                }
                return Singleton;
            }
            public DbSet<Student> Student { get; set; }
        }
}
