using ProductEF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductEF.Services
{
  public  interface IProductService
    {
        List<Product> GetAllProducts();
        Product GetProductById(int id);
        int AddProduct(Product prod);
        int UpdateProduct(Product prod);
        int DeleteProduct(int id);
    }
}
