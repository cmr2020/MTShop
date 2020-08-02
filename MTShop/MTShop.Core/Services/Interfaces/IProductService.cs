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
        #region Add

        void AddProduct(Product product, IFormFile imgProduct , List<IFormFile> productImages);

        void AddImageProduct(ref string imageName, IFormFile imgProduct);
        void AddListImageToProduct(List<IFormFile> productImages, Product product);

        void AddComment(ProductComment comment);

        #endregion

        #region Update

        void UpdateProduct(Product product, IFormFile imgProduct /*todo get list images*/ );

        void UpdateComment(ProductComment comment);

        #endregion

        #region Delete

        void DeleteProductById(int productId);

        void DeleteComment(int CommentId);
        void DeleteComment(ProductComment comment);

        #endregion

        #region Get

        Tuple<List<ShowProductInBoxViewModel>, int> GetProducts(string filterName = "", string orderByType = "پرفروش ترین"
            , decimal startPrice = 0, decimal endPrice = 0, int pageId = 1, int take = 0/*, List<int> selectedGroups = null*/);
        Product GetProductById(int productId);

        Tuple<List<ProductComment>, int> GetProductComment(int take, int pageid, int productId);

        ProductComment GetCommentById(int commentId);

        #endregion


    }
}
