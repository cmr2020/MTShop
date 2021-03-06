﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;
using MTShop.Core.Services.Interfaces;
using MTShop.DataLayer.Models.Product;

namespace MTShop.Core.Services
{
    public partial class ProductService : IProductService
    {
        public void AddComment(ProductComment comment)
        {
            comment.CreateDate = DateTime.Now;
            comment.IsDelete = false;

            _context.ProductComments.Add(comment);
            _context.SaveChanges();
        }

        public void UpdateComment(ProductComment comment)
        {
            _context.ProductComments.Update(comment);
            _context.SaveChanges();
        }

        public void DeleteComment(int CommentId)
        {
            var comment = GetCommentById(CommentId);
            DeleteComment(comment);
        }

        public void DeleteComment(ProductComment comment)
        {
            comment.IsDelete = true;
            UpdateComment(comment);
        }

        public Tuple<List<ProductComment>, int> GetProductComments(int take, int pageid, int productId)
        {
            _context.ProductComments.Where(pc => pc.ProductId == productId);
            return null;
            // todo
        }

        public Tuple<List<ProductComment>, int> GetUnreadComments(int take = 20, int pageId = 1)
        {
            List<ProductComment> productComments = _context.ProductComments
                .Include(pc => pc.User)
                .Include(pc => pc.Product)
                .Where(pc => pc.IsRead == false)
                .OrderByDescending(pc => pc.CreateDate).ToList();

            int skip = (pageId - 1) * take;

            int productCommentCount = productComments.Count();
            int pageCount = productCommentCount % take == 0 ? productCommentCount / take : productCommentCount / take + 1;

            return Tuple.Create(productComments.Skip(skip).Take(take).ToList(), pageCount);
        }

        public ProductComment GetCommentById(int commentId)
        {
            return _context.ProductComments.Find(commentId);
        }
    }
}
