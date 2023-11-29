using Microsoft.EntityFrameworkCore;
using RealDockerProject.Models;

namespace RealDockerProject.DataContext
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            Database.Migrate();
        }

        public DbSet<User> Users { get; set; }
    }
}
