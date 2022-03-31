using EatingMyEmpire.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EatingMyEmpire.Client.Services
{
    public interface IRecipeService
    {
        Task<IEnumerable<Recipe>> GetRecipes();
        Task<Recipe> GetRecipe(int id);
        Task<Recipe> UpdateRecipe(Recipe updatedRecipe, int id);
        Task<Recipe> CreateRecipe(Recipe newRecipe);
    }
}
