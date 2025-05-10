using Batch_six.Domain;

namespace Batch_six.Repositories.Interface
{
    public interface IAdminRepository
    {
        Task<Admin> CreateAsync(Admin admin);
    }
}
