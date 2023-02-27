using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace P04Sklep.API.Migrations
{
    /// <inheritdoc />
    public partial class MaterialCategoryIdAddNullable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_MaterialCategories_MaterialCategoryId",
                table: "Products");

            

            migrationBuilder.AlterColumn<int>(
                name: "MaterialCategoryId",
                table: "Products",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");


           
            migrationBuilder.AddForeignKey(
                name: "FK_Products_MaterialCategories_MaterialCategoryId",
                table: "Products",
                column: "MaterialCategoryId",
                principalTable: "MaterialCategories",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_MaterialCategories_MaterialCategoryId",
                table: "Products");

         
            migrationBuilder.AlterColumn<int>(
                name: "MaterialCategoryId",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_MaterialCategories_MaterialCategoryId",
                table: "Products",
                column: "MaterialCategoryId",
                principalTable: "MaterialCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
