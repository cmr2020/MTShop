﻿// <auto-generated />
using System;
using MTShop.DataLayer.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MTShop.DataLayer.Migrations
{
    [DbContext(typeof(MTShopContext))]
    partial class MTShopContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MTShop.DataLayer.Models.Product.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Category");
                });

            modelBuilder.Entity("MTShop.DataLayer.Models.Product.CategoryToProduct", b =>
                {
                    b.Property<int>("CP_Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId");

                    b.Property<int>("ProductId");

                    b.HasKey("CP_Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("ProductId");

                    b.ToTable("CategoryToProduct");
                });

            modelBuilder.Entity("MTShop.DataLayer.Models.Product.Item", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Price");

                    b.Property<int>("QuantityInStock");

                    b.HasKey("Id");

                    b.ToTable("Item");
                });

            modelBuilder.Entity("MTShop.DataLayer.Models.Product.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.Property<string>("ImageName")
                        .HasMaxLength(50);

                    b.Property<bool>("IsDelete");

                    b.Property<bool>("IsExist");

                    b.Property<int?>("ItemId");

                    b.Property<decimal>("Price");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.HasIndex("ItemId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("MTShop.DataLayer.Models.Product.ProductComment", b =>
                {
                    b.Property<int>("CommentId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Comment")
                        .IsRequired()
                        .HasMaxLength(1500);

                    b.Property<DateTime>("CreateDate");

                    b.Property<bool>("IsDelete");

                    b.Property<int?>("ParentId");

                    b.Property<int>("ProductId");

                    b.Property<int>("UserId");

                    b.HasKey("CommentId");

                    b.HasIndex("ParentId");

                    b.HasIndex("ProductId");

                    b.HasIndex("UserId");

                    b.ToTable("ProductComments");
                });

            modelBuilder.Entity("MTShop.DataLayer.Models.User.Role", b =>
                {
                    b.Property<int>("RoleId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("RoleTitle")
                        .IsRequired()
                        .HasMaxLength(150);

                    b.HasKey("RoleId");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("MTShop.DataLayer.Models.User.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ActivationCode")
                        .HasMaxLength(50);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<int?>("Id");

                    b.Property<bool>("IsActive");

                    b.Property<bool>("IsDelete");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<DateTime>("RegisterDate");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.HasKey("UserId");

                    b.HasIndex("Id")
                        .IsUnique()
                        .HasFilter("[Id] IS NOT NULL");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("MTShop.DataLayer.Models.User.UserPurchaseInformation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<string>("Mobile")
                        .HasMaxLength(20);

                    b.Property<string>("PostalCode")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.HasKey("Id");

                    b.ToTable("UserPurchaseInformations");
                });

            modelBuilder.Entity("MTShop.DataLayer.Models.User.UserRole", b =>
                {
                    b.Property<int>("UserRole_Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("RoleId");

                    b.Property<int>("UserId");

                    b.HasKey("UserRole_Id");

                    b.HasIndex("RoleId");

                    b.HasIndex("UserId");

                    b.ToTable("UserRoles");
                });

            modelBuilder.Entity("MTShop.DataLayer.Models.Product.CategoryToProduct", b =>
                {
                    b.HasOne("MTShop.DataLayer.Models.Product.Category", "Category")
                        .WithMany("CategoryToProducts")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("MTShop.DataLayer.Models.Product.Product", "Product")
                        .WithMany("CategoryToProducts")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MTShop.DataLayer.Models.Product.Product", b =>
                {
                    b.HasOne("MTShop.DataLayer.Models.Product.Item", "Item")
                        .WithMany()
                        .HasForeignKey("ItemId");
                });

            modelBuilder.Entity("MTShop.DataLayer.Models.Product.ProductComment", b =>
                {
                    b.HasOne("MTShop.DataLayer.Models.Product.ProductComment")
                        .WithMany("ProductComments")
                        .HasForeignKey("ParentId");

                    b.HasOne("MTShop.DataLayer.Models.Product.Product", "Product")
                        .WithMany("ProductComments")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("MTShop.DataLayer.Models.User.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MTShop.DataLayer.Models.User.User", b =>
                {
                    b.HasOne("MTShop.DataLayer.Models.User.UserPurchaseInformation", "UserPurchaseInformation")
                        .WithOne("User")
                        .HasForeignKey("MTShop.DataLayer.Models.User.User", "Id");
                });

            modelBuilder.Entity("MTShop.DataLayer.Models.User.UserRole", b =>
                {
                    b.HasOne("MTShop.DataLayer.Models.User.Role", "Role")
                        .WithMany("UserRoles")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("MTShop.DataLayer.Models.User.User", "User")
                        .WithMany("UserRoles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
