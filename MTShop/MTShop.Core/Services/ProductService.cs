using System;
using System.Collections.Generic;
using System.Text;
using MTShop.Core.Services.Interfaces;
using MTShop.DataLayer.Context;
using MTShop.DataLayer.Models.Product;

namespace MTShop.Core.Services
{
    public class ProductService : IProductService
    {
        private MTShopContext _context { get; set; }

        public ProductService(MTShopContext context)
        {
            _context = context;
        }

        public void AddProduct(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
        }

        public void DeleteProductById(int productId)
        {
            Product product = GetProductById(productId);
            product.IsDelete = true;
            UpdateProduct(product);
        }

        public void UpdateProduct(Product product)
        {
            _context.Products.Update(product);
            _context.SaveChanges();
        }

        public Product GetProductById(int productId)
        {
           return _context.Products.Find(productId);
        }
    }
}
