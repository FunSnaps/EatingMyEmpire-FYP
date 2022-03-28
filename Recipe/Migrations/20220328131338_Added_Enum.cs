using Microsoft.EntityFrameworkCore.Migrations;

namespace EatingMyEmpire.Api.Migrations
{
    public partial class Added_Enum : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
           

            migrationBuilder.AddColumn<int>(
                name: "CourseType",
                table: "Recipe",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CourseType",
                table: "Recipe");

            migrationBuilder.CreateTable(
                name: "IngredientType",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IngredientType", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "MenuType",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MenuTypeDescription = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MenuType", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Ingredient",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IngredientTypeId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ingredient", x => x.id);
                    table.ForeignKey(
                        name: "FK_Ingredient_IngredientType_IngredientTypeId",
                        column: x => x.IngredientTypeId,
                        principalTable: "IngredientType",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SuggestedMenu",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MenuDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MenuName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MenuTypeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SuggestedMenu", x => x.id);
                    table.ForeignKey(
                        name: "FK_SuggestedMenu_MenuType_MenuTypeId",
                        column: x => x.MenuTypeId,
                        principalTable: "MenuType",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RecipeStepIngredient",
                columns: table => new
                {
                    RecipeId = table.Column<int>(type: "int", nullable: false),
                    RecipeStepId = table.Column<int>(type: "int", nullable: false),
                    IngredientId = table.Column<int>(type: "int", nullable: false),
                    AmountRequired = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RecipeStepIngredient", x => new { x.RecipeId, x.RecipeStepId, x.IngredientId });
                    table.ForeignKey(
                        name: "FK_RecipeStepIngredient_Ingredient_IngredientId",
                        column: x => x.IngredientId,
                        principalTable: "Ingredient",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RecipeStepIngredient_Recipe_RecipeId",
                        column: x => x.RecipeId,
                        principalTable: "Recipe",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RecipeStepIngredient_RecipeStep_RecipeStepId",
                        column: x => x.RecipeStepId,
                        principalTable: "RecipeStep",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MenuCourse",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourseName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SuggestedMenuId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MenuCourse", x => x.id);
                    table.ForeignKey(
                        name: "FK_MenuCourse_SuggestedMenu_SuggestedMenuId",
                        column: x => x.SuggestedMenuId,
                        principalTable: "SuggestedMenu",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CourseRecipeChoice",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MenuCourseId = table.Column<int>(type: "int", nullable: false),
                    RecipeId = table.Column<int>(type: "int", nullable: false),
                    SuggestedMenuId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseRecipeChoice", x => x.id);
                    table.ForeignKey(
                        name: "FK_CourseRecipeChoice_MenuCourse_MenuCourseId",
                        column: x => x.MenuCourseId,
                        principalTable: "MenuCourse",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CourseRecipeChoice_Recipe_RecipeId",
                        column: x => x.RecipeId,
                        principalTable: "Recipe",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CourseRecipeChoice_SuggestedMenu_SuggestedMenuId",
                        column: x => x.SuggestedMenuId,
                        principalTable: "SuggestedMenu",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CourseRecipeChoice_MenuCourseId",
                table: "CourseRecipeChoice",
                column: "MenuCourseId");

            migrationBuilder.CreateIndex(
                name: "IX_CourseRecipeChoice_RecipeId",
                table: "CourseRecipeChoice",
                column: "RecipeId");

            migrationBuilder.CreateIndex(
                name: "IX_CourseRecipeChoice_SuggestedMenuId",
                table: "CourseRecipeChoice",
                column: "SuggestedMenuId");

            migrationBuilder.CreateIndex(
                name: "IX_Ingredient_IngredientTypeId",
                table: "Ingredient",
                column: "IngredientTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_MenuCourse_SuggestedMenuId",
                table: "MenuCourse",
                column: "SuggestedMenuId");

            migrationBuilder.CreateIndex(
                name: "IX_RecipeStepIngredient_IngredientId",
                table: "RecipeStepIngredient",
                column: "IngredientId");

            migrationBuilder.CreateIndex(
                name: "IX_RecipeStepIngredient_RecipeStepId",
                table: "RecipeStepIngredient",
                column: "RecipeStepId");

            migrationBuilder.CreateIndex(
                name: "IX_SuggestedMenu_MenuTypeId",
                table: "SuggestedMenu",
                column: "MenuTypeId");
        }
    }
}
