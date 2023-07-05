using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using School_MVC.Models;

namespace School_MVC.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base( options ) { }
        public DbSet<School> schools { get; set; }
    }
}
