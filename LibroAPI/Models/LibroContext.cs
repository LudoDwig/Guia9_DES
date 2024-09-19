using Microsoft.EntityFrameworkCore;

namespace LibroAPI.Models
{
    public class LibrosDbContext : DbContext
    {
        public LibrosDbContext(DbContextOptions<LibrosDbContext> options) : base(options) { }

        public DbSet<Libro> LibroSet { get; set; }

    }
}
