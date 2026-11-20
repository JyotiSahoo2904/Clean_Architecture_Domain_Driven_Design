using Domain.Entities;

namespace Application.Services
{
    public interface IProductService
    {
        Task<List<Product>> GetAllProducts();

        Task<Product> GetByIdAsync(int id);
    }
}
