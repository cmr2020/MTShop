using Microsoft.EntityFrameworkCore.Migrations;

namespace MTShop.DataLayer.Migrations
{
    public partial class Test6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductComments_Products_Id",
                table: "ProductComments");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductComments_ProductComments_ParentId",
                table: "ProductComments");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductComments_Users_UserId",
                table: "ProductComments");

            migrationBuilder.DropIndex(
                name: "IX_ProductComments_Id",
                table: "ProductComments");

            migrationBuilder.DropIndex(
                name: "IX_ProductComments_UserId",
                table: "ProductComments");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "ProductComments");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "ProductComments");

            migrationBuilder.RenameColumn(
                name: "ParentId",
                table: "ProductComments",
                newName: "ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductComments_ParentId",
                table: "ProductComments",
                newName: "IX_ProductComments_ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductComments_Products_ProductId",
                table: "ProductComments",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductComments_Products_ProductId",
                table: "ProductComments");

            migrationBuilder.RenameColumn(
                name: "ProductId",
                table: "ProductComments",
                newName: "ParentId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductComments_ProductId",
                table: "ProductComments",
                newName: "IX_ProductComments_ParentId");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "ProductComments",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "ProductComments",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_ProductComments_Id",
                table: "ProductComments",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_ProductComments_UserId",
                table: "ProductComments",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductComments_Products_Id",
                table: "ProductComments",
                column: "Id",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductComments_ProductComments_ParentId",
                table: "ProductComments",
                column: "ParentId",
                principalTable: "ProductComments",
                principalColumn: "CommentId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductComments_Users_UserId",
                table: "ProductComments",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
