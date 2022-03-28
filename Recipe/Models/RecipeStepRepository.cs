using EatingMyEmpire.Shared;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EatingMyEmpire.Api.Models
{
    public class RecipeStepRepository : IRecipeStepRepository
    {
        private readonly ApplicationDbContext applicationDbContext;

        public RecipeStepRepository(ApplicationDbContext applicationDbContext)
        {
            this.applicationDbContext = applicationDbContext;
        }

        public async Task<RecipeStep> GetRecipeStep(int RecipeStepId)
        {
            return await applicationDbContext.RecipeStep.FirstOrDefaultAsync(r => r.id == RecipeStepId);
        }

        public async Task<IEnumerable<RecipeStep>> GetRecipeSteps()
        {
            return await applicationDbContext.RecipeStep.ToListAsync();
        }
    }
}
