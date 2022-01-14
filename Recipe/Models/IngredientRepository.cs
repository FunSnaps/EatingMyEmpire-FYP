using EatingMyEmpire.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EatingMyEmpire.Api.Models
{
    public class IngredientRepository : IIngredientRepository
    {
        private ApplicationDbContext applicationDbContext;

        public IngredientRepository(ApplicationDbContext applicationDbContext)
        {
            this.applicationDbContext = applicationDbContext;
        }

        public IEnumerable<Ingredient> GetIngredients()
        {
            return applicationDbContext.Ingredient;
        }

        public Ingredient GetIngredient(int IngredientId)
        {
            return applicationDbContext.Ingredient.FirstOrDefault(i => i.id == IngredientId);
        }
    }
}
