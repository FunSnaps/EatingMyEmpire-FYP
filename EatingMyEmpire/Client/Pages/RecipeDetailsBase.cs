using EatingMyEmpire.Client.Services;
using EatingMyEmpire.Shared;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EatingMyEmpire.Client.Pages
{
    public class RecipeDetailsBase : ComponentBase
    {
        public Recipe Recipe { get; set; } = new Recipe();

        public RecipeStep RecipeStep { get; set; } = new RecipeStep();

        [Inject]
        public IRecipeService RecipeService { get; set; }

        [Parameter]
        public string id { get; set; }

        protected async override Task OnInitializedAsync()
        {
           id = id ?? "1008";
           Recipe = await RecipeService.GetRecipe(int.Parse(id));
        }
    }
}
