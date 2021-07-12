using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using Model = Models;
using Entity = DL.Entities;
using System.Linq;

namespace DL
{
    public class ProductsRepository : IProductsRepository
    {
        private Entities.DemoDBContext _context;
        private object[] p_productID;

        public ProductsRepository(Entities.DemoDBContext p_context)
        {
            _context = p_context;
        }
        public bool AddProduct(Entity.Product p_product)
        {
            _context.Products.Add(new Entity.Product{
                Product_Id = p_product.ProductId,
                Product_Name = p_product.ProductName,
                ProductPrice = p_product.ProductPrice,
                Description = p_product.Description,
            });
            _context.SaveChanges();
            return true;
        }
        public List<Models.Products> GetAllProducts()
        {
            return _context.Products.Select(
                prod =>
                    new Models.Products()
                    {
                        Product_Id = prod.ProductId,
                        Product_Name = prod.Product_Name,
                        Product_Price = (decimal)prod.ProductPrice,
                        Product_Description = prod.Description,
                    }
            ).ToList();
        }

        public Models.Products GetProduct(int p_productsID)
        {
            var output =  _context.Products.Find(p_productID);

            return              
                new Models.Products()
                {
                    Product_Id = output.ProductId,
                    Product_Name = output.Product_Name,
                    Product_Price = (decimal)output.ProductPrice,
                    Product_Description= output.Description,
                };
        }

        public List<Model.Products> GetProducts()
        {
            throw new NotImplementedException();
        }
    }
}   
    
        
