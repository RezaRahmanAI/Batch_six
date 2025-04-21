using Batch_six.Domain;
using Microsoft.EntityFrameworkCore;

namespace Batch_six.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> option) : DbContext(option)
    {
      
        public DbSet<Product> Products { get; set; }
       
        public DbSet<User> Users { get; set; }

    }

}


