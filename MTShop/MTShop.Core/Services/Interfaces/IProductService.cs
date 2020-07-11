using System;
using System.Collections.Generic;
using System.Text;
using MTShop.DataLayer.Models.Product;

namespace MTShop.Core.Services.Interfaces
{
    public interface IProductService
    {
        void AddProduct(Product product);

        void UpdateProduct(Product product);

        void DeleteProductById(int productId);

        Product GetProductById(int productId);
    }
}
