using Batch_six.Data;
using Batch_six.Domain;
using Batch_six.DTO;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Batch_six.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly ApplicationDbContext dbContext;

        public ProductsController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpPost]
        public async Task<IActionResult> CreateProduct(CreateProductsRequestDto request)
        {
            // Map DTO to Domain Model
            var product = new Product
            {
                Name = request.Name,
                UrlHandle = request.UrlHandle
            };

            await dbContext.Products.AddAsync(product);
            await dbContext.SaveChangesAsync();

            // Domain Model to DTO
            var response = new ProductDto
            {
                Id = product.Id,
                Name = product.Name,
                UrlHandle = product.UrlHandle
            };

            return Ok(response); // Return created product info
        }
    }
}
