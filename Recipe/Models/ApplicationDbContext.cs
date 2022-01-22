using EatingMyEmpire.Shared;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EatingMyEmpire.Api.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<RecipeStepIngredient>()
                .HasKey(x => new { x.RecipeId, x.RecipeStepId, x.IngredientId });

            foreach (var foreignkey in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                foreignkey.DeleteBehavior = DeleteBehavior.Restrict;
            }

            modelBuilder.Entity<Shared.Recipe>().HasData(new Shared.Recipe
            {
                id = 1,
                RecipeName = "Adobo",
                RecipeDescription = "Philippine's national food",
                PhotoPath = "images/adobo.jpg"
            });

            modelBuilder.Entity<Shared.Recipe>().HasData(new Shared.Recipe
            {
                id = 2,
                RecipeName = "Sizzling Sisig",
                RecipeDescription = "My Favourite pinoy dish!",
                PhotoPath = "images/Sizzling-Sisig.jpg"
            });

            modelBuilder.Entity<Shared.Recipe>().HasData(new Shared.Recipe
            {
                id = 3,
                RecipeName = "Chicken Tikka Masala",
                RecipeDescription = "England's national food",
                PhotoPath = "images/Chicken-Tikka-Masala.jpg"
            });
        }

        public DbSet<MenuType> MenuType { get; set; }
        public DbSet<SuggestedMenu> SuggestedMenu { get; set; }
        public DbSet<MenuCourse> MenuCourse { get; set; }
        public DbSet<Shared.Recipe> Recipe { get; set; }
        public DbSet<CourseRecipeChoice> CourseRecipeChoice { get; set; }
        public DbSet<RecipeStep> RecipeStep { get; set; }
        public DbSet<IngredientType> IngredientType { get; set; }
        public DbSet<RecipeStepIngredient> RecipeStepIngredient { get; set; }
        public DbSet<Ingredient> Ingredient { get; set; }
    }
}
