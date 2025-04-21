using Batch_six.Data;
using Batch_six.Domain;
using Batch_six.DTO;
using Microsoft.AspNetCore.Mvc;

namespace Batch_six.Controllers
{
    //https://localhost:xxxx/api/Doctor
    [Route("api/[controller]")]
    [ApiController]
    public class DoctorController : ControllerBase
    {
        private readonly ApplicationDbContext dbContext;

        public DoctorController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        //
        [HttpPost]
        public async Task<IActionResult> CreateDoctor(CreateDoctorRequestDto req)
        {
            // Map DTO Domain Model
            var Doctor = new Doctor
            {
                ContactNumber = req.ContactNumber,
                Specialty = req.Specialty,
                FullName = req.FullName,
                Email = req.Email,
                Qualification = req.Qualification,
                ExperienceYears = req.ExperienceYears
            };
            await dbContext.Doctor.AddAsync(Doctor);
            await dbContext.SaveChangesAsync();

            //Domain model to DTO
            var response = new DoctorDto
            {
                ContactNumber = Doctor.ContactNumber,
                Specialty = Doctor.Specialty,
                FullName = Doctor.FullName,
                Email = Doctor.Email,
                Qualification = Doctor.Qualification,
                ExperienceYears = Doctor.ExperienceYears
            };

            return Ok();
        }
    }
}
