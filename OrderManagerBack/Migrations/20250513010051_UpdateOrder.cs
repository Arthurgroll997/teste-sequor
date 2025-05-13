using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OrderManagerBack.Migrations
{
    /// <inheritdoc />
    public partial class UpdateOrder : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Order_ProductCode",
                table: "Order",
                column: "ProductCode");

            migrationBuilder.AddForeignKey(
                name: "FK_Order_Product_ProductCode",
                table: "Order",
                column: "ProductCode",
                principalTable: "Product",
                principalColumn: "ProductCode",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Order_Product_ProductCode",
                table: "Order");

            migrationBuilder.DropIndex(
                name: "IX_Order_ProductCode",
                table: "Order");
        }
    }
}
