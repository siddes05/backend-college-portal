using Microsoft.EntityFrameworkCore;
using AngAssesment.Models;

namespace AngAssesment.Database
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options) { }

        public DbSet<Student> Students { get; set; }    

        public DbSet<Department> Departments { get; set; }
    }
}
