using Batch_six.Data;
using Batch_six.Domain;
using Batch_six.Repositories.Interface;

namespace Batch_six.Repositories.Implementation
{
    public class AdminRepository : IAdminRepository
    {
        private readonly ApplicationDbContext dbContext;

        public AdminRepository(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }



        public async Task<Admin> CreateAsync(Admin admin)
        {
            await dbContext.Admins.AddAsync(admin);
            await dbContext.SaveChangesAsync();

            return admin; 

        }
    }
}
