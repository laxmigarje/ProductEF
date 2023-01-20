using ProductEF.Data;
using ProductEF.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ProductEF.Repositiories
{
    public class ProductRepositary : IProductRepositary
    {
        private readonly ApplicationDbContext db;
        public ProductRepositary(ApplicationDbContext db)
        {
            this.db = db;
        }

       
        public int AddProduct(Product prod)
        {
            db.Products.Add(prod);
            int res = db.SaveChanges();
            return res;
        }

        public int AddStudent(Product prod)
        {
            throw new NotImplementedException();
        }

        public int DeleteProduct(int id)
        {
            int res = 0;
            var s = db.Products.Where(x => x.Id == id).FirstOrDefault();
            if (s != null)
            {
                s.IsActive = 0;
                res = db.SaveChanges();

            }
            return res;
        }

       
        public List<Product> GetAllProducts()
        {
            var model = (from s in db.Products
                         where s.IsActive == 1
                         select s).ToList();

            return model;
        }

        
        public Product GetProductById(int id)
        {
            var s = db.Products.Where(x => x.Id == id).FirstOrDefault();
            return s;

        }

       
        public int UpdateProduct(Product prod)
        {
            int res = 0;
            var s = db.Products.Where(x => x.Id == prod.Id).FirstOrDefault();
            if (s != null)
            {
                s.pid = prod.pid;
                s.pname = prod.pname;
                s.company = prod.company;
                s.price = prod.price;
                s.password = prod.password;
                
                s.IsActive = 1;
                res = db.SaveChanges();

            }
            return res;
        }
    }
}

    

