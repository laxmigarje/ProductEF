using ProductEF.Models;
using ProductEF.Repositiories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductEF.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepositary repo;
       public  ProductService(IProductRepositary repo)
        {
            this.repo = repo;
        }
        public int AddProduct(Product prod)
        {
            prod.IsActive = 1;
            return repo.AddStudent(prod);
        }

        public int DeleteProduct(int id)
        {
            return repo.DeleteProduct(id);
        }

        public List<Product> GetAllProducts()
        {
            return repo.GetAllProducts();
        }

        public Product GetProductById(int id)
        {
            return repo.GetProductById(id);
        }

        public int UpdateProduct(Product prod)
        {
            return repo.UpdateProduct(prod);
        }

    }
}
