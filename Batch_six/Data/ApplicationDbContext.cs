
using System.Security.Claims;

using Batch_six.Domain;
using Microsoft.EntityFrameworkCore;

namespace Batch_six.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> option) : DbContext(option)
    {


        public DbSet<Book> Books { get; set; }
        public DbSet<Member> Memberships { get; set; }


       
        
       
    }
}