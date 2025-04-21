using Batch_six.Data;
using Batch_six.Domain;
using Batch_six.DTO;
using Microsoft.AspNetCore.Mvc;

namespace Batch_six.Controllers
{
    //https://localhost:xxxx/api/Doctor
    [Route("api/[controller]")]
    [ApiController]
    public class PatientController : ControllerBase
    {
        private readonly ApplicationDbContext dbContext;

        public PatientController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        //
        [HttpPost]
        public async Task<IActionResult> CreatePatient(CreatePatientRequestDto req)
        {
            // Map DTO Domain Model
            var Patient = new Patient
            {
                FullName = req.FullName,
                DateOfBirth = req.DateOfBirth,
                Gender = req.Gender,
                ContactNumber = req.ContactNumber,
                Address = req.Address,
                BloodGroup = req.BloodGroup,
                MedicalHistory = req.MedicalHistory,
            };
            await dbContext.Patient.AddAsync(Patient);
            await dbContext.SaveChangesAsync();
            //Domain model to DTO
            var response = new PatientDto
            {
                FullName = Patient.FullName,
                DateOfBirth = Patient.DateOfBirth,
                Gender = Patient.Gender,
                ContactNumber = Patient.ContactNumber,
                Address = Patient.Address,
                BloodGroup = Patient.BloodGroup,
                MedicalHistory = Patient.MedicalHistory
            };

            return Ok();
        }
    }

}
