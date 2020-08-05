using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Microsoft.AspNetCore.Http;
using MTShop.Core.Convertors;
using MTShop.Core.Generator;
using MTShop.Core.Security;
using MTShop.Core.Services.Interfaces;
using MTShop.DataLayer.Models.Product;

namespace MTShop.Core.Services
{
    public partial class ProductService : IProductService
    {
        private readonly string internalImagePath = "wwwroot/Images/Products/Image";
        private readonly string internalThumbnailPath = "wwwroot/Images/Products/Thumbnail";

        public void AddImageProduct(ref string imageName, IFormFile imgProduct)
        {
            imageName = NameGenerator.GenerateUniqCode() + Path.GetExtension(imgProduct.FileName);

            string imagePath = Path.Combine(Directory.GetCurrentDirectory(), internalImagePath, imageName);
            string thumbnailPath = Path.Combine(Directory.GetCurrentDirectory(), internalThumbnailPath, imageName);

            using (var stream = new FileStream(imagePath, FileMode.Create))
            {
                imgProduct.CopyTo(stream);
            }
            new ImageConvertor().Image_resize(imagePath, thumbnailPath, 200);
        }

        public void AddListImageToProduct(List<IFormFile> productImages, Product product)
        {
            if (productImages != null)
            {
                foreach (IFormFile image in productImages)
                {
                    if (image.IsImage())
                    {
                        var productImage = new ProductImage();

                        string imageName = productImage.Images;
                        AddImageProduct(ref imageName, image);

                        productImage.Images = imageName;
                        productImage.ProductId = product.Id;
                        productImage.Product = product;

                        _context.ProductImages.Add(productImage);
                    }

                }
            }
        }

        public void DeleteImageProduct(string imageName)
        {
            string deleteImagePath = Path.Combine(Directory.GetCurrentDirectory(),
                internalImagePath,
                imageName);
            string deleteThumbPath = Path.Combine(Directory.GetCurrentDirectory(),
                internalThumbnailPath,
                imageName);

            if (File.Exists(deleteImagePath))
            {
                File.Delete(deleteImagePath);
            }
            if (File.Exists(deleteThumbPath))
            {
                File.Delete(deleteThumbPath);
            }
        }
    }
}
