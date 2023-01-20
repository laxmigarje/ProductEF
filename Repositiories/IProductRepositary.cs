using ProductEF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductEF.Repositiories
{
   public interface IProductRepositary
    {
        List<Product> GetAllProducts();
        Product GetProductById(int id);
        int AddProduct(Product Prod);
        int UpdateProduct(Product prod);
        int DeleteProduct(int id);
        int AddStudent(Product prod);
    }
}
