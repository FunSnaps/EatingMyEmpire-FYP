using EatingMyEmpire.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EatingMyEmpire.Api.Models
{
    public interface IRecipeStepRepository
    {
        Task<IEnumerable<RecipeStep>> GetRecipeSteps();
        Task<RecipeStep> GetRecipeStep(int RecipeStepId);
    }
}
