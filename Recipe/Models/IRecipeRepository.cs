using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EatingMyEmpire.Api.Models
{
    public interface IRecipeRepository
    {
        Task<Shared.Recipe> GetRecipe(int RecipeId);
        Task<IEnumerable<Shared.Recipe>> GetRecipes();
        Task<IEnumerable<Shared.Recipe>> Search(string RecipeName, string RecipeDescription);
        Task<Shared.Recipe> GetRecipeByName(string RecipeName);
        Task<Shared.Recipe> CreateRecipe(Shared.Recipe Recipe);
        Task<Shared.Recipe> UpdateRecipe(Shared.Recipe Recipe);
        Task<Shared.Recipe> DeleteRecipe(int RecipeId);
    }
}
