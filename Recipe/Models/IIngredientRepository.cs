using EatingMyEmpire.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EatingMyEmpire.Api.Models
{
    public interface IIngredientRepository
    {
        IEnumerable<Ingredient> GetIngredients();
        Ingredient GetIngredient(int IngredientId);
    }
}
