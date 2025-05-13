using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OrderManagerBack.Migrations
{
    /// <inheritdoc />
    public partial class UpdateProduction : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Order",
                table: "Production",
                type: "VARCHAR(50)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VARCHAR(50)",
                oldMaxLength: 50);

            migrationBuilder.CreateIndex(
                name: "IX_Production_MaterialCode",
                table: "Production",
                column: "MaterialCode");

            migrationBuilder.CreateIndex(
                name: "IX_Production_Order",
                table: "Production",
                column: "Order");

            migrationBuilder.AddForeignKey(
                name: "FK_Production_Material_MaterialCode",
                table: "Production",
                column: "MaterialCode",
                principalTable: "Material",
                principalColumn: "MaterialCode",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Production_Order_Order",
                table: "Production",
                column: "Order",
                principalTable: "Order",
                principalColumn: "Order");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Production_Material_MaterialCode",
                table: "Production");

            migrationBuilder.DropForeignKey(
                name: "FK_Production_Order_Order",
                table: "Production");

            migrationBuilder.DropIndex(
                name: "IX_Production_MaterialCode",
                table: "Production");

            migrationBuilder.DropIndex(
                name: "IX_Production_Order",
                table: "Production");

            migrationBuilder.AlterColumn<string>(
                name: "Order",
                table: "Production",
                type: "VARCHAR(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "VARCHAR(50)",
                oldNullable: true);
        }
    }
}
