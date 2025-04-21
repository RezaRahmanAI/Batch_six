using Microsoft.EntityFrameworkCore;

namespace Batch_six.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> option) : DbContext(option)
    {
    }
}
