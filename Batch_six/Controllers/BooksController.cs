using Batch_six.Data;
using Batch_six.Domain;
using Batch_six.DTO;
using Microsoft.AspNetCore.Mvc;

namespace Batch_six.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly ApplicationDbContext _dbContext;

        public BooksController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpPost]
        public async Task<IActionResult> CreateBook(CreateBookRequestDto request)
        {
            var book = new Book
            {
                Author = request.Author,
                Title = request.Title
            };

            await _dbContext.Books.AddAsync(book);
            await _dbContext.SaveChangesAsync();

            var response = new BookDto
            {
                Id = book.Id,
                Author = book.Author,
                Title = book.Title
            };

            return Ok(response); // Capital 'O'
        }
    }
}
