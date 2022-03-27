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
        [Inject]
        public IRecipeService RecipeService { get; set; }

        public bool ShowFooter { get; set; } = true;

        public IEnumerable<Recipe> Recipes { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Recipes = (await RecipeService.GetRecipes()).ToList();
        }
    }
}
