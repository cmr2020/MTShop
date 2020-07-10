using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using MTShop.DataLayer.Models.Product;
using MTShop.DataLayer.Models.User;

namespace MTShop.DataLayer.Context
{
    public class MTShopContext : DbContext
    {

        public MTShopContext(DbContextOptions<MTShopContext> options) : base(options)
        {

        }

        #region User

        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<UserPurchaseInformation> UserPurchaseInformations { get; set; }

        #endregion

        #region Product

        public DbSet<Product> Products { get; set; }
        public DbSet<ProductComment> ProductComments { get; set; }

        #endregion

        // protected override void OnModelCreating(ModelBuilder modelBuilder)
        // {
        //     modelBuilder.Entity<CategoryToProduct>()
        //         .HasKey(t => new { t.ProductId, t.CategoryId });
        //
        //     base.OnModelCreating(modelBuilder);
        // }


    }
}
