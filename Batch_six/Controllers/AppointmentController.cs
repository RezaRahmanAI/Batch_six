using Batch_six.Data;
using Batch_six.DTO;
using Microsoft.AspNetCore.Mvc;

namespace Batch_six.Controllers
{
    //https://localhost:xxxx/api/Doctor
    [Route("api/[controller]")]
    [ApiController]
    public class AppointmentController : ControllerBase 
    {
        private readonly ApplicationDbContext dbContext;
        public AppointmentController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        //
        [HttpPost]
        public async Task<IActionResult> CreateAppointment(CreateDoctorRequestDto req)
        {
            // Map DTO Domain Model
            var Appointment= new Appointment
            {
                 AppointmentDate = DateTime.Now,
            };
            await dbContext.Apointment.AddAsync(Appointment);
            await dbContext.SaveChangesAsync();

            //Domain model to DTO
            var response = new AppointmentDto
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
