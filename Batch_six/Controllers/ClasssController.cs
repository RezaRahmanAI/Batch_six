using Azure.Core;
using Batch_six.Data;
using Batch_six.Domain;
using Batch_six.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Batch_six.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClasssController : ControllerBase

    {
        private readonly ApplicationDbContext dbContext;

        public ClasssController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }



        //
        [HttpPost]
        public async Task<IActionResult> CreateClasses(CreateClassRequestDto request)
        {
            //map DTO to Domain Model
            var classs = new Class

            {
                Id = request.Id,
                ClassName = request.ClassName,
                StartYear = request.StartYear,
                Section = request.Section,
                EndYear = request.EndYear,


            };

            await dbContext.Classs.AddAsync(classs);
            await dbContext.SaveChangesAsync();

            // map model to DTO
            var response = new ClassDto
            {
                Id = classs.Id,
                ClassName = classs.ClassName,
                StartYear = classs.StartYear,
                Section= classs.Section,
                EndYear = classs.EndYear,

            };

            return Ok(response);
        }
    }
}
