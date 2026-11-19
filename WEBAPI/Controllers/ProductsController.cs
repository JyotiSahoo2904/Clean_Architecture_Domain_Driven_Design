using Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Clean_Architecture_Domain_Driven_Design.Controllers
{
    public class ProductsController : ControllerBase
    {
        private readonly IProductRepository _repo;
        public ProductsController(IProductRepository repo) => _repo = repo;
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id) => Ok(await _repo.GetByIdAsync(id));
    }
}
