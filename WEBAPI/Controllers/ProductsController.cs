using Application.Services;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Clean_Architecture_Domain_Driven_Design.Controllers
{
    [ApiController]
    [Route("api/[controller]")]    
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductsController(IProductService productService) => _productService = productService;

        [HttpGet("all")]
        public async  Task<List<Product>> Get()
        {
            var products = await _productService.GetAllProducts();
            return products;
        }
       
        [HttpGet("{id}")]
        public async Task<Product> Get(int id)
        {
            var product = await _productService.GetByIdAsync(id);
            return product;
        }
    }
}
