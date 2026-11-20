using Domain.Entities;

namespace Application.Interfaces
{
    public interface IProductRepository
    {
        Task<List<Product>> GetAllProductsAsync();
        Task<Product> GetByIdAsync(int id);
    }
}
