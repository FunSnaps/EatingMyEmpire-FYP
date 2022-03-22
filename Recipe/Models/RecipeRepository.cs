using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EatingMyEmpire.Api.Models
{
    public class RecipeRepository : IRecipeRepository
    {
        private ApplicationDbContext applicationDbContext;

        public RecipeRepository(ApplicationDbContext applicationDbContext)
        {
            this.applicationDbContext = applicationDbContext;
        }

        public async Task<Shared.Recipe> AddRecipe(Shared.Recipe recipe)
        {
            var result = await applicationDbContext.Recipe.AddAsync(recipe);
            await applicationDbContext.SaveChangesAsync();
            return result.Entity;
        }

        public async void DeleteRecipe(int RecipeId)
        {
            var result = await applicationDbContext.Recipe.FirstOrDefaultAsync(e => e.id == RecipeId);

            if (result != null)
            {
                applicationDbContext.Recipe.Remove(result);
                await applicationDbContext.SaveChangesAsync();
            }
        }

        public async Task<Shared.Recipe> GetRecipe(int RecipeId)
        {
            return await applicationDbContext.Recipe.FirstOrDefaultAsync(e => e.id == RecipeId);
        }

        public async Task<IEnumerable<Shared.Recipe>> GetRecipes()
        {
            return await applicationDbContext.Recipe.ToListAsync();
        }

        public async Task<Shared.Recipe> GetRecipeByName(string RecipeName)
        {
            return await applicationDbContext.Recipe.FirstOrDefaultAsync(e => e.RecipeName == RecipeName);
        }

        public async Task<Shared.Recipe> UpdateRecipe(Shared.Recipe recipe)
        {
            var result = await applicationDbContext.Recipe.FirstOrDefaultAsync(e => e.id == recipe.id);

            if (result != null)
            {
                result.RecipeName = recipe.RecipeName;
                result.RecipeDescription = recipe.RecipeDescription;
                result.PhotoPath = recipe.PhotoPath;

                await applicationDbContext.SaveChangesAsync();

                return result;
            }
            return null;
        }
    }
}
