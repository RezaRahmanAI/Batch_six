using Batch_six.Data;
using Batch_six.Domain;
using Batch_six.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Batch_six.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly ApplicationDbContext dbContext;

        public StudentsController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }



        //
        [HttpPost]
        public async Task<IActionResult> CreateStudents(CreateStudentRequestDto request)
        {
            //map DTO to Domain Model
            var student = new Student

            {
                Id = request.Id,
                Name = request.Name,
                Email = request.Email,
                Phone = request.Phone,
                Address = request.Address,
                DateOfBirth = request.DateOfBirth,
                Gender = request.Gender,
                AdmissionDate = request.AdmissionDate,
                PhotoPath = request.PhotoPath,
                RollNumber = request.RollNumber,
                Status = request.Status,


            };

            await dbContext.Students.AddAsync(student);
            await dbContext.SaveChangesAsync();

            // map model to DTO
            var response = new StudentDto
            {
                Id = student.Id,
                Name = student.Name,
                Email = student.Email,
                Phone = student.Phone,
                Address = student.Address,
                DateOfBirth = student.DateOfBirth,
                Gender = student.Gender,
                AdmissionDate = student.AdmissionDate,
                PhotoPath = student.PhotoPath,
                RollNumber = student.RollNumber,
                Status = student.Status,

            };

            return Ok(response);


        }
    }
}
