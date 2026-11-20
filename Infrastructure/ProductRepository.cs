using Application.Interfaces;
using Domain.Entities;

namespace Infrastructure
{
    public class ProductRepository:IProductRepository
    {
        public static List<Product> lstProducts = new List<Product>()
        {
           new Product{  Id =1 ,Name= "Product1"},
           new Product{  Id =2 ,Name= "Product2"},
           new Product{  Id =3 ,Name= "Product3"},
           new Product{  Id =4 ,Name= "Product4"},
           new Product{  Id =5 ,Name= "Product5"},
           new Product{  Id =6 ,Name= "Product6" }
        };
        public List<Product> GetAllProducts()
        {
            return lstProducts;
        }

        public async Task<Product> GetByIdAsync(int id)
        {
          
            return await Task.FromResult(lstProducts.FirstOrDefault(x => x.Id == id));
        }
        public async Task<List<Product>> GetAllProductsAsync()
        {
           
            return await Task.FromResult(lstProducts);
        }
    }
}
