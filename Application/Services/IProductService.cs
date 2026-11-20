using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public interface IProductService
    {
        Task<List<Product>> GetAllProducts();

        Task<Product> GetByIdAsync(int id);
    }
}
