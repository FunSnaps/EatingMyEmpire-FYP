using EatingMyEmpire.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EatingMyEmpire.Client.Services
{
    public interface IRecipeStepService
    {
        Task<IEnumerable<RecipeStep>> GetRecipeSteps();
        Task<RecipeStep> GetRecipeStep(int id);
    }
}
