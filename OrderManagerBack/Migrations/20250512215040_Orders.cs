using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OrderManagerBack.Migrations
{
    /// <inheritdoc />
    public partial class Orders : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Order");
        }
    }
}
