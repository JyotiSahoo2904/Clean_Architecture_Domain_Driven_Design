using Application.Interfaces;
using Domain.Entities;

namespace Application.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            this._productRepository = productRepository;
        }

        public async Task<Product> GetByIdAsync(int id)
        {
            var product = await _productRepository.GetByIdAsync(id);

            return product;
        }

        public async Task<List<Product>> GetAllProducts()
        {
            // Fix: Ensure the repository method is asynchronous and returns Task<List<Product>>
            var products = await _productRepository.GetAllProductsAsync();
            return products;
        }
    }
}
