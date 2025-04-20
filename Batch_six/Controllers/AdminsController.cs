using Batch_six.Data;
using Batch_six.Domain;
using Batch_six.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Batch_six.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminsController : ControllerBase
    {
        private readonly ApplicationDbContext dbContext;

        public AdminsController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }



        //
        [HttpPost]
        public async Task<IActionResult> CreateAdmins(CreateAdminRequestDTO request)
        {
            //map DTO to Domain Model
            var admin = new Admin

            {
                Id = request.Id,
                Name = request.Name,
                Email = request.Email,
                Password = request.Password,


            }; 

            await dbContext.Admins.AddAsync(admin);
            await dbContext.SaveChangesAsync();

            // map model to DTO
            var response = new AdminDto
            {
                Id = admin.Id,
                Name = admin.Name,
                Email = admin.Email,
                Password = admin.Password,

            };

            return Ok(response);
        }
    }
}
