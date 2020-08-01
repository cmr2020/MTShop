using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Microsoft.AspNetCore.Http;
using MTShop.Core.Convertors;
using MTShop.Core.DTOs;
using MTShop.Core.Generator;
using MTShop.Core.Security;
using MTShop.Core.Services.Interfaces;
using MTShop.DataLayer.Context;
using MTShop.DataLayer.Models.Product;

namespace MTShop.Core.Services
{
    public partial class ProductService : IProductService
    {
        private MTShopContext _context { get; set; }

        public ProductService(MTShopContext context)
        {
            _context = context;
        }

        public void AddProduct(Product product, IFormFile imgProduct, List<IFormFile> productImages)
        {
            product.ImageName = "no-photo.png";

            if (imgProduct.IsImage() && imgProduct != null)
            {
                string imageName = product.ImageName;
                AddImageProduct(ref imageName, imgProduct);
                product.ImageName = imageName;
            }

            AddListImageToProduct(productImages,product);

            _context.Products.Add(product);
            _context.SaveChanges();
        }

        public void DeleteProductById(int productId)
        {
            Product product = GetProductById(productId);
            product.IsDelete = true;
            UpdateProduct(product);
        }

        public void UpdateProduct(Product product, IFormFile imgProduct = null/*todo get list images*/ )
        {
            if (imgProduct != null && imgProduct.IsImage())
            {
                if (product.ImageName != "no-photo.png")
                {
                    string deleteImagePath = Path.Combine(Directory.GetCurrentDirectory(),
                        "wwwroot/Images/Products/Image",
                        product.ImageName);
                    string deleteThumbPath = Path.Combine(Directory.GetCurrentDirectory(),
                        "wwwroot/Images/Products/Thumbnail",
                        product.ImageName);

                    if (File.Exists(deleteImagePath))
                    {
                        File.Delete(deleteImagePath);
                    }
                    if (File.Exists(deleteThumbPath))
                    {
                        File.Delete(deleteThumbPath);
                    }

                }

                string imageName = product.ImageName;
                AddImageProduct(ref imageName, imgProduct);
                product.ImageName = imageName;
            }
            _context.Products.Update(product);
            _context.SaveChanges();
        }

        public Product GetProductById(int productId)
        {
            return _context.Products.Find(productId);
        }

        public Tuple<List<ShowProductInBoxViewModel>, int> GetProducts(string filterName = "", string orderByType = "پرفروش ترین",
            decimal startPrice = 0, decimal endPrice = 0, int pageId = 1, int take = 0/*, List<int> selectedGroups = null*/)
        {
            IQueryable<Product> result = _context.Products;

            if (filterName != "")
            {
                result = result.Where(p => p.ImageName.Contains(filterName));
            }

            switch (orderByType)
            {
                //todo case پرفروش ترین
                case "گران ترین":
                    result = result.OrderByDescending(p => p.Price);
                    break;
                case "ارزان ترین":
                    result = result.OrderBy(p => p.Price);
                    break;
                    //todo default
            }

            if (startPrice > 0)
            {
                result = result.Where(p => p.Price > startPrice);
            }
            if (endPrice > 0)
            {
                result = result.Where(p => p.Price < 0);
            }

            //todo filter selectedGroups

            int skip = (pageId - 1) * take;

            int resultCount = result.Select(p => new ShowProductInBoxViewModel()
            {
                ImageName = p.ImageName,
                IsExist = p.IsExist,
                Price = p.Price,
                ProductId = p.Id,
                ProductName = p.ProductName
            }).Count();
            int pageCount = resultCount % take == 0 ? resultCount / take : resultCount / take + 1;

            var query = result.Select(p => new ShowProductInBoxViewModel()
            {
                ImageName = p.ImageName,
                IsExist = p.IsExist,
                Price = p.Price,
                ProductId = p.Id,
                ProductName = p.ProductName
            }).Skip(skip).Take(take).ToList();

            return Tuple.Create(query, pageCount);
        }
    }
}
