using Autohaendler.Models;
using Microsoft.EntityFrameworkCore;

namespace Autohaendler.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {

        }

        // DB-Sets for project
        public DbSet<Auto> Auto { get; set; }
        public DbSet<Autoverkaeufe> Autoverkaeufe { get; set; }
        public DbSet<Hersteller> Hersteller { get; set; }
        public object RegForms { get; internal set; }
    }
}
