using Mentormate.Example.Controllers.Models;
using Mentormate.Example.Domain.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Mentormate.Example.Controllers.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpPost("")]
        public async Task<IActionResult> PostProduct([FromBody] CreateProductDTO createProductDTO)
        {
            var guid = await _productService.CreateProductAsync(new Entities.Commands.CreateProductCommand
            {
                Name = createProductDTO.Name,
                Description = createProductDTO.Description,
                CreatedBy = HttpContext.User.Identity.Name
            });
            return Ok(guid);
        }
    }
}
