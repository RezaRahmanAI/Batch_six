using Batch_six.Data;
using Batch_six.Domain;
using Batch_six.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Batch_six.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeachersController : ControllerBase
    {
        private readonly ApplicationDbContext dbContext;

        public TeachersController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }



        //
        [HttpPost]
        public async Task<IActionResult> CreateTeachers(CreateTeacherRequestDto request)
        {
            //map DTO to Domain Model
            var teacher = new Teacher

            {
                 Id = request.Id,
                 Name = request.Name,
                 Email = request.Email,
                 Phone = request.Phone,
                 Address = request.Address,
                 DateOfBirth = request.DateOfBirth,
                 Gender = request.Gender,
                 JoiningDate = request.JoiningDate,
                 Qualification = request.Qualification,
                 Experience = request.Experience,
                 PhotoPath = request.PhotoPath,
                 Status = request.Status,





    };

            await dbContext.Teachers.AddAsync(teacher);
            await dbContext.SaveChangesAsync();

            // map model to DTO
            var response = new TeacherDto
            {
                Id = teacher.Id,
                Name = teacher.Name,
                Email = teacher.Email,
                Phone = teacher.Phone,
                Address = teacher.Address,
                DateOfBirth = teacher.DateOfBirth,
                Gender = teacher.Gender,
                JoiningDate = teacher.JoiningDate,
                Qualification = teacher.Qualification,
                Experience = teacher.Experience,
                PhotoPath = teacher.PhotoPath,
                Status = teacher.Status,



            };

            return Ok(response);


        }
    }
}
