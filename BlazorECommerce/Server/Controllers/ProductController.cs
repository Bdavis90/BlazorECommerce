using BlazorECommerce.Server.Services.ProductService;
using BlazorECommerce.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlazorECommerce.Server.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService productService;

        public ProductController(IProductService productService)
        {
            this.productService = productService;
        }
        [HttpGet]
        public async Task<ActionResult<List<Product>>> GetAllProducts()
        {
            return Ok(await productService.GetAllProducts());
        }

        [HttpGet("{categoryUrl}")]
        public async Task<ActionResult<List<Product>>> GetAllByCategory(string categoryUrl)
        {
            return Ok(await productService.GetProductsByCategory(categoryUrl));
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<Product>> GetProduct(int id)
        {
            return Ok(await productService.GetProduct(id));
        }
    }
}
