using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MTShop.DataLayer.Migrations
{
    public partial class ini_relatin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Category_Products_ProductId",
                table: "Category");

            migrationBuilder.DropForeignKey(
                name: "FK_CategoryToProduct_Category_CategoryId1",
                table: "CategoryToProduct");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CategoryToProduct",
                table: "CategoryToProduct");

            migrationBuilder.DropIndex(
                name: "IX_CategoryToProduct_CategoryId1",
                table: "CategoryToProduct");

            migrationBuilder.DropIndex(
                name: "IX_Category_ProductId",
                table: "Category");

            migrationBuilder.DropColumn(
                name: "CategoryId1",
                table: "CategoryToProduct");

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "Category");

            migrationBuilder.AddColumn<int>(
                name: "ItemId",
                table: "Products",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CategoryId",
                table: "CategoryToProduct",
                nullable: false,
                oldClrType: typeof(int))
                .OldAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddColumn<int>(
                name: "CP_Id",
                table: "CategoryToProduct",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddPrimaryKey(
                name: "PK_CategoryToProduct",
                table: "CategoryToProduct",
                column: "CP_Id");

            migrationBuilder.CreateTable(
                name: "Item",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Price = table.Column<decimal>(nullable: false),
                    QuantityInStock = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Item", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_ItemId",
                table: "Products",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoryToProduct_CategoryId",
                table: "CategoryToProduct",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_CategoryToProduct_Category_CategoryId",
                table: "CategoryToProduct",
                column: "CategoryId",
                principalTable: "Category",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Item_ItemId",
                table: "Products",
                column: "ItemId",
                principalTable: "Item",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CategoryToProduct_Category_CategoryId",
                table: "CategoryToProduct");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Item_ItemId",
                table: "Products");

            migrationBuilder.DropTable(
                name: "Item");

            migrationBuilder.DropIndex(
                name: "IX_Products_ItemId",
                table: "Products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CategoryToProduct",
                table: "CategoryToProduct");

            migrationBuilder.DropIndex(
                name: "IX_CategoryToProduct_CategoryId",
                table: "CategoryToProduct");

            migrationBuilder.DropColumn(
                name: "ItemId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "CP_Id",
                table: "CategoryToProduct");

            migrationBuilder.AlterColumn<int>(
                name: "CategoryId",
                table: "CategoryToProduct",
                nullable: false,
                oldClrType: typeof(int))
                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddColumn<int>(
                name: "CategoryId1",
                table: "CategoryToProduct",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProductId",
                table: "Category",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_CategoryToProduct",
                table: "CategoryToProduct",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoryToProduct_CategoryId1",
                table: "CategoryToProduct",
                column: "CategoryId1");

            migrationBuilder.CreateIndex(
                name: "IX_Category_ProductId",
                table: "Category",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_Category_Products_ProductId",
                table: "Category",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CategoryToProduct_Category_CategoryId1",
                table: "CategoryToProduct",
                column: "CategoryId1",
                principalTable: "Category",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
