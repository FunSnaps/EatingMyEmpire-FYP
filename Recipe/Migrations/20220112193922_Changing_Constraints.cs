using Microsoft.EntityFrameworkCore.Migrations;

namespace EatingMyEmpire.Api.Migrations
{
    public partial class Changing_Constraints : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CourseRecipeChoice_MenuCourse_MenuCourseId",
                table: "CourseRecipeChoice");

            migrationBuilder.DropForeignKey(
                name: "FK_CourseRecipeChoice_Recipe_RecipeId",
                table: "CourseRecipeChoice");

            migrationBuilder.DropForeignKey(
                name: "FK_CourseRecipeChoice_SuggestedMenu_SuggestedMenuId",
                table: "CourseRecipeChoice");

            migrationBuilder.DropForeignKey(
                name: "FK_Ingredient_IngredientType_IngredientTypeId",
                table: "Ingredient");

            migrationBuilder.DropForeignKey(
                name: "FK_MenuCourse_SuggestedMenu_SuggestedMenuId",
                table: "MenuCourse");

            migrationBuilder.DropForeignKey(
                name: "FK_RecipeStep_Recipe_RecipeId",
                table: "RecipeStep");

            migrationBuilder.DropForeignKey(
                name: "FK_RecipeStepIngredient_Ingredient_IngredientId",
                table: "RecipeStepIngredient");

            migrationBuilder.DropForeignKey(
                name: "FK_RecipeStepIngredient_Recipe_RecipeId",
                table: "RecipeStepIngredient");

            migrationBuilder.DropForeignKey(
                name: "FK_RecipeStepIngredient_RecipeStep_RecipeStepId",
                table: "RecipeStepIngredient");

            migrationBuilder.DropForeignKey(
                name: "FK_SuggestedMenu_MenuType_MenuTypeId",
                table: "SuggestedMenu");

            migrationBuilder.AddForeignKey(
                name: "FK_CourseRecipeChoice_MenuCourse_MenuCourseId",
                table: "CourseRecipeChoice",
                column: "MenuCourseId",
                principalTable: "MenuCourse",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CourseRecipeChoice_Recipe_RecipeId",
                table: "CourseRecipeChoice",
                column: "RecipeId",
                principalTable: "Recipe",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CourseRecipeChoice_SuggestedMenu_SuggestedMenuId",
                table: "CourseRecipeChoice",
                column: "SuggestedMenuId",
                principalTable: "SuggestedMenu",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Ingredient_IngredientType_IngredientTypeId",
                table: "Ingredient",
                column: "IngredientTypeId",
                principalTable: "IngredientType",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MenuCourse_SuggestedMenu_SuggestedMenuId",
                table: "MenuCourse",
                column: "SuggestedMenuId",
                principalTable: "SuggestedMenu",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_RecipeStep_Recipe_RecipeId",
                table: "RecipeStep",
                column: "RecipeId",
                principalTable: "Recipe",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_RecipeStepIngredient_Ingredient_IngredientId",
                table: "RecipeStepIngredient",
                column: "IngredientId",
                principalTable: "Ingredient",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_RecipeStepIngredient_Recipe_RecipeId",
                table: "RecipeStepIngredient",
                column: "RecipeId",
                principalTable: "Recipe",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_RecipeStepIngredient_RecipeStep_RecipeStepId",
                table: "RecipeStepIngredient",
                column: "RecipeStepId",
                principalTable: "RecipeStep",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SuggestedMenu_MenuType_MenuTypeId",
                table: "SuggestedMenu",
                column: "MenuTypeId",
                principalTable: "MenuType",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CourseRecipeChoice_MenuCourse_MenuCourseId",
                table: "CourseRecipeChoice");

            migrationBuilder.DropForeignKey(
                name: "FK_CourseRecipeChoice_Recipe_RecipeId",
                table: "CourseRecipeChoice");

            migrationBuilder.DropForeignKey(
                name: "FK_CourseRecipeChoice_SuggestedMenu_SuggestedMenuId",
                table: "CourseRecipeChoice");

            migrationBuilder.DropForeignKey(
                name: "FK_Ingredient_IngredientType_IngredientTypeId",
                table: "Ingredient");

            migrationBuilder.DropForeignKey(
                name: "FK_MenuCourse_SuggestedMenu_SuggestedMenuId",
                table: "MenuCourse");

            migrationBuilder.DropForeignKey(
                name: "FK_RecipeStep_Recipe_RecipeId",
                table: "RecipeStep");

            migrationBuilder.DropForeignKey(
                name: "FK_RecipeStepIngredient_Ingredient_IngredientId",
                table: "RecipeStepIngredient");

            migrationBuilder.DropForeignKey(
                name: "FK_RecipeStepIngredient_Recipe_RecipeId",
                table: "RecipeStepIngredient");

            migrationBuilder.DropForeignKey(
                name: "FK_RecipeStepIngredient_RecipeStep_RecipeStepId",
                table: "RecipeStepIngredient");

            migrationBuilder.DropForeignKey(
                name: "FK_SuggestedMenu_MenuType_MenuTypeId",
                table: "SuggestedMenu");

            migrationBuilder.AddForeignKey(
                name: "FK_CourseRecipeChoice_MenuCourse_MenuCourseId",
                table: "CourseRecipeChoice",
                column: "MenuCourseId",
                principalTable: "MenuCourse",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_CourseRecipeChoice_Recipe_RecipeId",
                table: "CourseRecipeChoice",
                column: "RecipeId",
                principalTable: "Recipe",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_CourseRecipeChoice_SuggestedMenu_SuggestedMenuId",
                table: "CourseRecipeChoice",
                column: "SuggestedMenuId",
                principalTable: "SuggestedMenu",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_Ingredient_IngredientType_IngredientTypeId",
                table: "Ingredient",
                column: "IngredientTypeId",
                principalTable: "IngredientType",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_MenuCourse_SuggestedMenu_SuggestedMenuId",
                table: "MenuCourse",
                column: "SuggestedMenuId",
                principalTable: "SuggestedMenu",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_RecipeStep_Recipe_RecipeId",
                table: "RecipeStep",
                column: "RecipeId",
                principalTable: "Recipe",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_RecipeStepIngredient_Ingredient_IngredientId",
                table: "RecipeStepIngredient",
                column: "IngredientId",
                principalTable: "Ingredient",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_RecipeStepIngredient_Recipe_RecipeId",
                table: "RecipeStepIngredient",
                column: "RecipeId",
                principalTable: "Recipe",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_RecipeStepIngredient_RecipeStep_RecipeStepId",
                table: "RecipeStepIngredient",
                column: "RecipeStepId",
                principalTable: "RecipeStep",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_SuggestedMenu_MenuType_MenuTypeId",
                table: "SuggestedMenu",
                column: "MenuTypeId",
                principalTable: "MenuType",
                principalColumn: "id");
        }
    }
}
