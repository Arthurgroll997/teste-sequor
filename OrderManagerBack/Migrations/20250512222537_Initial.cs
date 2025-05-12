using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OrderManagerBack.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Material",
                columns: table => new
                {
                    MaterialCode = table.Column<string>(type: "VARCHAR(50)", maxLength: 50, nullable: false),
                    MaterialDescription = table.Column<string>(type: "VARCHAR(500)", maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Material", x => x.MaterialCode);
                });

            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    Order = table.Column<string>(type: "VARCHAR(50)", maxLength: 50, nullable: false),
                    Quantity = table.Column<decimal>(type: "NUMERIC(18,2)", nullable: false),
                    ProductCode = table.Column<string>(type: "VARCHAR(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.Order);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    ProductCode = table.Column<string>(type: "VARCHAR(50)", maxLength: 50, nullable: false),
                    ProductDescription = table.Column<string>(type: "VARCHAR(50)", maxLength: 50, nullable: false),
                    Image = table.Column<string>(type: "VARCHAR(500)", maxLength: 500, nullable: false),
                    CycleTime = table.Column<decimal>(type: "NUMERIC(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.ProductCode);
                });

            migrationBuilder.CreateTable(
                name: "Production",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "VARCHAR(100)", maxLength: 100, nullable: false),
                    Order = table.Column<string>(type: "VARCHAR(50)", maxLength: 50, nullable: false),
                    Date = table.Column<DateTime>(type: "DATETIME", nullable: false),
                    Quantity = table.Column<decimal>(type: "NUMERIC(18,2)", nullable: false),
                    MaterialCode = table.Column<string>(type: "VARCHAR(50)", maxLength: 50, nullable: false),
                    CycleTime = table.Column<decimal>(type: "NUMERIC(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Production", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Email = table.Column<string>(type: "VARCHAR(100)", maxLength: 100, nullable: false),
                    Name = table.Column<string>(type: "VARCHAR(50)", maxLength: 50, nullable: false),
                    InitialDate = table.Column<DateTime>(type: "DATETIME", nullable: false),
                    EndDate = table.Column<DateTime>(type: "DATETIME", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Email);
                });

            migrationBuilder.CreateTable(
                name: "ProductMaterial",
                columns: table => new
                {
                    ProductCode = table.Column<string>(type: "VARCHAR(50)", nullable: false),
                    MaterialCode = table.Column<string>(type: "VARCHAR(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductMaterial", x => new { x.ProductCode, x.MaterialCode });
                    table.ForeignKey(
                        name: "FK_ProductMaterial_Material_MaterialCode",
                        column: x => x.MaterialCode,
                        principalTable: "Material",
                        principalColumn: "MaterialCode",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductMaterial_Product_ProductCode",
                        column: x => x.ProductCode,
                        principalTable: "Product",
                        principalColumn: "ProductCode",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductMaterial_MaterialCode",
                table: "ProductMaterial",
                column: "MaterialCode");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.DropTable(
                name: "Production");

            migrationBuilder.DropTable(
                name: "ProductMaterial");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "Material");

            migrationBuilder.DropTable(
                name: "Product");
        }
    }
}
