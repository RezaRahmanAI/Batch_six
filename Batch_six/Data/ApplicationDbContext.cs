using Batch_six.Domain;
using Microsoft.EntityFrameworkCore;

namespace Batch_six.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> option) : DbContext(option)
    {
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Class> Classs { get; set; }
        public DbSet<Student> Students { get; set; }

    }
}
