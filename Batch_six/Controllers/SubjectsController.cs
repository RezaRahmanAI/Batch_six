using Batch_six.Data;
using Batch_six.Domain;
using Batch_six.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Batch_six.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubjectsController : ControllerBase
    {
        private readonly ApplicationDbContext dbContext;

        public SubjectsController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }



        //
        [HttpPost]
        public async Task<IActionResult> CreateSubjects(CreateSubjectRequestDto request)
        {
            //map DTO to Domain Model
            var subject = new Subject

            {
                Id = request.Id,
                SubjectName = request.SubjectName,
                SubjectCode = request.SubjectCode,

                


            };

            await dbContext.Subjects.AddAsync(subject);
            await dbContext.SaveChangesAsync();

            // map model to DTO
            var response = new SubjectDto
            {
                Id = subject.Id,
                SubjectName = subject.SubjectName,
                SubjectCode = subject.SubjectCode,


            };

            return Ok(response);


        }
    }
}
