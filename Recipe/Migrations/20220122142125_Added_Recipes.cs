using Microsoft.EntityFrameworkCore.Migrations;

namespace EatingMyEmpire.Api.Migrations
{
    public partial class Added_Recipes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Recipe",
                columns: new[] { "id", "PhotoPath", "RecipeDescription", "RecipeName" },
                values: new object[] { 1, "images/adobo.jpg", "Philippine's national food", "Adobo" });

            migrationBuilder.InsertData(
                table: "Recipe",
                columns: new[] { "id", "PhotoPath", "RecipeDescription", "RecipeName" },
                values: new object[] { 2, "images/Sizzling-Sisig.jpg", "My Favourite pinoy dish!", "Sizzling Sisig" });

            migrationBuilder.InsertData(
                table: "Recipe",
                columns: new[] { "id", "PhotoPath", "RecipeDescription", "RecipeName" },
                values: new object[] { 3, "images/Chicken-Tikka-Masala.jpg", "England's national food", "Chicken Tikka Masala" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Recipe",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Recipe",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Recipe",
                keyColumn: "id",
                keyValue: 3);
        }
    }
}
