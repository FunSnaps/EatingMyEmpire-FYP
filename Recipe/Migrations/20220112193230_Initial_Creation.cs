﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace EatingMyEmpire.Api.Migrations
{
    public partial class Initial_Creation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                name: "Recipe",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RecipeName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RecipeDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhotoPath = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recipe", x => x.id);
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
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "SuggestedMenu",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MenuTypeId = table.Column<int>(type: "int", nullable: false),
                    MenuName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MenuDescription = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SuggestedMenu", x => x.id);
                    table.ForeignKey(
                        name: "FK_SuggestedMenu_MenuType_MenuTypeId",
                        column: x => x.MenuTypeId,
                        principalTable: "MenuType",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "RecipeStep",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RecipeId = table.Column<int>(type: "int", nullable: false),
                    Instructions = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RecipeStep", x => x.id);
                    table.ForeignKey(
                        name: "FK_RecipeStep_Recipe_RecipeId",
                        column: x => x.RecipeId,
                        principalTable: "Recipe",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "MenuCourse",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SuggestedMenuId = table.Column<int>(type: "int", nullable: false),
                    CourseName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MenuCourse", x => x.id);
                    table.ForeignKey(
                        name: "FK_MenuCourse_SuggestedMenu_SuggestedMenuId",
                        column: x => x.SuggestedMenuId,
                        principalTable: "SuggestedMenu",
                        principalColumn: "id");
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
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_RecipeStepIngredient_Recipe_RecipeId",
                        column: x => x.RecipeId,
                        principalTable: "Recipe",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_RecipeStepIngredient_RecipeStep_RecipeStepId",
                        column: x => x.RecipeStepId,
                        principalTable: "RecipeStep",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "CourseRecipeChoice",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MenuCourseId = table.Column<int>(type: "int", nullable: false),
                    SuggestedMenuId = table.Column<int>(type: "int", nullable: false),
                    RecipeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseRecipeChoice", x => x.id);
                    table.ForeignKey(
                        name: "FK_CourseRecipeChoice_MenuCourse_MenuCourseId",
                        column: x => x.MenuCourseId,
                        principalTable: "MenuCourse",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_CourseRecipeChoice_Recipe_RecipeId",
                        column: x => x.RecipeId,
                        principalTable: "Recipe",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_CourseRecipeChoice_SuggestedMenu_SuggestedMenuId",
                        column: x => x.SuggestedMenuId,
                        principalTable: "SuggestedMenu",
                        principalColumn: "id");
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
                name: "IX_RecipeStep_RecipeId",
                table: "RecipeStep",
                column: "RecipeId");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CourseRecipeChoice");

            migrationBuilder.DropTable(
                name: "RecipeStepIngredient");

            migrationBuilder.DropTable(
                name: "MenuCourse");

            migrationBuilder.DropTable(
                name: "Ingredient");

            migrationBuilder.DropTable(
                name: "RecipeStep");

            migrationBuilder.DropTable(
                name: "SuggestedMenu");

            migrationBuilder.DropTable(
                name: "IngredientType");

            migrationBuilder.DropTable(
                name: "Recipe");

            migrationBuilder.DropTable(
                name: "MenuType");
        }
    }
}