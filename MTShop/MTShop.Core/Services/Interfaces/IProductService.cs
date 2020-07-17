using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Http;
using MTShop.Core.DTOs;
using MTShop.DataLayer.Models.Product;

namespace MTShop.Core.Services.Interfaces
{
    public interface IProductService
    {
        void AddProduct(Product product, IFormFile imgProduct /*todo get list images*/);
        void AddFirstImageProduct(ref Product product, IFormFile imgProduct);

        void UpdateProduct(Product product, IFormFile imgProduct /*todo get list images*/ );

        void DeleteProductById(int productId);

        Tuple<List<ShowProductInBoxViewModel>,int> GetProducts(string filterName = "", string orderByType = "پرفروش ترین"
            , decimal startPrice = 0, decimal endPrice = 0, int pageId = 1, int take = 0/*, List<int> selectedGroups = null*/);
        Product GetProductById(int productId);

    }
}
