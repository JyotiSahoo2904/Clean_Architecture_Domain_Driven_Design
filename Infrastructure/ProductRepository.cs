using Application.Interfaces;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public class ProductRepository:IProductRepository
    {
        public async Task<Product> GetByIdAsync(int id)
        {
           Product product = new Product { Id = 1, Name = "Sample Product" };
            return await Task.FromResult(product);
        }
    }
}
