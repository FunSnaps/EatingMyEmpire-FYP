using Microsoft.EntityFrameworkCore.Migrations;

namespace EatingMyEmpire.Api.Migrations
{
    public partial class Added_Recipes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Recipe",
                columns: new[] { "id", "PhotoPath", "RecipeDescription", "RecipeName", "RecipeStepId" },
                values: new object[] { 1, "images/adobo.jpg", "Chicken Adobo is a type of Filipino chicken stew. Chicken pieces are marinated in soy sauce and spices, pan-fried, and stewed until tender. The dish gained popularity because of its delicious taste and ease in preparation.", "Adobo", 1 });

            migrationBuilder.InsertData(
                table: "Recipe",
                columns: new[] { "id", "PhotoPath", "RecipeDescription", "RecipeName", "RecipeStepId" },
                values: new object[] { 2, "images/Sizzling-Sisig.jpg", "Sizzling Crispy Sisig is a great dish to prepare during Christmas dinner or in any special occasion. It has a nice texture and the flavor is out-of-this-world. I enjoy having it for dinner with a cup of white rice. It can also be served as an appetizer along with a cold bottle or glass of your favorite drink.", "Sizzling Sisig", 2 });

            migrationBuilder.InsertData(
                table: "Recipe",
                columns: new[] { "id", "PhotoPath", "RecipeDescription", "RecipeName", "RecipeStepId" },
                values: new object[] { 3, "images/Chicken-Tikka-Masala.jpg", "This rich and creamy flavoursome Chicken tikka rivals any Indian restaurant! Why go out when you can make it better at home! With aromatic golden chicken pieces swimming in an incredible curry sauce, this Chicken Tikka Masala recipe is one of the best you will try! Pair it with our buttery garlic naan breads!", "Chicken Tikka Masala", 3 });
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
