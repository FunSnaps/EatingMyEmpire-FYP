using EatingMyEmpire.Client.Services;
using EatingMyEmpire.Shared;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace EatingMyEmpire.Client.Pages
{
    public class RecipeListBase : ComponentBase
    {
        static readonly HttpClient client = new HttpClient();

        [Inject]
        public IRecipeService RecipeService { get; set; }

        public IEnumerable<Recipe> Recipes { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Recipes = (await RecipeService.GetRecipes()).ToList();
            /*await Task.Run(LoadSampleRecipes);*/
        }

        /*private void LoadSampleRecipes()
        {
            Recipe r1 = new Recipe
            {
                RecipeName = "Adobo",
                RecipeDescription = "Philippine's national food",
                PhotoPath = "images/adobo.jpg"
            };

            Recipe r2 = new Recipe
            {
                RecipeName = "Sizzling Sisig",
                RecipeDescription = "My Favourite pinoy dish!",
                PhotoPath = "images/Sizzling-Sisig.jpg"
            };

            Recipe r3 = new Recipe
            {
                RecipeName = "Chicken Tikka Masala",
                RecipeDescription = "England's national food",
                PhotoPath = "images/Chicken-Tikka-Masala.jpg"
            };

            Recipes = new List<Recipe> { r1, r2, r3 };
        }*/
    }
}
