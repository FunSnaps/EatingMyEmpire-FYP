using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EatingMyEmpire.Api.Models
{
    public interface IRecipeRepository
    {
        Task<IEnumerable<Shared.Recipe>> GetRecipes();
        Task<Shared.Recipe> GetRecipe(int RecipeId);
        Task<Shared.Recipe> GetRecipeByName(string RecipeName);
        Task<Shared.Recipe> AddRecipe(Shared.Recipe Recipe);
        Task<Shared.Recipe> UpdateRecipe(Shared.Recipe Recipe);
        void DeleteRecipe(int RecipeId);
    }
}
