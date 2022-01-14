using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EatingMyEmpire.Api.Models
{
    public interface IRecipeRepository
    {
        Task<IEnumerable<EatingMyEmpire.Shared.Recipe>> GetRecipes();
        Task<EatingMyEmpire.Shared.Recipe> GetRecipe(int RecipeId);
        Task<EatingMyEmpire.Shared.Recipe> AddRecipe(EatingMyEmpire.Shared.Recipe Recipe);
        Task<EatingMyEmpire.Shared.Recipe> UpdateRecipe(EatingMyEmpire.Shared.Recipe Recipe);
        void DeleteRecipe(int RecipeId);
    }
}
